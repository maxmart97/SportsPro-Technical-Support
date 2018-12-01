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
        private string techName;
        private string techEmail;
        private string techPhone;

        public Technician()
        {
            //Default Constructor
        }

        /// <summary>
        /// Gets or sets technician ID.
        /// </summary>
        public int TechID
        {
            get { return techID; }
            set { techID = value; }
        }

        /// <summary>
        /// Gets or sets technician name.
        /// </summary>
        public string TechName
        {
            get { return techName; }
            set { techName = value; }
        }

        /// <summary>
        /// Gets or sets technician email.
        /// </summary>
        public string TechEmail
        {
            get { return techEmail; }
            set { techEmail = value; }
        }

        /// <summary>
        /// Gets or sets technician phone number.
        /// </summary>
        public string TechPhone
        {
            get { return techPhone; }
            set { techPhone = value; }
        }
    }
}
