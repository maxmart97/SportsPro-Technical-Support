using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SportsProDALClassLibrary
{
    public class RegistrationDAL
    {
        //A "global" SqlConnection object that can be used as needed for methods below.
        private static readonly SqlConnection connTsDb = TechSupportDB.RetrieveTechSupportConnection();

        public RegistrationDAL()
        {
            //Default Constructor
        }

        /// <summary>
        /// Queries the TechSupport database to retrieve all customer registrations for a specific product
        /// using a stored procedure called "spCustomerProductRegistrations."
        /// </summary>
        /// <param name="prodCode">A string containing the product's code.</param>
        /// <returns>A DataTable containing all customer registrations for the given product.</returns>
        public DataTable RetrieveCustRegForSpecifiedProduct(string prodCode)
        {
            DataTable dtCustRegForSpecifiedProd = new DataTable();

            /* Sets up SqlCommand using the parameterized constructor.
             * CommandText is set to the name of the stored procedure. */
            SqlCommand cmdCustRegForSpecifiedProd =
                new SqlCommand("spCustomerProductRegistrations", connTsDb);

            //Changes SqlCommand's CommandType to StoredProcedure and sets up the needed parameter.
            cmdCustRegForSpecifiedProd.CommandType = CommandType.StoredProcedure;
            cmdCustRegForSpecifiedProd.Parameters.AddWithValue("@ProductCode", prodCode);

            try
            {
                cmdCustRegForSpecifiedProd.Connection.Open();

                //Executes query and loads result set into the DataTable.
                dtCustRegForSpecifiedProd.Load(cmdCustRegForSpecifiedProd.ExecuteReader());
            }
            catch //Throws exception to the calling method.
            {
                throw;
            }
            finally //Closes connection even if exception is thrown.
            {
                cmdCustRegForSpecifiedProd.Connection.Close();
            }

            return dtCustRegForSpecifiedProd;
        }

        /// <summary>
        /// Adds registration information to Registrations table in TechSupport database using a StoredProcedure.
        /// </summary>
        /// <param name="customerID">An integer containing the customer's ID.</param>
        /// <param name="productCode">A string containing the product's code.</param>
        /// <param name="regDate">A DateTime object containing the date and time the registration occurred.</param>
        /// <returns>True if registration is successful and false if registration failed.</returns>
        private bool AddRegistration(int customerID, string productCode, DateTime regDate)
        {
            //Creates a SqlCommand using the parameterized constructor. CommandText is name of StoredProcedure.
            SqlCommand addCommand = new SqlCommand("spAddRegistration", connTsDb);

            //Sets CommandType to StoredProcedure and sets up parameters.
            addCommand.CommandType = CommandType.StoredProcedure;
            addCommand.Parameters.AddWithValue("@customerID", customerID);
            addCommand.Parameters.AddWithValue("@productCode", productCode);
            addCommand.Parameters.AddWithValue("@registrationDate", regDate);

            try
            {
                addCommand.Connection.Open();

                //Executes insert statement (StoredProcedure) and returns number of rows affected.
                int numberOfRowsAffected = addCommand.ExecuteNonQuery();

                if (numberOfRowsAffected == 1)
                    return true;
                else
                    return false;
            }
            catch //Throws exception to calling method.
            {
                throw;
            }
            finally //Closes connection even if exception occurs.
            {
                addCommand.Connection.Close();
            }
        }

        /// <summary>
        /// Queries Registrations table in TechSupport database to see if registration information already exists.
        /// </summary>
        /// <param name="customerID">An integer containing the customer's ID.</param>
        /// <param name="productCode">A string containing the product's code.</param>
        /// <returns>True if registration info already exists and false if it doesn't.</returns>
        private bool CheckRegistration(int customerID, string productCode)
        {
            string selectStatement =
                "SELECT COUNT(*) " +
                "FROM dbo.Registrations " +
                "WHERE CustomerID = @customerID AND ProductCode = @productCode;";

            //Creates a SqlCommand using the parameterized constructor. CommandType by default is Text.
            SqlCommand checkCommand = new SqlCommand(selectStatement, connTsDb);

            //ets up and adds parameter to command. Default direction is 'Input'.
            checkCommand.Parameters.AddWithValue("@customerID", customerID);
            checkCommand.Parameters.AddWithValue("@productCode", productCode);

            try
            {
                checkCommand.Connection.Open();

                //Executes query (aggregate function) and returns number of registrations found.
                int numberOfRegistrations = (int)checkCommand.ExecuteScalar();

                if (numberOfRegistrations == 1)
                    return true;
                else
                    return false;
            }
            catch //Throws exception to calling method.
            {
                throw;
            }
            finally //Closes connection even if exception occurs.
            {
                checkCommand.Connection.Close();
            }
        }

        /// <summary>
        /// Registers the product selected under the selected customer.
        /// </summary>
        /// <param name="prodCode">A string containing the product's code.</param>
        /// <param name="custID">An integer containing the customer's ID.</param>
        /// <param name="regDate">A DateTime object containing the date and time the registration occurred.</param>
        /// <returns></returns>
        public bool RegisterProduct(string prodCode, int custID, DateTime regDate)
        {
            try
            {
                //Checks if registration information already exists.
                if (CheckRegistration(custID, prodCode) is true)
                    return false;
                else //...if registration information doesn't exist.
                {
                    //Adds registration and checks if registration was successful.
                    if (AddRegistration(custID, prodCode, regDate) is true)
                        return true;
                    else
                        return false;
                }
            }
            catch //Throws exception to calling method.
            {
                throw;
            }
        }

        public bool UpdateRegistration(int oldCustomerID, string oldProductCode, int customerID, string productCode, DateTime registrationDate)
        {
            string updateStatement =
                "UPDATE Registrations " +
                "SET CustomerID = @CustomerID, ProductCode = @ProductCode, RegistrationDate = @RegistrationDate " +
                "WHERE CustomerID = @OldCustomerID AND ProductCode = @OldProductCode;";

            SqlCommand cmdUpdateRegistration = new SqlCommand(updateStatement, connTsDb);

            cmdUpdateRegistration.Parameters.AddWithValue("@OldCustomerID", oldCustomerID);
            cmdUpdateRegistration.Parameters.AddWithValue("@OldProductCode", oldProductCode);
            cmdUpdateRegistration.Parameters.AddWithValue("@CustomerID", customerID);
            cmdUpdateRegistration.Parameters.AddWithValue("@ProductCode", productCode);
            cmdUpdateRegistration.Parameters.AddWithValue("@RegistrationDate", registrationDate);

            try
            {
                cmdUpdateRegistration.Connection.Open();

                int numberOfRowsAffected = cmdUpdateRegistration.ExecuteNonQuery();

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
                cmdUpdateRegistration.Connection.Close();
            }
        }
    }
}
