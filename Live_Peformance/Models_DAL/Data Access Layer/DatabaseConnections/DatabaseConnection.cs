using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Business_Data_Layers.Data_Access_Layer.DatabaseConnections
{
    public static class DatabaseConnection
    {
        private static string connectionString = @"Data Source=mssql.fhict.local;Persist Security Info=True;User ID=dbi366985;Password=ilhgddds";

        public static int Create(string query)
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
        public static List<object[]> Read(string query)
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
        public static bool Update(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Connection established.");
                    SqlCommand command = new SqlCommand(query, connection);

                    Console.WriteLine("Scaler executed.");
                    return command.ExecuteNonQuery() != 0;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return false;
            }
        }
        public static bool Delete(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    return command.ExecuteNonQuery() != 0;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return false;
            }
        }
        public static List<object[]> StoredProcedure(string procedure, string parametername1, string parametername2, int value1, int value2)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    List<object[]> table = new List<object[]>();
                    connection.Open();
                    SqlCommand command = new SqlCommand(procedure, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter(parametername1, value1));
                    command.Parameters.Add(new SqlParameter(parametername2, value2));
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
    }
}
