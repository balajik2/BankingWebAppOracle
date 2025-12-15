
using System;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using BankingWebApp.Models; // AccountEditViewModel

namespace BankingWebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly string _connString;

        public AccountController(IConfiguration config)
        {
            _connString = config.GetConnectionString("OracleDb")
                         ?? throw new InvalidOperationException("Missing connection string 'OracleDb'.");
        }

        // -------- INDEX (GET) ----------
        public IActionResult Index()
        {
            using var conn = new OracleConnection(_connString);
            using var cmd = new OracleCommand("SELECT * FROM ACCOUNTS ORDER BY ACCOUNT_ID", conn);
            using var ad = new OracleDataAdapter(cmd);
            var dt = new DataTable();

            conn.Open();
            ad.Fill(dt);
            return View(dt); // Views/Account/Index.cshtml expects DataTable
        }

        // -------- CREATE ----------
        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(int CustomerId, int BranchId, string AccountType, decimal Balance)
        {
            const string sql = @"
                INSERT INTO ACCOUNTS (CUSTOMER_ID, BRANCH_ID, ACCOUNT_TYPE, BALANCE, STATUS)
                VALUES (:p_customer, :p_branch, :p_type, :p_balance, 'ACTIVE')";

            using var conn = new OracleConnection(_connString);
            using var cmd = new OracleCommand(sql, conn);

            cmd.Parameters.Add(new OracleParameter("p_customer", CustomerId));
            cmd.Parameters.Add(new OracleParameter("p_branch", BranchId));
            cmd.Parameters.Add(new OracleParameter("p_type", AccountType));
            cmd.Parameters.Add(new OracleParameter("p_balance", Balance));

            conn.Open();
            cmd.ExecuteNonQuery();

            TempData["Message"] = "Account created successfully.";
            return RedirectToAction(nameof(Index));
        }

        // -------- EDIT (GET) ----------
        [HttpGet]
        public IActionResult Edit(int id)
        {
            const string sql = "SELECT ACCOUNT_ID, STATUS FROM ACCOUNTS WHERE ACCOUNT_ID = :p_id";

            using var conn = new OracleConnection(_connString);
            using var cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(new OracleParameter("p_id", id));

            conn.Open();
            using var rdr = cmd.ExecuteReader();
            if (!rdr.Read()) return NotFound();

            var vm = new AccountEditViewModel
            {
                AccountId = Convert.ToInt32(rdr["ACCOUNT_ID"]),
                Status = rdr["STATUS"]?.ToString() ?? "ACTIVE"
            };

            return View(vm); // Views/Account/Edit.cshtml
        }

        // -------- EDIT (POST) ----------
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(AccountEditViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            const string sql = "UPDATE ACCOUNTS SET STATUS = :p_status WHERE ACCOUNT_ID = :p_id";

            using var conn = new OracleConnection(_connString);
            using var cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(new OracleParameter("p_status", model.Status));
            cmd.Parameters.Add(new OracleParameter("p_id", model.AccountId));

            conn.Open();
            var rows = cmd.ExecuteNonQuery();
            if (rows == 0) return NotFound();

            TempData["Message"] = $"Account {model.AccountId} updated to {model.Status}.";
            return RedirectToAction(nameof(Index));
        }
    }
}
