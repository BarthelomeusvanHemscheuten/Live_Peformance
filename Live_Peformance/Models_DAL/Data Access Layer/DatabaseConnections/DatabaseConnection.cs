using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business_Data_Layers.Data_Access_Layer.DatabaseConnections
{
    public class DatabaseConnection
    {
        private string connectionString = @"";

        public int Create(string query)
        {
            string getIDQuery = "SET DATEFORMAT dmy; @query; SELECT CONVERT(INT, SCOPE_IDENTITY()) AS [SCOPE_IDENTITY];";
            query = getIDQuery.Replace("@query", query);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return -1;
            }
        }
        public List<object[]> Read(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    List<object[]> table = new List<object[]>();

                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        object[] row = new object[reader.FieldCount];
                        reader.GetValues(row);
                        table.Add(row);
                    }
                    return table;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }
        public bool Update(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Connection established.");
                    SqlCommand command = new SqlCommand(query, connection);

                    Console.WriteLine("Scaler executed.");
                    if (command.ExecuteNonQuery() != 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return false;
            }
        }
        public bool Delete(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    return (bool)(command.ExecuteScalar());
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return false;
            }
        }
    }
}
