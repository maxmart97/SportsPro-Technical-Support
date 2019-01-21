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

namespace SportsProUserInterfaceLayer
{
    public partial class FrmAddCustomer : Form
    {
        TechSupportDB_LINQ2SQLDataContext dcTechSupportDB = new TechSupportDB_LINQ2SQLDataContext();

        string name, address, city, stateCode, zipCode, phone, email;

        public FrmAddCustomer()
        {
            InitializeComponent();
        }

        private void FrmAddCustomer_Load(object sender, EventArgs e)
        {
            var states = (from state in dcTechSupportDB.States
                          select state).ToList();

            bsState.DataSource = states;

            cboState.SelectedIndex = -1;
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            this.SetValues();

            string validatorResult = CustomerValidator.IsCustomerDataValid(name, address, stateCode, city, zipCode, phone, email);

            if (validatorResult == "Data entered is valid.")
            {
                CustomerBLL myBLL = new CustomerBLL();

                SportsProBLLClassLibrary.Customer myCustomer = new SportsProBLLClassLibrary.Customer
                {
                    Name = name,
                    Address = address,
                    City = city,
                    State = stateCode,
                    ZipCode = zipCode,
                    Phone = Format.PhoneNumber_Parentheses(phone),
                    Email = email,
                };

                try
                {
                    if (myBLL.RequestToAddCustomer(myCustomer) is true)
                    {
                        MessageBox.Show("Customer: '" + myCustomer.Name + "' has been successfully added.");
                        this.ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Customer: '" + myCustomer.Name + "' already exists.");
                    }
                }
                catch
                {
                    MessageBox.Show("Error adding customer. Please contact software developer.");
                }

            }
            else
            {
                MessageBox.Show(validatorResult, "Invalid entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetValues()
        {
            name = txtName.Text;
            address = txtAddress.Text;
            city = txtCity.Text;

            if (cboState.SelectedValue == null)
                stateCode = null;
            else
                stateCode = cboState.SelectedValue.ToString();

            zipCode = txtZipCode.Text;
            phone = txtPhone.Text;
            email = txtEmail.Text;
        }

        private void ClearAll()
        {
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
                txt.Clear();

            cboState.SelectedIndex = -1;
        }

        private void BtnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ClearAll();
        }
    }
}
