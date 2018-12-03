using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportsProBLLClassLibrary;

namespace SportsProUserInterfaceLayer
{
    public partial class FrmRegistrationsByProduct : Form
    {
        //Holds all customer registrations.
        List<SportsProBLLClassLibrary.Registration> lstCustRegForSpecifiedProd = new List<SportsProBLLClassLibrary.Registration>();

        public FrmRegistrationsByProduct()
        {
            InitializeComponent();
        }

        private void CboProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Used to access the CustomerRegistrationBLL.
            RegistrationBLL myCustRegBLL = new RegistrationBLL();

            //Variable to hold the selected product's code.
            string prodCode = cboProduct.SelectedValue.ToString();

            //Prevents new data from stacking on top of old data.
            dgvCustomerRegistration.Rows.Clear();

            /* Without this line of code, for whatever reason, the DisplayMembers (the Names of all the Products) 
             * rearrange after a Product has been selected. Clearing the DataBindings every time a Product is 
             * selected solved this problem. */
            cboProduct.DataBindings.Clear();

            try
            {
                lstCustRegForSpecifiedProd = myCustRegBLL.GetCustRegForSpecifiedProd(prodCode);

                GenericMethods.AddObjectsToBindingSource(lstCustRegForSpecifiedProd, bsCustomerRegistration);
            }
            catch //Action after exception has bubbled up from the DAL.
            {
                MessageBox.Show("Error accessing the database.", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmRegistrationsByProduct_Load(object sender, EventArgs e)
        {
            ProductBLL myProductBLL = new ProductBLL();
            List<SportsProBLLClassLibrary.Product> lstAllProducts = new List<SportsProBLLClassLibrary.Product>();

            try
            {
                lstAllProducts = myProductBLL.GetAllProducts();

                GenericMethods.AddObjectsToBindingSource(lstAllProducts, bsProduct);

                //Prevents a pre-selected product from appearing.
                cboProduct.SelectedIndex = -1;
            }
            catch //Action after exception has bubbled up from the DAL.
            {
                MessageBox.Show("Error accessing the database.", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Closes the form and exits the application.
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void BtnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
