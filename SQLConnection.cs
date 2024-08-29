using System;
using System.Data.SqlClient;

namespace ABC_Car_Traders
{
    internal class SQLConnection : IDisposable
    {
        private readonly SqlConnection _connection;

        public SQLConnection()
        {
            _connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\kavee\OneDrive\Desktop\CodeMaster\C# - Esoft\DB.mdf"";Integrated Security=True;Connect Timeout=30");
        }

        public SqlConnection GetConnection()
        {
            return _connection;
        }

        public void OpenConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        public int ExecuteScalarQuery(string query)
        {
            int count = 0;
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand(query, _connection))
                {
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing scalar query: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }

        public void Dispose()
        {
            CloseConnection();
            _connection.Dispose();
        }
    }
}