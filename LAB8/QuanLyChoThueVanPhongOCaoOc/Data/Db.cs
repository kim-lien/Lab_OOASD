
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyChoThueVanPhong.Data
{
    public static class Db
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager
                    .ConnectionStrings["QuanLyChoThueVanPhongDB"]
                    .ConnectionString;
            }
        }

        public static SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }

        public static bool TestConnection()
        {
            using (SqlConnection connection = OpenConnection())
            {
                return connection.State == ConnectionState.Open;
            }
        }

        public static DataTable Query(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = OpenConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public static int Execute(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = OpenConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                return command.ExecuteNonQuery();
            }
        }

        public static object Scalar(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = OpenConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                return command.ExecuteScalar();
            }
        }

        public static SqlParameter P(string name, object value)
        {
            if (value == null)
                return new SqlParameter(name, DBNull.Value);

            if (value is string text && string.IsNullOrWhiteSpace(text))
                return new SqlParameter(name, DBNull.Value);

            return new SqlParameter(name, value);
        }
    }
}
