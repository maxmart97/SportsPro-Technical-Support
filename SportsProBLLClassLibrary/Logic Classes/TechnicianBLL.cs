using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SportsProDALClassLibrary;

namespace SportsProBLLClassLibrary
{
    public class TechnicianBLL
    {
        //A "global" instance of the TechnicianDAL class to be used wherever needed.
        private readonly static TechnicianDAL myTechnicianDAL = new TechnicianDAL();

        public TechnicianBLL()
        {
            //Default Constructor
        }

        /// <summary>
        /// Gets all technicians from the TechnicianDAL.
        /// </summary>
        /// <returns>A DataTable containing each technician.</returns>
        public DataTable GetAllTechnicians_AsDataTable()
        {
            DataTable dtTechnicians = new DataTable();

            try
            {
                dtTechnicians  = myTechnicianDAL.RetrieveAllTechnicians();
            }
            catch //Throws exception to calling method.
            {
                throw;
            }

            return dtTechnicians;
        }

        /// <summary>
        /// Gets all technicians from the TechnicianDAL.
        /// </summary>
        /// <returns>A List containing each technician.</returns>
        public List<Technician> GetAllTechnicians_AsList()
        {
            DataTable dtTechnicians = new DataTable();
            List<Technician> lstTechnicians = new List<Technician>();

            try
            {
                dtTechnicians = myTechnicianDAL.RetrieveAllTechnicians();
            }
            catch //Throws exception to calling method.
            {
                throw;
            }

            DataTableToList.Transfer_Technicians(dtTechnicians, lstTechnicians);

            return lstTechnicians;
        }

        /// <summary>
        /// Gets the Email and Phone information for the specified technician 
        /// from the TechnicianDAL as a Technician object.
        /// </summary>
        /// <param name="techID">An integer for the technician's ID.</param>
        /// <returns>A Technician object containing the specified technician's Email and Phone information.</returns>
        public Technician GetTechnicianDetails(int techID)
        {
            Technician myTechnician = new Technician();
            DataTable dtTechnicianDetails = new DataTable();

            try
            {
                dtTechnicianDetails = myTechnicianDAL.RetrieveTechnicianDetails(techID);
            }
            catch //Throws exception to calling method.
            {
                throw;
            }

            //Sets value of Email and Phone to corresponding Technician object properties.
            myTechnician.Email = dtTechnicianDetails.Rows[0]["Email"].ToString();
            myTechnician.Phone = dtTechnicianDetails.Rows[0]["Phone"].ToString();

            return myTechnician;
        }

        public bool RequestToAddTechnician(Technician tech)
        {
            try
            {
                if (myTechnicianDAL.AddTechnician(tech.Name, tech.Email, tech.Phone) is true)
                    return true;
                else
                    return false;
            }
            catch
            {
                throw;
            }
        }

        public bool RequestToUpdateTechnician(Technician tech)
        {
            try
            {
                if (myTechnicianDAL.UpdateTechnician(tech.TechID, tech.Name, tech.Email, tech.Phone) is true)
                    return true;
                else
                    return false;
            }
            catch
            {
                throw;
            }
        }

        public bool RequestToDeleteTechnician(int techID)
        {
            try
            {
                if (myTechnicianDAL.DeleteTechnician(techID) is true)
                    return true;
                else
                    return false;
            }
            catch
            {
                throw;
            }
        }
    }
}
