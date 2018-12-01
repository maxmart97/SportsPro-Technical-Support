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
    public partial class FrmAddRegistration : Form
    {
        //Variable to reference close button.
        private const int CP_NOCLOSE_BUTTON = 0x200;

        //Property method to disable to close button.
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCP = base.CreateParams;
                myCP.ClassStyle = myCP.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCP;
            }
        }

        public FrmAddRegistration()
        {
            InitializeComponent();
        }

        private void FrmAddRegistration_Load(object sender, EventArgs e)
        {
            CustomerBLL myCustomerBLL = new CustomerBLL();
            ProductBLL myProductBLL = new ProductBLL();

            try
            {
                //Sets up customer ComboBox.
                cboCustomer.DisplayMember = "Name";
                cboCustomer.ValueMember = "CustomerID";
                cboCustomer.DataSource = myCustomerBLL.GetCustomerIDandName();
                cboCustomer.SelectedIndex = -1;

                //Sets up product ComboBox.
                cboProduct.DisplayMember = "Name";
                cboProduct.ValueMember = "ProductCode";
                cboProduct.DataSource = myProductBLL.GetAllProducts();
                cboProduct.SelectedIndex = -1;
            }
            /* Action performed after exception has bubbled up from DAL
             * when the database is unreachable. */
            catch
            {
                MessageBox.Show("Error accessing database.");
            }
        }

        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            //Checks if user has selected both a customer and a product.
            if (cboCustomer.SelectedIndex != -1 && cboProduct.SelectedIndex != -1)
            {
                Registration myRegistration = new Registration();
                RegistrationBLL myRegistrationBLL = new RegistrationBLL();

                //Sets up Registration object.
                myRegistration.CustomerID = (int)cboCustomer.SelectedValue;
                myRegistration.ProductCode = cboProduct.SelectedValue.ToString();
                myRegistration.RegistrationDate = DateTime.Today;

                try
                {
                    //Checks if the registration was successful.
                    if (myRegistrationBLL.AddNewRegistration(myRegistration) is true)
                        MessageBox.Show("The product was successfully registered.", "Add Registration", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("The registration already exists.", "Add Registration", 
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                /* Action performed after exception has bubbled up from DAL
                 * when the database is unreachable. */
                catch
                {
                    MessageBox.Show("Error accessing the database.", "Database error.", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
            }
            else
            {
                MessageBox.Show("Please select both a customer and a product.", "Selection Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Resets both ComboBoxes to starting state without preselected items.
            cboCustomer.SelectedIndex = -1;
            cboProduct.SelectedIndex = -1;
        }
    }
}
