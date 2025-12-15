using Microsoft.AspNetCore.Mvc;
using Oracle.ManagedDataAccess.Client;

public class TransactionController : Controller
{
    private readonly OracleDbHelper _dbHelper;
    public TransactionController(IConfiguration config)
    {
        _dbHelper = new OracleDbHelper(config.GetConnectionString("OracleDb")!);
    }

    public IActionResult Index()
    {
        var dt = _dbHelper.ExecuteQuery("SELECT * FROM TRANSACTIONS");
        return View(dt);
    }
}