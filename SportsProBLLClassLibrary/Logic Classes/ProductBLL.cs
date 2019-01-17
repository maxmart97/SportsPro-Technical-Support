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
        private static ProductDAL myProductDAL = new ProductDAL();

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

        public bool RequestToAddProduct(Product prod)
        {
            try
            {
                if (myProductDAL.AddProduct(prod.ProductCode, prod.Name, prod.Version, prod.ReleaseDate) is true)
                    return true;
                else
                    return false;
            }
            catch
            {
                throw;
            }
        }

        public bool RequestToUpdateProduct(string oldProdCode, Product prod)
        {
            ProductDAL myProductDAL = new ProductDAL();

            try
            {
                if (myProductDAL.UpdateProduct(oldProdCode, prod.ProductCode, prod.Name, prod.Version, prod.ReleaseDate) is true)
                    return true;
                else
                    return false;
            }
            catch
            {
                throw;
            }
        }

        public bool RequestToDeleteProduct(string productCode)
        {
            try
            {
                if (myProductDAL.DeleteProduct(productCode) is true)
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
