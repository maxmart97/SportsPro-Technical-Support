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
        private static readonly SqlConnection connTsDb = TechSupportDB.RetrieveTechSupportConnection();

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
            SqlCommand selectCommand = new SqlCommand(selectStatement, connTsDb);

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

        public bool AddProduct(string productCode, string productName, decimal version, DateTime releaseDate)
        {
            string selectStatement =
                "SELECT COUNT(*) " +
                "FROM Products " +
                "WHERE ProductCode = @ProductCode AND Name = @ProductName " +
                "AND Version = @Version AND ReleaseDate = @ReleaseDate;";

            string insertStatement =
                "INSERT INTO Products " +
                "VALUES (@ProductCode, @ProductName, @Version, @ReleaseDate);";

            SqlCommand cmdAddProduct = new SqlCommand();

            cmdAddProduct.Connection = connTsDb;
            cmdAddProduct.CommandText = selectStatement;

            cmdAddProduct.Parameters.AddWithValue("@ProductCode", productCode);
            cmdAddProduct.Parameters.AddWithValue("@ProductName", productName);
            cmdAddProduct.Parameters.AddWithValue("@Version", version);
            cmdAddProduct.Parameters.AddWithValue("@ReleaseDate", releaseDate);

            try
            {
                cmdAddProduct.Connection.Open();

                if ((int)cmdAddProduct.ExecuteScalar() == 0)
                {
                    cmdAddProduct.CommandText = insertStatement;

                    int numberOfRowsAffected = cmdAddProduct.ExecuteNonQuery();

                    if (numberOfRowsAffected == 1)
                        return true;
                    else
                        return false;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                cmdAddProduct.Connection.Close();
            }
        }

        public bool UpdateProduct(string oldProductCode, string productCode, string name, decimal version, DateTime releaseDate)
        {
            string updateStatement =
                "UPDATE Products " +
                "SET ProductCode = @ProductCode, Name = @Name, Version = @Version, " +
                "ReleaseDate = @ReleaseDate " +
                "WHERE ProductCode = @OldProductCode;";

            SqlCommand cmdUpdateProduct = new SqlCommand(updateStatement, connTsDb);

            cmdUpdateProduct.Parameters.AddWithValue("@ProductCode", productCode);
            cmdUpdateProduct.Parameters.AddWithValue("@Name", name);
            cmdUpdateProduct.Parameters.AddWithValue("@Version", version);
            cmdUpdateProduct.Parameters.AddWithValue("@ReleaseDate", releaseDate);
            cmdUpdateProduct.Parameters.AddWithValue("@OldProductCode", oldProductCode);

            try
            {
                cmdUpdateProduct.Connection.Open();

                int numberOfRowsAffected = cmdUpdateProduct.ExecuteNonQuery();

                if (numberOfRowsAffected == 1)
                    return true;
                else
                    return false;
            }
            catch
            {
                throw;
            }
            finally
            {
                cmdUpdateProduct.Connection.Close();
            }
        }

        public bool DeleteProduct(string productCode)
        {
            string deleteStatement =
                "DELETE FROM Products " +
                "WHERE ProductCode = @ProductCode;";

            SqlCommand cmdDeleteProduct = new SqlCommand(deleteStatement, connTsDb);

            cmdDeleteProduct.Parameters.AddWithValue("@ProductCode", productCode);

            try
            {
                cmdDeleteProduct.Connection.Open();

                int numberOfRowsAffected = cmdDeleteProduct.ExecuteNonQuery();

                if (numberOfRowsAffected == 1)
                    return true;
                else
                    return false;
            }
            catch
            {
                throw;
            }
            finally
            {
                cmdDeleteProduct.Connection.Close();
            }
        }
    }
}
