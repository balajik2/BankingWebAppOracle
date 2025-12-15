
using System;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using BankingWebApp.Models;

namespace BankingWebApp.Controllers
{
    public class LoanController : Controller
    {
        private readonly string _connString;
        public LoanController(IConfiguration config)
        {
            _connString = config.GetConnectionString("OracleDb")
                ?? throw new InvalidOperationException("Missing connection string 'OracleDb'.");
        }

        // INDEX
        public IActionResult Index()
        {
            using var conn = new OracleConnection(_connString);
            using var cmd = new OracleCommand("SELECT * FROM LOANS ORDER BY LOAN_ID", conn);
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
        public IActionResult Create(int CustomerId, int BranchId, decimal LoanAmount, decimal InterestRate, string Status = "ACTIVE", DateTime? StartDate = null, DateTime? EndDate = null)
        {
            const string sql = @"INSERT INTO LOANS (CUSTOMER_ID, BRANCH_ID, LOAN_AMOUNT, INTEREST_RATE, STATUS, START_DATE, END_DATE)
                                 VALUES (:p_cust, :p_branch, :p_amt, :p_rate, :p_status, :p_start, :p_end)";
            using var conn = new OracleConnection(_connString);
            using var cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(new OracleParameter("p_cust", CustomerId));
            cmd.Parameters.Add(new OracleParameter("p_branch", BranchId));
            cmd.Parameters.Add(new OracleParameter("p_amt", LoanAmount));
            cmd.Parameters.Add(new OracleParameter("p_rate", InterestRate));
            cmd.Parameters.Add(new OracleParameter("p_status", Status));
            cmd.Parameters.Add(new OracleParameter("p_start", (object?)StartDate ?? DBNull.Value));
            cmd.Parameters.Add(new OracleParameter("p_end", (object?)EndDate ?? DBNull.Value));
            conn.Open();
            cmd.ExecuteNonQuery();
            TempData["Message"] = "Loan created successfully.";
            return RedirectToAction(nameof(Index));
        }

        // EDIT (Status only)
        [HttpGet]
        public IActionResult Edit(int id)
        {
            const string sql = "SELECT LOAN_ID, STATUS FROM LOANS WHERE LOAN_ID = :p_id";
            using var conn = new OracleConnection(_connString);
            using var cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(new OracleParameter("p_id", id));
            conn.Open();
            using var rdr = cmd.ExecuteReader();
            if (!rdr.Read()) return NotFound();
            var vm = new LoanEditViewModel
            {
                LoanId = Convert.ToInt32(rdr["LOAN_ID"]),
                Status = rdr["STATUS"]?.ToString() ?? "ACTIVE"
            };
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(LoanEditViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            const string sql = "UPDATE LOANS SET STATUS = :p_status WHERE LOAN_ID = :p_id";
            using var conn = new OracleConnection(_connString);
            using var cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(new OracleParameter("p_status", model.Status));
            cmd.Parameters.Add(new OracleParameter("p_id", model.LoanId));
            conn.Open();
            var rows = cmd.ExecuteNonQuery();
            if (rows == 0) return NotFound();
            TempData["Message"] = $"Loan {model.LoanId} updated.";
            return RedirectToAction(nameof(Index));
        }
    }
}
