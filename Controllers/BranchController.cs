using Microsoft.AspNetCore.Mvc;
using Oracle.ManagedDataAccess.Client;

public class BranchController : Controller
{
    private readonly OracleDbHelper _dbHelper;
    public BranchController(IConfiguration config)
    {
        _dbHelper = new OracleDbHelper(config.GetConnectionString("OracleDb")!);
    }

    public IActionResult Index()
    {
        var dt = _dbHelper.ExecuteQuery("SELECT * FROM BRANCHES");
        return View(dt);
    }
}