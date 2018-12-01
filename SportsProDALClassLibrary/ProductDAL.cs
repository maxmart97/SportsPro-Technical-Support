using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SportsProDALClassLibrary
{
    public class ProductDAL
    {
        public ProductDAL()
        {
            //Default Constructor
        }

        /// <summary>
        /// Queries TechSupport database to get ProductCode and Name of all products from the Products table.
        /// </summary>
        /// <returns>A DataTable containing the ProductCode and Name of all products.</returns>
        public DataTable RetrieveAllProducts()
        {
            DataTable dtProductNameAndCode = new DataTable();

            string selectStatement =
                "SELECT ProductCode, Name " +
                "FROM dbo.Products;";

            //Creates a SqlCommand using the parameterized constructor. CommandType by default is Text.
            SqlCommand selectCommand = new SqlCommand(selectStatement, TechSupportDB.RetrieveTechSupportConnection());

            try
            {
                selectCommand.Connection.Open();

                //Executes query and loads result set into DataTable.
                dtProductNameAndCode.Load(selectCommand.ExecuteReader());
            }
            catch //Throws exception to calling method.
            {
                throw;
            }
            finally //Closes connection even if exception occurs.
            {
                selectCommand.Connection.Close();
            }

            return dtProductNameAndCode;
        }
    }
}
