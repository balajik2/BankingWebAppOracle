
using System;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using BankingWebApp.Models;

namespace BankingWebApp.Controllers
{
    public class CardController : Controller
    {
        private readonly string _connString;
        public CardController(IConfiguration config)
        {
            _connString = config.GetConnectionString("OracleDb")
                ?? throw new InvalidOperationException("Missing connection string 'OracleDb'.");
        }

        // INDEX
        public IActionResult Index()
        {
            using var conn = new OracleConnection(_connString);
            using var cmd = new OracleCommand("SELECT * FROM CARDS ORDER BY CARD_ID", conn);
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
        public IActionResult Create(int CustomerId, string CardType, string CardNumber, DateTime? ExpiryDate, string Status = "ACTIVE")
        {
            const string sql = @"INSERT INTO CARDS (CUSTOMER_ID, CARD_TYPE, CARD_NUMBER, EXPIRY_DATE, STATUS)
                                 VALUES (:p_cust, :p_type, :p_num, :p_expiry, :p_status)";
            using var conn = new OracleConnection(_connString);
            using var cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(new OracleParameter("p_cust", CustomerId));
            cmd.Parameters.Add(new OracleParameter("p_type", CardType));
            cmd.Parameters.Add(new OracleParameter("p_num", CardNumber));
            cmd.Parameters.Add(new OracleParameter("p_expiry", (object?)ExpiryDate ?? DBNull.Value));
            cmd.Parameters.Add(new OracleParameter("p_status", Status));
            conn.Open();
            cmd.ExecuteNonQuery();
            TempData["Message"] = "Card created successfully.";
            return RedirectToAction(nameof(Index));
        }

        // EDIT (Status only)
        [HttpGet]
        public IActionResult Edit(int id)
        {
            const string sql = "SELECT CARD_ID, STATUS FROM CARDS WHERE CARD_ID = :p_id";
            using var conn = new OracleConnection(_connString);
            using var cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(new OracleParameter("p_id", id));
            conn.Open();
            using var rdr = cmd.ExecuteReader();
            if (!rdr.Read()) return NotFound();
            var vm = new CardEditViewModel
            {
                CardId = Convert.ToInt32(rdr["CARD_ID"]),
                Status = rdr["STATUS"]?.ToString() ?? "ACTIVE"
            };
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CardEditViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            const string sql = "UPDATE CARDS SET STATUS = :p_status WHERE CARD_ID = :p_id";
            using var conn = new OracleConnection(_connString);
            using var cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(new OracleParameter("p_status", model.Status));
            cmd.Parameters.Add(new OracleParameter("p_id", model.CardId));
            conn.Open();
            var rows = cmd.ExecuteNonQuery();
            if (rows == 0) return NotFound();
            TempData["Message"] = $"Card {model.CardId} updated.";
            return RedirectToAction(nameof(Index));
        }
    }
}
