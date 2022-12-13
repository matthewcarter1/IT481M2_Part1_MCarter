using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT481M2_Part1_MCarter.DAL
{
    internal class DataAccessLayer
    {
        // Constructor takes care of this now
        public string connString; // = @"Server=DESKTOP-IU3R9KA\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;";                       
        SqlDataReader reader; // Initialize reader

        // Constructor that takes a connection string(s)
        public DataAccessLayer(string server, string dataBase, string trustConn) // Define a constructor that takes the necessary connection string parameters
        {
            connString = @"Server=" + server + ";" + "Database=" + dataBase + ";" + "Trusted_Connection=" + trustConn + ";"; // Build the connection string using the parameters
        }

        // Methods
        public string SelectClients() // Define a method to retrieve customer names from the database
        {
            string readOut = null; // Declare a string variable to store the results

            SqlConnection conn = new SqlConnection(connString); // Create a new SQL connection using the connection string
            conn.Open(); // Open the connection

            SqlCommand cmd = new SqlCommand(); // Create a new SQL command object
            cmd.Connection = conn; // Set the connection property of the SQL command object to the SQL connection
            cmd.CommandText = "SELECT ContactName FROM Northwind.dbo.Customers ORDER BY ContactName ASC"; // Set the command text to the SELECT query
            reader = cmd.ExecuteReader(); // Execute the query and load the results into the SqlDataReader object
            while (reader.Read()) // Loop through the results
            {
                readOut = readOut + reader.GetValue(0) + "\n"; // Concatenate the name to the readOut string
            }
            reader.Close(); // Close the SqlDataReader object
            return readOut; // Return the results
        }

        public string CountClients() // Define a method to count the number of customers in the database
        {
            string readOut = null; // Declare a string variable to store the results

            SqlConnection conn = new SqlConnection(connString); // Create a new SQL connection using the connection string
            conn.Open(); // Open the connection

            SqlCommand cmd = new SqlCommand(); // Create a new SQL command object
            cmd.Connection = conn; // Set the connection property of the SQL command object to the SQL connection
            cmd.CommandText = "SELECT COUNT(*) FROM Customers"; // Set the command text to the COUNT query
            reader = cmd.ExecuteReader(); // Execute the query and load the results into the SqlDataReader object
            while (reader.Read()) // Loop through the results
            {
                readOut = reader.GetValue(0) + "\n"; // Concatenate the count to the readOut string
            }
            reader.Close(); // Close the SqlDataReader object
            return readOut; // Return the results
        }

    }
}