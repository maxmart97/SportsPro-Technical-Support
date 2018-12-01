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
        private static TechnicianDAL myTechnicianDAL = new TechnicianDAL();

        public TechnicianBLL()
        {
            //Default Constructor
        }

        /// <summary>
        /// Gets names of all technicians from the TechnicianDAL.
        /// </summary>
        /// <returns>A DataTable containing the Name and TechID of each technician.</returns>
        public DataTable GetTechnicianNames()
        {
            DataTable dtTechnicianNames = new DataTable();

            try
            {
                dtTechnicianNames  = myTechnicianDAL.RetrieveTechnicianNames();
            }
            catch //Throws exception to calling method.
            {
                throw;
            }

            return dtTechnicianNames;
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
            myTechnician.TechEmail = dtTechnicianDetails.Rows[0]["Email"].ToString();
            myTechnician.TechPhone = dtTechnicianDetails.Rows[0]["Phone"].ToString();

            return myTechnician;
        }
    }
}
