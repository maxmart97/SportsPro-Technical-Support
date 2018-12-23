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
        private CustomerDAL myCustDAL = new CustomerDAL();

        public CustomerBLL()
        {
            //Default Constructor
        }

        /// <summary>
        /// Retrieves all customers from the CustomerDAL.
        /// </summary>
        /// <returns>A List of all Customers.</returns>
        public List<Customer> GetAllCustomers()
        {
            DataTable dtCustomers = new DataTable();
            List<Customer> lstCustomers = new List<Customer>();

            try
            {
                dtCustomers = myCustDAL.RetrieveAllCustomers();
            }
            catch //Throws exception to calling method.
            {
                throw;
            }

            DataTableToList.Transfer_Customers(dtCustomers, lstCustomers);

            return lstCustomers;
        }

        public bool RequestToAddCustomer(Customer cust)
        {
            try
            {
                if (myCustDAL.AddCustomer(cust.Name, cust.Address, cust.City, 
                    cust.State, cust.ZipCode, cust.Phone, cust.Email) is true)
                    return true;
                else
                    return false;
            }
            catch
            {
                throw;
            }
        }

        public bool RequestToUpdateCustomer(Customer cust)
        {
            try
            {
                if (myCustDAL.UpdateCustomer(cust.CustomerID, cust.Name, cust.Address, cust.City,
                    cust.State, cust.ZipCode, cust.Phone, cust.Email) is true)
                    return true;
                else
                    return false;
            }
            catch
            {
                throw;
            }
        }

        public bool RequestToDeleteCustomer(int customerID)
        {
            try
            {
                if (myCustDAL.DeleteCustomer(customerID) is true)
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
