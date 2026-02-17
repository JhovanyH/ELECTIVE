using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELECTIVE
{
    internal class DatabaseConnection
    {
        
        // CHANGE THIS: Update the connection string with your server name
        // Format: Server=YOUR_SERVER_NAME;Database=ProductManagementDB;Integrated Security=true;
        private static string connectionString = @"Server=LAPTOP-8COQ8R8Q\SQLEXPRESS;Database=ProductManagementDB;Integrated Security=true;TrustServerCertificate=true;";

        /// <summary>
        /// Gets a new SQL Server connection
        /// We create a new connection each time we need one
        /// </summary>
        public static SqlConnection GetConnection()
        {
            try
            {
                // Create a new SqlConnection with our connection string
                SqlConnection connection = new SqlConnection(connectionString);

                // Try to open the connection
                connection.Open();

                return connection;
            }
            catch (SqlException ex)
            {
                // If connection fails, show error message
                Console.WriteLine("Database Connection Error: " + ex.Message);
                throw; // Re-throw the exception so the calling code knows about it
            }
        }

        /// <summary>
        /// Use this method to change the connection string if needed
        /// Useful for testing or switching databases
        /// </summary>
        public static void SetConnectionString(string newConnectionString)
        {
            connectionString = newConnectionString;
        }

        /// <summary>
        /// Gets the current connection string
        /// Useful for debugging
        /// </summary>
        public static string GetConnectionString()
        {
            return connectionString;
        }
    }
    
            
}
