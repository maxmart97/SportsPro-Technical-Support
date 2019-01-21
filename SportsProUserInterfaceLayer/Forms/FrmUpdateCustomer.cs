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
using SportsProBLLClassLibrary.Miscellaneous_Classes;

namespace SportsProUserInterfaceLayer.Forms
{
    public partial class FrmUpdateCustomer : Form
    {
        TechSupportDB_LINQ2SQLDataContext dc = new TechSupportDB_LINQ2SQLDataContext();
        List<SportsProBLLClassLibrary.Customer> lstCustomers = new List<SportsProBLLClassLibrary.Customer>();
        CustomerBLL myCustomerBLL = new CustomerBLL();

        public FrmUpdateCustomer()
        {
            InitializeComponent();
        }

        private void FrmUpdateCustomer_Load(object sender, EventArgs e)
        {
            this.LoadFormData();
        }

        private void ClearAll()
        {
            lbCustomers.SelectedIndex = -1;
            cboState.SelectedIndex = -1;

            foreach (TextBox txt in this.Controls.OfType<TextBox>())
                txt.Text = "";
        }

        private void LbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCustomers.Focused)
            {
                cboState.SelectedIndex = GetStateIndexOfCustomerState();
                SetTextBoxesWithCustomerData(lstCustomers[lbCustomers.SelectedIndex]);
            }
        }

        private int GetStateIndexOfCustomerState()
        {
            var selectedCustomer = (from customer in lstCustomers
                                    where customer.CustomerID == (int)lbCustomers.SelectedValue
                                    select customer).Single();

            int indexOfStateInCBO = -1;
            bool found = false;

            while (found is false)
            {
                foreach (State state in cboState.Items)
                {
                    if (state.StateCode == selectedCustomer.State)
                    {
                        indexOfStateInCBO = cboState.Items.IndexOf(state);
                        found = true;
                    }
                }
            }

            return indexOfStateInCBO;
        }

        private void SetTextBoxesWithCustomerData(SportsProBLLClassLibrary.Customer cust)
        {
            txtName.Text = cust.Name;
            txtAddress.Text = cust.Address;
            txtCity.Text = cust.City;
            txtZipCode.Text = cust.ZipCode;
            txtPhone.Text = cust.Phone;
            txtEmail.Text = cust.Email;
        }

        private void BtnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (cboState.SelectedIndex != -1)
            {
                string validatorResult = CustomerValidator.IsCustomerDataValid(txtName.Text, txtAddress.Text,
                    cboState.SelectedValue.ToString(), txtCity.Text, txtZipCode.Text, txtPhone.Text, txtEmail.Text);

                if (validatorResult == "Data entered is valid.")
                {
                    SportsProBLLClassLibrary.Customer myCustomer = new SportsProBLLClassLibrary.Customer
                    {
                        CustomerID = lstCustomers[lbCustomers.SelectedIndex].CustomerID,
                        Name = txtName.Text,
                        Address = txtAddress.Text,
                        City = txtCity.Text,
                        State = cboState.SelectedValue.ToString(),
                        ZipCode = txtZipCode.Text,
                        Phone = Format.PhoneNumber_Parentheses(txtPhone.Text),
                        Email = txtEmail.Text,
                    };

                    try
                    {
                        if (myCustomerBLL.RequestToUpdateCustomer(myCustomer) is true)
                        {
                            MessageBox.Show("Customer: '" + txtName.Text + "' has been successfully updated.", "Update Successful",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.LoadFormData();
                        }
                        else
                        {
                            MessageBox.Show("Error updating customer.", "Update Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show(validatorResult, "Invalid entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a customer.", "No customer selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LoadFormData()
        {
            try
            {
                lstCustomers = myCustomerBLL.GetAllCustomers();
                bsCustomer.DataSource = lstCustomers;

                var states = from state in dc.States
                             select state;

                bsState.DataSource = states;

                ClearAll();
            }
            catch
            {
                MessageBox.Show("Error accessing the database.");
            }
        }

        private void BtnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ClearAll();
        }
    }
}
