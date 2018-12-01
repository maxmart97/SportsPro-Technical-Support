using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SportsProDALClassLibrary;

namespace SportsProBLLClassLibrary
{
    public class ProductBLL
    {
        public ProductBLL()
        {
            //Default Constructor
        }

        /// <summary>
        /// Retrieves the ProductCode and Name of all products from the ProductDAL.
        /// </summary>
        /// <returns>A List of Products with each Product containing its ProductCode and Name.</returns>
        public List<Product> GetAllProducts()
        {
            DataTable dtProductNameAndCode = new DataTable();
            List<Product> lstProductNameAndCode = new List<Product>();
            ProductDAL myProductDAL = new ProductDAL();

            try
            {
                dtProductNameAndCode = myProductDAL.RetrieveAllProducts();
            }
            catch //Throws exception to calling method.
            {
                throw;
            }
            
            DataTableToList.Transfer_Products(dtProductNameAndCode, lstProductNameAndCode);

            return lstProductNameAndCode;
        }
    }
}
