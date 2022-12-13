using IT481M2_Part1_MCarter.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT481M2_Part1_MCarter.BAL
{
    public class BusinessAccessLayer
    {
        // this method selects the clients from the database and returns them as a string
        public string SelectClients()
        {
            // create a new instance of the DataAccessLayer class
            DataAccessLayer DL = new DataAccessLayer("DESKTOP-IU3R9KA\\SQLEXPRESS", "Northwind", "True");

            // call the SelectClients() method on the DataAccessLayer instance
            // and return the results as a string
            return DL.SelectClients();
        }

        // this method counts the number of clients in the database and returns the result as a string
        public string CountClients()
        {
            // create a new instance of the DataAccessLayer class
            DataAccessLayer DL = new DataAccessLayer("DESKTOP-IU3R9KA\\SQLEXPRESS", "Northwind", "True");

            // call the CountClients() method on the DataAccessLayer instance
            // and return the results as a string
            return DL.CountClients();
        }
    }
}