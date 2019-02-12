using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SportsProDALClassLibrary
{
    public class CustomerDAL
    {
        private readonly SqlConnection connTsDb = TechSupportDB.RetrieveTechSupportConnection();

        public CustomerDAL()
        {
            //Default Constructor
        }

        /// <summary>
        /// Queries TechSupport database to get CustomerID and Name for all customers from the Customers table.
        /// </summary>
        /// <returns>A DataTable containing the CustomerID and Name of all customers.</returns>
        public DataTable RetrieveAllCustomers()
        {
            DataTable dtCustomers = new DataTable();

            string selectStatement =
                "SELECT CustomerID, [Name], Address, City, State, ZipCode, Phone, Email " +
                "FROM dbo.Customers;";

            //Creates a SqlCommand using the parameterized constructor. CommandType by default is Text.
            SqlCommand selectCommand = new SqlCommand(selectStatement, connTsDb);

            try
            {
                selectCommand.Connection.Open();

                //Executes query and loads result set into DataTable.
                dtCustomers.Load(selectCommand.ExecuteReader());
            }
            catch //Throws exception to calling method.
            {
                throw;
            }
            finally //Closes connection even if exception occurs.
            {
                selectCommand.Connection.Close();
            }

            return dtCustomers;
        }

        public bool AddCustomer(string name, string address, string city, string state, string zipCode, string phone, string email)
        {
            string selectStatement =
                "SELECT COUNT(*) " +
                "FROM Customers " +
                "WHERE [Name] = @Name AND Address = @Address AND City = @City AND State = @State " +
                "AND ZipCode = @ZipCode AND Phone = @Phone AND Email = @Email;";

            string insertStatement =
                "INSERT INTO Customers " +
                "VALUES (@Name, @Address, @City, @State, @ZipCode, @Phone, @Email);";

            SqlCommand cmdAddCustomer = new SqlCommand();

            cmdAddCustomer.Parameters.AddWithValue("@Name", name);
            cmdAddCustomer.Parameters.AddWithValue("@Address", address);
            cmdAddCustomer.Parameters.AddWithValue("@City", city);
            cmdAddCustomer.Parameters.AddWithValue("@State", state);
            cmdAddCustomer.Parameters.AddWithValue("@ZipCode", zipCode);
            cmdAddCustomer.Parameters.AddWithValue("@Phone", phone);
            cmdAddCustomer.Parameters.AddWithValue("@Email", email);

            try
            {
                cmdAddCustomer.Connection = connTsDb;
                cmdAddCustomer.CommandText = selectStatement;
                cmdAddCustomer.Connection.Open();

                int numberOfCustomers = (int)cmdAddCustomer.ExecuteScalar();

                if (numberOfCustomers == 1)
                {
                    return false;
                }
                else
                {
                    cmdAddCustomer.CommandText = insertStatement;

                    int numberOfRowsAffected = cmdAddCustomer.ExecuteNonQuery();

                    if (numberOfRowsAffected == 1)
                        return true;
                    else
                        return false;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                cmdAddCustomer.Connection.Close();
            }
        }

        public bool UpdateCustomer(int customerID, string name, string address, string city,
            string state, string zipCode, string phone, string email)
        {
            string updateStatement =
                "UPDATE Customers " +
                "SET [Name] = @Name, Address = @Address, City = @City, State = @State, " +
                    "ZipCode = @ZipCode, Phone = @Phone, Email = @Email " +
                "WHERE CustomerID = @CustomerID;";

            SqlCommand cmdUpdateCustomer = new SqlCommand(updateStatement, connTsDb);

            cmdUpdateCustomer.Parameters.AddWithValue("@CustomerID", customerID);
            cmdUpdateCustomer.Parameters.AddWithValue("@Name", name);
            cmdUpdateCustomer.Parameters.AddWithValue("@Address", address);
            cmdUpdateCustomer.Parameters.AddWithValue("@City", city);
            cmdUpdateCustomer.Parameters.AddWithValue("@State", state);
            cmdUpdateCustomer.Parameters.AddWithValue("@ZipCode", zipCode);
            cmdUpdateCustomer.Parameters.AddWithValue("@Phone", phone);
            cmdUpdateCustomer.Parameters.AddWithValue("@Email", email);

            try
            {
                cmdUpdateCustomer.Connection.Open();

                int numberOfRowsAffected = cmdUpdateCustomer.ExecuteNonQuery();

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
                cmdUpdateCustomer.Connection.Close();
            }
        }

        public bool DeleteCustomer(int customerID)
        {
            string deleteStatement =
                "DELETE FROM Customers " +
                "WHERE CustomerID = @CustomerID;";

            SqlCommand cmdDeleteCustomer = new SqlCommand(deleteStatement, connTsDb);

            cmdDeleteCustomer.Parameters.AddWithValue("@CustomerID", customerID);

            try
            {
                cmdDeleteCustomer.Connection.Open();

                int numberOfRowsAffected = cmdDeleteCustomer.ExecuteNonQuery();

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
                cmdDeleteCustomer.Connection.Close();
            }
        }
    }
}
