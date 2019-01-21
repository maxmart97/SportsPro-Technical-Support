using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SportsProDALClassLibrary
{
    public class TechnicianDAL
    {
        //A "global" SqlConnection object that can be use as needed for methods below.
        private static readonly SqlConnection connTsDb = TechSupportDB.RetrieveTechSupportConnection();

        public TechnicianDAL()
        {
            //Default Constructor
        }

        /// <summary>
        /// Queries TechSupport database to retrieve the TechID and Name of 
        /// all technicians in the Technicians tables.
        /// </summary>
        /// <returns>A DataTable of the TechID and Name of all technicians.</returns>
        public DataTable RetrieveAllTechnicians()
        {
            DataTable dtTechnicians = new DataTable();

            string selectStatement =
                "SELECT TechID, Name, Email, Phone " +
                "FROM dbo.Technicians;";

            //Creates a SqlCommand using the parameterized constructor. CommandType by default is Text.
            SqlCommand selectTechnicianNames = new SqlCommand(selectStatement, connTsDb);

            try
            {
                selectTechnicianNames.Connection.Open();

                //Executes query and loads result set into DataTable.
                dtTechnicians.Load(selectTechnicianNames.ExecuteReader());
            }
            catch //Throws exception to calling method.
            {
                throw;
            }
            finally //Closes connection even if exception occurs.
            {
                selectTechnicianNames.Connection.Close();
            }

            return dtTechnicians;
        }

        /// <summary>
        /// Queries TechSupport database to retrieve the Email 
        /// and Phone information of the specified technician.
        /// </summary>
        /// <param name="techID">An integer containing the technician's ID.</param>
        /// <returns>A DataTable containing the Email and Phone information for the specified technician.</returns>
        public DataTable RetrieveTechnicianDetails(int techID)
        {
            DataTable dtTechnicianDetails = new DataTable();

            string selectStatement =
                "SELECT Email, Phone " +
                "FROM dbo.Technicians " +
                "WHERE TechID = @techID;";

            //Creates a SqlCommand using the parameterized constructor. CommandType by default is Text.
            SqlCommand selectTechnicianDetails = new SqlCommand(selectStatement, connTsDb);

            //Sets up and adds parameter to SqlCommand.
            selectTechnicianDetails.Parameters.AddWithValue("@techID", techID);

            try
            {
                selectTechnicianDetails.Connection.Open();

                //Executes query and loads result set into DataTable.
                dtTechnicianDetails.Load(selectTechnicianDetails.ExecuteReader());
            }
            catch //Throws exception to calling method.
            {
                throw;
            }
            finally //Closes connection even if exception occurs.
            {
                selectTechnicianDetails.Connection.Close();
            }

            return dtTechnicianDetails;
        }

        public bool AddTechnician(string name, string email, string phone)
        {
            string selectStatement =
                "SELECT COUNT(*) " +
                "FROM Technicians " +
                "WHERE Name = @Name AND Email = @Email AND Phone = @Phone;";

            string insertStatement =
                "INSERT INTO Technicians " +
                "VALUES (@Name, @Email, @Phone);";

            SqlCommand cmdAddTechnician = new SqlCommand();

            cmdAddTechnician.Connection = connTsDb;
            cmdAddTechnician.CommandText = selectStatement;

            cmdAddTechnician.Parameters.AddWithValue("@Name", name);
            cmdAddTechnician.Parameters.AddWithValue("@Email", email);
            cmdAddTechnician.Parameters.AddWithValue("@Phone", phone);

            try
            {
                cmdAddTechnician.Connection.Open();

                if ((int)cmdAddTechnician.ExecuteScalar() == 0)
                {
                    cmdAddTechnician.CommandText = insertStatement;

                    int numberOfRowsAffected = cmdAddTechnician.ExecuteNonQuery();

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
                cmdAddTechnician.Connection.Close();
            }
        }
    }
}
