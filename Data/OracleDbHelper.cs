using Oracle.ManagedDataAccess.Client;
using System.Data;

public class OracleDbHelper
{
    private readonly string _connectionString;
    public OracleDbHelper(string connectionString) => _connectionString = connectionString;

    public DataTable ExecuteQuery(string query, params OracleParameter[] parameters)
    {
        using var conn = new OracleConnection(_connectionString);
        using var cmd = new OracleCommand(query, conn);
        cmd.Parameters.AddRange(parameters);
        var dt = new DataTable();
        conn.Open();
        using var adapter = new OracleDataAdapter(cmd);
        adapter.Fill(dt);
        return dt;
    }

    public int ExecuteNonQuery(string query, params OracleParameter[] parameters)
    {
        using var conn = new OracleConnection(_connectionString);
        using var cmd = new OracleCommand(query, conn);
        cmd.Parameters.AddRange(parameters);
        conn.Open();
        return cmd.ExecuteNonQuery();
    }

    public DataTable ExecuteStoredProcedure(string procedureName, params OracleParameter[] parameters)
    {
        using var conn = new OracleConnection(_connectionString);
        using var cmd = new OracleCommand(procedureName, conn) { CommandType = CommandType.StoredProcedure };
        cmd.Parameters.AddRange(parameters);
        var dt = new DataTable();
        conn.Open();
        using var adapter = new OracleDataAdapter(cmd);
        adapter.Fill(dt);
        return dt;
    }
}