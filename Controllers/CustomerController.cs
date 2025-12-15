
using System;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using BankingWebApp.Models; // CustomerEditViewModel

namespace BankingWebApp.Controllers
{
    public class CustomerController : Controller
    {
        private readonly string _connString;

        public CustomerController(IConfiguration config)
        {
            _connString = config.GetConnectionString("OracleDb")
                ?? throw new InvalidOperationException("Missing connection string 'OracleDb'.");
        }

        // ---------------- INDEX (GET) ----------------
        public IActionResult Index()
        {
            using var conn = new OracleConnection(_connString);
            using var cmd = new OracleCommand("SELECT * FROM CUSTOMERS ORDER BY CUSTOMER_ID", conn);
            using var ad = new OracleDataAdapter(cmd);
            var dt = new DataTable();
            conn.Open();
            ad.Fill(dt);
            return View(dt); // Use a DataTable-based view similar to Account/Index
        }

        // ---------------- CREATE ----------------
        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(string FirstName,
                                    string LastName,
                                    string? Email,
                                    string? Phone,
                                    string? Address,
                                    DateTime? Dob,
                                    string? Gender)
        {
            const string sql = @"INSERT INTO CUSTOMERS (FIRST_NAME, LAST_NAME, EMAIL, PHONE, ADDRESS, DOB, GENDER)
                                VALUES (:p_first, :p_last, :p_email, :p_phone, :p_address, :p_dob, :p_gender)";
            using var conn = new OracleConnection(_connString);
            using var cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(new OracleParameter("p_first", FirstName));
            cmd.Parameters.Add(new OracleParameter("p_last", LastName));
            cmd.Parameters.Add(new OracleParameter("p_email", (object?)Email ?? DBNull.Value));
            cmd.Parameters.Add(new OracleParameter("p_phone", (object?)Phone ?? DBNull.Value));
            cmd.Parameters.Add(new OracleParameter("p_address", (object?)Address ?? DBNull.Value));
            cmd.Parameters.Add(new OracleParameter("p_dob", (object?)Dob ?? DBNull.Value));
            cmd.Parameters.Add(new OracleParameter("p_gender", (object?)Gender ?? DBNull.Value));
            conn.Open();
            cmd.ExecuteNonQuery();
            TempData["Message"] = "Customer created successfully.";
            return RedirectToAction(nameof(Index));
        }

        // ---------------- EDIT (GET) ----------------
        [HttpGet]
        public IActionResult Edit(int id)
        {
            const string sql = "SELECT CUSTOMER_ID, FIRST_NAME, LAST_NAME, EMAIL, PHONE, ADDRESS, DOB, GENDER FROM CUSTOMERS WHERE CUSTOMER_ID = :p_id";
            using var conn = new OracleConnection(_connString);
            using var cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(new OracleParameter("p_id", id));
            conn.Open();
            using var rdr = cmd.ExecuteReader();
            if (!rdr.Read()) return NotFound();

            var vm = new CustomerEditViewModel
            {
                CustomerId = Convert.ToInt32(rdr["CUSTOMER_ID"]),
                FirstName = rdr["FIRST_NAME"].ToString()!,
                LastName = rdr["LAST_NAME"].ToString()!,
                Email = rdr["EMAIL"] as string,
                Phone = rdr["PHONE"] as string,
                Address = rdr["ADDRESS"] as string,
                Dob = rdr["DOB"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(rdr["DOB"]),
                Gender = rdr["GENDER"] as string
            };
            return View(vm); // Views/Customer/Edit.cshtml should be strongly typed to CustomerEditViewModel
        }

        // ---------------- EDIT (POST) ----------------
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CustomerEditViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            const string sql = @"UPDATE CUSTOMERS
                                  SET FIRST_NAME = :p_first,
                                      LAST_NAME  = :p_last,
                                      EMAIL      = :p_email,
                                      PHONE      = :p_phone,
                                      ADDRESS    = :p_address,
                                      DOB        = :p_dob,
                                      GENDER     = :p_gender
                                  WHERE CUSTOMER_ID = :p_id";
            using var conn = new OracleConnection(_connString);
            using var cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(new OracleParameter("p_first", model.FirstName));
            cmd.Parameters.Add(new OracleParameter("p_last", model.LastName));
            cmd.Parameters.Add(new OracleParameter("p_email", (object?)model.Email ?? DBNull.Value));
            cmd.Parameters.Add(new OracleParameter("p_phone", (object?)model.Phone ?? DBNull.Value));
            cmd.Parameters.Add(new OracleParameter("p_address", (object?)model.Address ?? DBNull.Value));
            cmd.Parameters.Add(new OracleParameter("p_dob", (object?)model.Dob ?? DBNull.Value));
            cmd.Parameters.Add(new OracleParameter("p_gender", (object?)model.Gender ?? DBNull.Value));
            cmd.Parameters.Add(new OracleParameter("p_id", model.CustomerId));
            conn.Open();
            var rows = cmd.ExecuteNonQuery();
            if (rows == 0) return NotFound();

            TempData["Message"] = $"Customer {model.CustomerId} updated.";
            return RedirectToAction(nameof(Index));
        }
    }
}
