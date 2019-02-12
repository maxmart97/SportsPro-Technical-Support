using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SportsProBLLClassLibrary
{
    public static class DataTableToList
    {
        /* 
         * -----------------------------------------------
         * 
         * THIS CLASS CONTAINS METHODS THAT TRANSFER DATA 
         * IN A DATA TABLE TO A LIST OF A SPECIFIC OBJECT.
         * 
         * -----------------------------------------------
        */


        /// <summary>
        /// Takes data from a DataTable and transfers the data to a List of Customers.
        /// A Customer object contains only two properties: CustomerID and Name.
        /// </summary>
        /// <param name="dt">A DataTable object containing records of CustomerID and Name for each customer.</param>
        /// <param name="lst">A List object that can only contain Customer objects.</param>
        public static void Transfer_Customers(DataTable dt, List<Customer> lst)
        {
            /* Loops through DataTable
             * Sets values to corresponding Customer properties.
             * Adds each Customer to List. */
            foreach (DataRow dr in dt.Rows)
            {
                Customer myCustomer = new Customer();

                myCustomer.CustomerID = (int)dr["CustomerID"];
                myCustomer.Name = dr["Name"].ToString();
                myCustomer.Address = dr["Address"].ToString();
                myCustomer.City = dr["City"].ToString();
                myCustomer.State = dr["State"].ToString();
                myCustomer.ZipCode = dr["ZipCode"].ToString();

                if (string.IsNullOrWhiteSpace(dr["Phone"].ToString()))
                    myCustomer.Phone = null;
                else
                    myCustomer.Phone = dr["Phone"].ToString();

                if (string.IsNullOrWhiteSpace(dr["Email"].ToString()))
                    myCustomer.Email = null;
                else
                    myCustomer.Email = dr["Email"].ToString();

                lst.Add(myCustomer);
            }
        }

        /// <summary>
        /// Takes data from a DataTable and transfers the data to a List of CustomerRegistrations.
        /// </summary>
        /// <param name="dt">A DataTable object containing records of customer registration information.</param>
        /// <param name="lst">A List object that can only contain CustomerRegistration objects.</param>
        public static void Transfer_CustReg(DataTable dt, List<Registration> lst)
        {
            /* Loops through DataTable
             * Sets values to corresponding CustomerRegistration properties.
             * Adds each CustomerRegistratoin to list. */
            foreach (DataRow dr in dt.Rows)
            {
                Registration myCustReg = new Registration();

                myCustReg.CustomerID = (int)dr["CustomerID"];
                myCustReg.Name = dr["Name"].ToString();

                if (string.IsNullOrWhiteSpace(dr["Email"].ToString()))
                    myCustReg.Email = null;
                else
                    myCustReg.Email = dr["Email"].ToString();

                myCustReg.RegistrationDate = (DateTime)dr["RegistrationDate"];

                lst.Add(myCustReg);
            }
        }

        /// <summary>
        /// Takes data from a DataTable and transfers the data to a List of Incidents.
        /// </summary>
        /// <param name="dt">A DataTable object containing records of incidents and their corresponding attributes.</param>
        /// <param name="lst">A List object that can only contain Incident objects.</param>
        public static void Transfer_Incidents(DataTable dt, List<Incident> lst)
        {
            /* Loops through DataTable.
             * Sets values to corresponding Incident properties.
             * Adds each Incident to list.*/
            foreach (DataRow row in dt.Rows)
            {
                Incident myIncident = new Incident();

                myIncident.IncidentID = (int)row["IncidentID"];
                myIncident.CustomerID = (int)row["CustomerID"];
                myIncident.ProductCode = row["ProductCode"].ToString();

                //Checks if TechID is null or empty before assigning value.
                if (row["TechID"] == DBNull.Value || row["TechID"].ToString() == string.Empty)
                    myIncident.TechID = null;
                else
                    myIncident.TechID = (int)row["TechID"];

                myIncident.DateOpened = (DateTime)row["DateOpened"];

                //Checks if DateClosed is null or empty before assigning value.
                if (String.IsNullOrWhiteSpace(row["DateClosed"].ToString()))
                    myIncident.DateClosed = null;
                else
                    myIncident.DateClosed = (DateTime)row["DateClosed"];

                myIncident.Title = row["Title"].ToString();
                myIncident.Description = row["Description"].ToString();

                lst.Add(myIncident);
            }
        }

        /// <summary>
        /// Takes data from a DataTable and transfers the data to a List of Products.
        /// A Product object contains only two properties: ProductCode and Name.
        /// </summary>
        /// <param name="dt">A DataTable object containing records of ProductCode and Name for each product.</param>
        /// <param name="lst">A List object that can only contain Product objects.</param>
        public static void Transfer_Products(DataTable dt, List<Product> lst)
        {
            /* Loops through DataTable
             * Sets values to corresponding Product properties.
             * Adds each Product to list. */
            foreach (DataRow dr in dt.Rows)
            {
                Product myProduct = new Product();
                myProduct.ProductCode = dr["ProductCode"].ToString();
                myProduct.Name = dr["Name"].ToString();

                lst.Add(myProduct);
            }
        }

        public static void Transfer_Technicians(DataTable dt, List<Technician> lst)
        {
            foreach (DataRow dr in dt.Rows)
            {
                Technician myTechnician = new Technician();

                myTechnician.TechID = (int)dr["TechID"];
                myTechnician.Name = dr["Name"].ToString();
                myTechnician.Email = dr["Email"].ToString();
                myTechnician.Phone = dr["Phone"].ToString();

                lst.Add(myTechnician);
            }
        }

    }
}
