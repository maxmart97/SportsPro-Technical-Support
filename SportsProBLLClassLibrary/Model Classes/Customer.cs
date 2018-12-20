using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsProBLLClassLibrary
{
    public class Customer
    {
        //Backing fields.
        private int customerID;
        private string name;
        private string address;
        private string city;
        private string state;
        private string zipCode;
        private string phone;
        private string email;

        public Customer()
        {
            //Default Constructor
        }

        /// <summary>
        /// Gets or sets customer's ID.
        /// </summary>
        public int CustomerID { get => customerID; set => customerID = value; }

        /// <summary>
        /// Gets or sets customer's name.
        /// </summary>
        public string Name { get => name; set => name = value; }

        /// <summary>
        /// Gets or sets customer's address.
        /// </summary>
        public string Address { get => address; set => address = value; }

        /// <summary>
        /// Gets or sets customer's city.
        /// </summary>
        public string City { get => city; set => city = value; }

        /// <summary>
        /// Gets or sets customer's state.
        /// </summary>
        public string State { get => state; set => state = value; }

        /// <summary>
        /// Gets or sets customer's zipCode.
        /// </summary>
        public string ZipCode { get => zipCode; set => zipCode = value; }

        /// <summary>
        /// Gets or sets customer's phone number.
        /// </summary>
        public string Phone { get => phone; set => phone = value; }

        /// <summary>
        /// Gets or sets customer's email.
        /// </summary>
        public string Email { get => email; set => email = value; }
        
        
    }
}
