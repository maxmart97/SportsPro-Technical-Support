using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsProBLLClassLibrary
{
    public class Product
    {
        //Backing fields.
        private string productCode;
        private string name;

        public Product()
        {
            //Default Constructor
        }

        /// <summary>
        /// Gets or sets the product's code.
        /// </summary>
        public string ProductCode { get => productCode; set => productCode = value; }

        /// <summary>
        /// Gets or sets the product's name.
        /// </summary>
        public string Name { get => name; set => name = value; }
    }
}
