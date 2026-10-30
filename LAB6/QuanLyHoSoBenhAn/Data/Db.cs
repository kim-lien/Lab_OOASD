using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace QuanLyBenhAn;
public static class Db
{
    // Đổi Data Source theo SQL Server của máy: .\\SQLEXPRESS hoặc (localdb)\\MSSQLLocalDB
    public static string ConnectionString => ConfigurationManager.ConnectionStrings["QuanLyBenhAn"]?.ConnectionString
        ?? @"Data Source=ADMIN;Initial Catalog=QuanLyBenhAn;Integrated Security=True;TrustServerCertificate=True";
    public static DataTable Query(string sql, params SqlParameter[] args)
    {
        using var con = new SqlConnection(ConnectionString);
        using var cmd = new SqlCommand(sql, con);
        cmd.Parameters.AddRange(args);
        using var adapter = new SqlDataAdapter(cmd);
        var dt = new DataTable();
        adapter.Fill(dt);
        return dt;
    }
    public static int Execute(string sql, params SqlParameter[] args)
    {
        using var con = new SqlConnection(ConnectionString);
        using var cmd = new SqlCommand(sql, con);
        cmd.Parameters.AddRange(args);
        con.Open();
        return cmd.ExecuteNonQuery();
    }
    public static object Scalar(string sql, params SqlParameter[] args)
    {
        using var con = new SqlConnection(ConnectionString);
        using var cmd = new SqlCommand(sql, con);
        cmd.Parameters.AddRange(args);
        con.Open();
        return cmd.ExecuteScalar() ?? throw new Exception("Không có kết quả từ SQL Server.");
    }
    public static SqlParameter P(string name, object? value) => new(name, value ?? DBNull.Value);
}
