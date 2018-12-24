using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsProBLLClassLibrary
{
    public class Technician
    {
        //Backing fields.
        private int techID;
        private string name;
        private string email;
        private string phone;

        public Technician()
        {
            //Default Constructor
        }

        /// <summary>
        /// Gets or sets technician ID.
        /// </summary>
        public int TechID { get => techID; set => techID = value; }

        /// <summary>
        /// Gets or sets technician name.
        /// </summary>
        public string Name { get => name; set => name = value; }

        /// <summary>
        /// Gets or sets technician email.
        /// </summary>
        public string Email { get => email; set => email = value; }

        /// <summary>
        /// Gets or sets technician phone number.
        /// </summary>
        public string Phone { get => phone; set => phone = value; }
    }
}
