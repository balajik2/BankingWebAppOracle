
using System;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using BankingWebApp.Models;

namespace BankingWebApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly string _connString;
        public EmployeeController(IConfiguration config)
        {
            _connString = config.GetConnectionString("OracleDb")
                ?? throw new InvalidOperationException("Missing connection string 'OracleDb'.");
        }

        // INDEX
        public IActionResult Index()
        {
            using var conn = new OracleConnection(_connString);
            using var cmd = new OracleCommand("SELECT * FROM EMPLOYEES ORDER BY EMPLOYEE_ID", conn);
            using var ad = new OracleDataAdapter(cmd);
            var dt = new DataTable();
            conn.Open();
            ad.Fill(dt);
            return View(dt);
        }

        // CREATE
        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(string FirstName, string LastName, string? Position, decimal? Salary, int? BranchId)
        {
            const string sql = @"INSERT INTO EMPLOYEES (FIRST_NAME, LAST_NAME, POSITION, SALARY, BRANCH_ID)
                                 VALUES (:p_first, :p_last, :p_pos, :p_sal, :p_branch)";
            using var conn = new OracleConnection(_connString);
            using var cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(new OracleParameter("p_first", FirstName));
            cmd.Parameters.Add(new OracleParameter("p_last", LastName));
            cmd.Parameters.Add(new OracleParameter("p_pos", (object?)Position ?? DBNull.Value));
            cmd.Parameters.Add(new OracleParameter("p_sal", (object?)Salary ?? DBNull.Value));
            cmd.Parameters.Add(new OracleParameter("p_branch", (object?)BranchId ?? DBNull.Value));
            conn.Open();
            cmd.ExecuteNonQuery();
            TempData["Message"] = "Employee created successfully.";
            return RedirectToAction(nameof(Index));
        }

        // EDIT (Position, Salary, Branch)
        [HttpGet]
        public IActionResult Edit(int id)
        {
            const string sql = "SELECT EMPLOYEE_ID, POSITION, SALARY, BRANCH_ID FROM EMPLOYEES WHERE EMPLOYEE_ID = :p_id";
            using var conn = new OracleConnection(_connString);
            using var cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(new OracleParameter("p_id", id));
            conn.Open();
            using var rdr = cmd.ExecuteReader();
            if (!rdr.Read()) return NotFound();
            var vm = new EmployeeEditViewModel
            {
                EmployeeId = Convert.ToInt32(rdr["EMPLOYEE_ID"]),
                Position = rdr["POSITION"] as string,
                Salary = rdr["SALARY"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(rdr["SALARY"]),
                BranchId = rdr["BRANCH_ID"] == DBNull.Value ? (int?)null : Convert.ToInt32(rdr["BRANCH_ID"])
            };
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EmployeeEditViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            const string sql = "UPDATE EMPLOYEES SET POSITION = :p_pos, SALARY = :p_sal, BRANCH_ID = :p_branch WHERE EMPLOYEE_ID = :p_id";
            using var conn = new OracleConnection(_connString);
            using var cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(new OracleParameter("p_pos", (object?)model.Position ?? DBNull.Value));
            cmd.Parameters.Add(new OracleParameter("p_sal", (object?)model.Salary ?? DBNull.Value));
            cmd.Parameters.Add(new OracleParameter("p_branch", (object?)model.BranchId ?? DBNull.Value));
            cmd.Parameters.Add(new OracleParameter("p_id", model.EmployeeId));
            conn.Open();
            var rows = cmd.ExecuteNonQuery();
            if (rows == 0) return NotFound();
            TempData["Message"] = $"Employee {model.EmployeeId} updated.";
            return RedirectToAction(nameof(Index));
        }
    }
}
