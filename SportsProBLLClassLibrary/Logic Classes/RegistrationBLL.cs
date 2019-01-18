using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsProDALClassLibrary;
using System.Data;

namespace SportsProBLLClassLibrary
{
    public class RegistrationBLL
    {
        public RegistrationBLL()
        {
            //Default Constructor
        }

        /// <summary>
        /// Gets all customer registrations for the specified product from the CustomerRegistrationDAL.
        /// </summary>
        /// <param name="prodCode">A string containing the product's code.</param>
        /// <returns>A List of CustomerRegistration objects holding data about each customer's registration.</returns>
        public List<Registration> GetCustRegForSpecifiedProd(string prodCode)
        {
            DataTable dtCustRegForSpecifiedProd = new DataTable();
            List<Registration> lstCustRegForSpecifiedProd = new List<Registration>();
            RegistrationDAL myCustRegDAL = new RegistrationDAL();

            try
            {
                dtCustRegForSpecifiedProd = myCustRegDAL.RetrieveCustRegForSpecifiedProduct(prodCode);
            }
            catch //Throws exception to calling method.
            {
                throw;
            }

            DataTableToList.Transfer_CustReg(dtCustRegForSpecifiedProd, lstCustRegForSpecifiedProd);

            return lstCustRegForSpecifiedProd;
        }

        /// <summary>
        /// Sends registration information to RegistrationDAL.
        /// </summary>
        /// <param name="aRegistration">A Registration object.</param>
        /// <returns>True if registration succeeded and false if registration failed.</returns>
        public bool AddNewRegistration(Registration aRegistration)
        {
            RegistrationDAL myRegistrationDAL = new RegistrationDAL();

            bool registrationStatus;

            try
            {
                registrationStatus = myRegistrationDAL.RegisterProduct(aRegistration.ProductCode, 
                    aRegistration.CustomerID, aRegistration.RegistrationDate);
            }
            catch
            {
                throw;
            }

            return registrationStatus;
        }

        public bool RequestToUpdateRegistration(int oldCustomerID, string oldProductCode, Registration newRegistration)
        {
            RegistrationDAL myRegistrationDAL = new RegistrationDAL();

            try
            {
                if (myRegistrationDAL.UpdateRegistration(oldCustomerID, oldProductCode, newRegistration.CustomerID, 
                        newRegistration.ProductCode, newRegistration.RegistrationDate) is true)
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
