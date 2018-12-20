using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SportsProDALClassLibrary
{
    public static class TechSupportDB
    {
        static TechSupportDB()
        {
            //Default constructor.
        }

        /// <summary>
        /// Gets the location of the TechSupport database.
        /// </summary>
        /// <returns>An SqlConnection object containing the location of the TechSupport database.</returns>
        public static SqlConnection RetrieveTechSupportConnection()
        {
            SqlConnection connection = new SqlConnection();

            //Sets connection string to specified SQL Server database location.
            connection.ConnectionString = "Data Source = DESKTOP-JC5KKHH\\SQLEXPRESS; " +
                "Initial Catalog = TechSupport; Integrated Security = True;";

            return connection;
        }
    }
}
