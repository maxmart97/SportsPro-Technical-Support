using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SportsProDALClassLibrary;

namespace SportsProBLLClassLibrary
{
    public class CustomerBLL
    {
        public CustomerBLL()
        {
            //Default Constructor
        }

        /// <summary>
        /// Retrieves the CustomerID and Name of all customers from the CustomerDAL.
        /// </summary>
        /// <returns>A List of all Customers with each Customer containing his or her CustomerID and Name.</returns>
        public List<Customer> GetAllCustomers()
        {
            DataTable dtCustomers = new DataTable();
            List<Customer> lstCustomers = new List<Customer>();
            CustomerDAL myCustomerDAL = new CustomerDAL();

            try
            {
                dtCustomers = myCustomerDAL.RetrieveAllCustomers();
            }
            catch //Throws exception to calling method.
            {
                throw;
            }

            DataTableToList.Transfer_Customers(dtCustomers, lstCustomers);

            return lstCustomers;
        }
    }
}
