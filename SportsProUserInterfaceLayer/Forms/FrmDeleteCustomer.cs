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

namespace SportsProUserInterfaceLayer.Forms
{
    public partial class FrmDeleteCustomer : Form
    {
        List<SportsProBLLClassLibrary.Customer> lstCustomers = new List<SportsProBLLClassLibrary.Customer>();
        CustomerBLL myCustomerBLL = new CustomerBLL();

        public FrmDeleteCustomer()
        {
            InitializeComponent();
        }

        private void FrmDeleteCustomer_Load(object sender, EventArgs e)
        {
            this.LoadFormData();
            this.ClearAll();
        }

        private void LoadFormData()
        {
            try
            {
                lstCustomers = myCustomerBLL.GetAllCustomers();
                bsCustomer.DataSource = lstCustomers;
            }
            catch
            {
                MessageBox.Show("Error accessing the database.");
            }
        }

        public void ClearAll()
        {
            lbCustomers.SelectedIndex = -1;
            lblCustomerIDNumber.Text = "";
            lblCustomerName.Text = "";
            lblCustomerAddress.Text = "";
            lblCustomerState.Text = "";
            lblCustomerCity.Text = "";
            lblCustomerZipCode.Text = "";
            lblCustomerPhone.Text = "";
            lblCustomerEmail.Text = "";
        }

        private void SetLabels(SportsProBLLClassLibrary.Customer cust)
        {
            lblCustomerIDNumber.Text = cust.CustomerID.ToString();
            lblCustomerName.Text = cust.Name;
            lblCustomerAddress.Text = cust.Address;
            lblCustomerState.Text = cust.State;
            lblCustomerCity.Text = cust.City;
            lblCustomerZipCode.Text = cust.ZipCode;
            lblCustomerPhone.Text = cust.Phone;
            lblCustomerEmail.Text = cust.Email;
        }

        private void LbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCustomers.Focused)
            {
                SetLabels(lstCustomers[lbCustomers.SelectedIndex]);
            }
        }

        private void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (lbCustomers.SelectedIndex != -1)
            {
                DialogResult userChoice = MessageBox.Show("Are you sure you want to delete " + lblCustomerName.Text + "?", 
                    "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (userChoice == DialogResult.Yes)
                {
                    try
                    {
                        if (myCustomerBLL.RequestToDeleteCustomer(lstCustomers[lbCustomers.SelectedIndex].CustomerID) is true)
                        {
                            MessageBox.Show(lblCustomerName.Text + " has been successfully deleted.", "Deletion successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.LoadFormData();
                            this.ClearAll();
                        }
                        else
                        {
                            MessageBox.Show(lblCustomerName.Text + " could not be deleted.", "Deletion unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error accessing database. Please contact software developer.", "Database Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Deletion canceled.");
                }
            }
            else
            {
                MessageBox.Show("Please select a customer.");
            }
        }

        private void BtnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ClearAll();
        }
    }
}
