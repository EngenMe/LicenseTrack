using System.Data.SqlClient;
using System.Data;
using DataAccessLayer.Interfaces;

namespace DataAccessLayer.Classes
{
    public class DataBaseService : IDatabaseService
    {
        private readonly string _connectionString;
        private readonly object _lock = new object();

        public DataBaseService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable ExecuteQuery(string query)
        {
            lock (_lock)
            {
                DataTable dataTable = new DataTable();
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                }

                return dataTable;
            }
        }
    }
}
