using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SportsProDALClassLibrary
{
    public class IncidentDAL
    {
        //A "global" SqlConnection object that can be use as needed for methods below.
        private static readonly SqlConnection connTsDb = TechSupportDB.RetrieveTechSupportConnection();

        public IncidentDAL()
        {
            //Default Constructor
        }

        /// <summary>
        /// Queries TechSupport database to retrieve records of all incidents from the Incidents table.
        /// </summary>
        /// <returns>A DataTable of all incidents with each record containing all attributes.</returns>
        public DataTable RetrieveAllIncidents()
        {
            DataTable dtAllIncidents = new DataTable();

            string selectStatement =
                "SELECT IncidentID, CustomerID, ProductCode, TechID, " +
                    "DateOpened, DateClosed, Title, Description " +
                "FROM dbo.Incidents;";

            //Creates a SqlCommand using the parameterized constructor. CommandType by default is Text.
            SqlCommand selectAllIncidents = new SqlCommand(selectStatement, connTsDb);
            
            try
            {
                selectAllIncidents.Connection.Open();

                //Executes query and loads result set into DataTable.
                dtAllIncidents.Load(selectAllIncidents.ExecuteReader());
            }
            catch //Throws exception to calling method.
            {
                throw;
            }
            finally //Closes connection even if exception occurs.
            {
                selectAllIncidents.Connection.Close();
            }

            return dtAllIncidents;
        }

        /// <summary>
        /// Queries TechSupport database to retrieve records of all incidents for a specified 
        /// technician from the Incidents table.
        /// </summary>
        /// <param name="techID">An integer for a specific technician's ID.</param>
        /// <returns>A DataTable of all incidents for the specified technician.</returns>
        public DataTable RetrieveIncidentsByTechnician(int techID)
        {
            DataTable dtIncidentsByTechnician = new DataTable();

            string selectStatement = 
                "SELECT IncidentID, CustomerID, ProductCode, TechID, " +
                    "DateOpened, DateClosed, Title, Description " +
                "FROM dbo.Incidents " +
                "WHERE TechID = @techID";

            //Creates a SqlCommand using the parameterized constructor. CommandType by default is Text.
            SqlCommand selectIncidentsByTechID = new SqlCommand(selectStatement, connTsDb);

            //Sets up and adds parameter to command. Default direction is 'Input'.
            selectIncidentsByTechID.Parameters.AddWithValue("@techID", techID);

            try
            {
                selectIncidentsByTechID.Connection.Open();

                //Executes query and loads result set into DataTable.
                dtIncidentsByTechnician.Load(selectIncidentsByTechID.ExecuteReader());
            }
            catch //Throws exception to calling method.
            {
                throw;
            }
            finally //Closes connection even if exception occurs.
            {
                selectIncidentsByTechID.Connection.Close();
            }

            return dtIncidentsByTechnician;
        }

        /// <summary>
        /// Queries TechSupport database to retrieve records of all open incidents for a specified 
        /// technician from the Incidents table.
        /// </summary>
        /// <param name="techID">An integer for a specific technician's ID.</param>
        /// <returns>A DataTable of all open incidents for the specified technician.</returns>
        public DataTable RetrieveOpenIncidentsByTechnician(int techID)
        {
            DataTable dtOpenIncidentsByTechnician = new DataTable();

            string selectStatement =
                "SELECT IncidentID, CustomerID, ProductCode, TechID, " +
                    "DateOpened, DateClosed, Title, Description " +
                "FROM dbo.Incidents " +
                "WHERE TechID = @techID AND DateClosed IS NULL;";

            //Creates a SqlCommand using the parameterized constructor. CommandType by default is Text.
            SqlCommand selectOpenIncidentsByTechID = new SqlCommand(selectStatement, connTsDb);

            //Sets up and adds parameter to command. Default direction is 'Input'.
            selectOpenIncidentsByTechID.Parameters.AddWithValue("@techID", techID);

            try
            {
                selectOpenIncidentsByTechID.Connection.Open();

                //Executes query and loads result set into DataTable.
                dtOpenIncidentsByTechnician.Load(selectOpenIncidentsByTechID.ExecuteReader());
            }
            catch //Throws exception to calling method.
            {
                throw;
            }
            finally //Closes connection even if exception occurs.
            {
                selectOpenIncidentsByTechID.Connection.Close();
            }

            return dtOpenIncidentsByTechnician;
        }

        public bool AddIncident(int customerID, string productCode, int? techID, DateTime dateOpened,
            DateTime? dateClosed, string title, string description)
        {
            string selectStatement =
                "SELECT COUNT(*) " +
                "FROM Incidents " +
                "WHERE CustomerID = @CustomerID AND ProductCode = @ProductCode " +
                "AND DateOpened = @DateOpened AND Title = @Title AND Description = @Description;";

            string insertStatement =
                "INSERT INTO Incidents " +
                "VALUES (@CustomerID, @ProductCode, @TechID, @DateOpened, @DateClosed, @Title, @Description);";

            SqlCommand cmdAddIncident = new SqlCommand();

            cmdAddIncident.Connection = connTsDb;
            cmdAddIncident.CommandText = selectStatement;

            cmdAddIncident.Parameters.AddWithValue("@CustomerID", customerID);
            cmdAddIncident.Parameters.AddWithValue("@ProductCode", productCode);

            if (techID == null)
                cmdAddIncident.Parameters.AddWithValue("@TechID", DBNull.Value);
            else
                cmdAddIncident.Parameters.AddWithValue("@TechID", techID);

            cmdAddIncident.Parameters.AddWithValue("@DateOpened", dateOpened);

            if (dateClosed == null)
                cmdAddIncident.Parameters.AddWithValue("@DateClosed", DBNull.Value);
            else
                cmdAddIncident.Parameters.AddWithValue("@DateClosed", dateClosed);

            cmdAddIncident.Parameters.AddWithValue("@Title", title);
            cmdAddIncident.Parameters.AddWithValue("@Description", description);

            try
            {
                cmdAddIncident.Connection.Open();

                int numberOfIncidents = (int)cmdAddIncident.ExecuteScalar();

                if (numberOfIncidents == 0)
                {
                    cmdAddIncident.CommandText = insertStatement;

                    int numberOfRowsAffected = cmdAddIncident.ExecuteNonQuery();

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
                cmdAddIncident.Connection.Close();
            }
        }

        public bool UpdateIncident(int incidentID, int customerID, string productCode, int? techID, DateTime dateOpened,
            DateTime? dateClosed, string title, string description)
        {
            string updateStatement =
                "UPDATE Incidents " +
                "SET CustomerID = @CustomerID, ProductCode = @ProductCode, TechID = @TechID, " +
                "DateOpened = @DateOpened, DateClosed = @DateClosed, Title = @Title, Description = @Description " +
                "WHERE IncidentID = @IncidentID;";

            SqlCommand cmdUpdateIncident = new SqlCommand(updateStatement, connTsDb);

            cmdUpdateIncident.Parameters.AddWithValue("@IncidentID", incidentID);
            cmdUpdateIncident.Parameters.AddWithValue("@CustomerID", customerID);
            cmdUpdateIncident.Parameters.AddWithValue("@ProductCode", productCode);

            if (techID == null)
                cmdUpdateIncident.Parameters.AddWithValue("@TechID", DBNull.Value);
            else
                cmdUpdateIncident.Parameters.AddWithValue("@TechID", techID);

            cmdUpdateIncident.Parameters.AddWithValue("@DateOpened", dateOpened);

            if (dateClosed == null)
                cmdUpdateIncident.Parameters.AddWithValue("@DateClosed", DBNull.Value);
            else
                cmdUpdateIncident.Parameters.AddWithValue("@DateClosed", dateClosed);

            cmdUpdateIncident.Parameters.AddWithValue("@Title", title);
            cmdUpdateIncident.Parameters.AddWithValue("@Description", description);

            try
            {
                cmdUpdateIncident.Connection.Open();

                int numberOfRowsAffected = cmdUpdateIncident.ExecuteNonQuery();

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
                cmdUpdateIncident.Connection.Close();
            }
        }

        public bool DeleteIncident(int incidentID)
        {
            string deleteStatement =
                "DELETE FROM Incidents " +
                "WHERE IncidentID = @IncidentID;";

            SqlCommand cmdDeleteIncident = new SqlCommand(deleteStatement, connTsDb);

            cmdDeleteIncident.Parameters.AddWithValue("@IncidentID", incidentID);

            try
            {
                cmdDeleteIncident.Connection.Open();

                int numberOfRowsAffected = cmdDeleteIncident.ExecuteNonQuery();

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
                cmdDeleteIncident.Connection.Close();
            }
        }
    }
}
