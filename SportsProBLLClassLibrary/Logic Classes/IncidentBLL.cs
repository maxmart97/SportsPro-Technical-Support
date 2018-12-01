using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SportsProDALClassLibrary;

namespace SportsProBLLClassLibrary
{
    public class IncidentBLL
    {
        //A "global" instance of the IncidentDAL class to be used wherever needed.
        private static IncidentDAL myIncidentDAL = new IncidentDAL();

        public IncidentBLL()
        {
            //Default Constructor
        }

        /// <summary>
        /// Gets all incidents from the IncidentDAL.
        /// </summary>
        /// <returns>A list of all Incidents.</returns>
        public List<Incident> GetAllIncidents()
        {
            List<Incident> lstAllIncidents = new List<Incident>();
            DataTable dtAllIncidents = new DataTable();

            try
            {
                dtAllIncidents = myIncidentDAL.RetrieveAllIncidents();
            }
            catch //Throws exception to calling method.
            {
                throw;
            }
            
            DataTableToList.Transfer_Incidents(dtAllIncidents, lstAllIncidents);

            return lstAllIncidents;
        }
        
        /// <summary>
        /// Gets all incidents for a specific technician from the IncidentDAL.
        /// </summary>
        /// <param name="techID">An integer value for the technician's ID.</param>
        /// <returns>A List of all Incidents for the specified technician.</returns>
        public List<Incident> GetIncidentsByTechnician(int techID)
        {
            List<Incident> lstIncidentsByTechnician = new List<Incident>();
            DataTable dtIncidentsByTechnician = new DataTable();

            try
            {
                dtIncidentsByTechnician = myIncidentDAL.RetrieveIncidentsByTechnician(techID);
            }
            catch //Throws exception to calling method.
            {
                throw;
            }

            DataTableToList.Transfer_Incidents(dtIncidentsByTechnician, lstIncidentsByTechnician);

            return lstIncidentsByTechnician;
        }

        /// <summary>
        /// Gets all open incidents for a specific technician from the IncidentDAL.
        /// An open incident is where the DateClosed is null or empty.
        /// </summary>
        /// <param name="techID">An integer value for the technician's ID.</param>
        /// <returns>A List of all open Incidents for the specified technician.</returns>
        public List<Incident> GetOpenIncidentsByTechnician(int techID)
        {
            List<Incident> lstOpenIncidentsByTechnician = new List<Incident>();
            DataTable dtOpenIncidentsByTechnician = new DataTable();

            try
            {
                dtOpenIncidentsByTechnician = myIncidentDAL.RetrieveOpenIncidentsByTechnician(techID);
            }
            catch
            {
                throw;
            }
            
            DataTableToList.Transfer_Incidents(dtOpenIncidentsByTechnician, lstOpenIncidentsByTechnician);

            return lstOpenIncidentsByTechnician;
        }

        
    }
}
