using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsProUserInterfaceLayer
{
    public partial class FrmAddCustomer : Form
    {
        TechSupportDB_LINQ2SQLDataContext dcTechSupportDB = new TechSupportDB_LINQ2SQLDataContext();

        string errorMessage;

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
            if (IsCustomerDataValid())
            {
                Customer myCustomer = new Customer
                {
                    Name = nameTextBox.Text,
                    Address = txtAddress.Text,
                    City = cityTextBox.Text,
                    State = cboState.SelectedValue.ToString(),
                    ZipCode = zipCodeTextBox.Text,
                    Phone = FormatPhoneNumber(phoneTextBox.Text),
                    Email = emailTextBox.Text
                };

                dcTechSupportDB.Customers.InsertOnSubmit(myCustomer);

                try
                {
                    dcTechSupportDB.SubmitChanges();
                    MessageBox.Show("Customer: '" + nameTextBox.Text + "' has been successfully added.");
                }
                catch
                {
                    MessageBox.Show("Error adding customer. Please contact program developer.");
                }

            }
            else
            {
                MessageBox.Show(errorMessage, "Invalid entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsCustomerDataValid()
        {
            if (!string.IsNullOrWhiteSpace(nameTextBox.Text) && nameTextBox.Text.Length <= 50)
            {
                if (!string.IsNullOrWhiteSpace(txtAddress.Text) && txtAddress.Text.Length <= 50)
                {
                    if (cboState.SelectedIndex != -1)
                    {
                        if (!string.IsNullOrWhiteSpace(cityTextBox.Text) && cityTextBox.Text.Length <= 20)
                        {
                            if (!string.IsNullOrWhiteSpace(zipCodeTextBox.Text) && 
                                (zipCodeTextBox.Text.Length >= 3 && zipCodeTextBox.Text.Length <= 5))
                            {
                                if (IsPhoneNumberValid(phoneTextBox.Text))
                                {
                                    if (emailTextBox.Text.Length <= 50)
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        errorMessage = "Email is invalid.";
                                    }
                                }
                                else
                                {
                                    errorMessage = "Phone number is invalid. Please only enter in 10 digits.";
                                }
                            }
                            else
                            {
                                errorMessage = "Zip Code is invalid.";
                            }
                        }
                        else
                        {
                            errorMessage = "City is invalid.";
                        }
                    }
                    else
                    {
                        errorMessage = "Please choose a state.";
                    }
                }
                else
                {
                    errorMessage = "Address is invalid.";
                }
            }
            else
            {
                errorMessage = "Name is invalid.";
            }

            return false;
        }

        private bool IsPhoneNumberValid(string phoneNumber)
        {
            if (phoneNumber.Length == 10)
            {
                foreach (char digit in phoneNumber)
                {
                    if (!char.IsDigit(digit))
                        return false;
                }
            }
            else
            {
                return false;
            }

            return true;
        }

        private string FormatPhoneNumber(string phoneNumber)
        {
            string formattedPhoneNumber = phoneNumber;

            formattedPhoneNumber = formattedPhoneNumber.Insert(0, "(");
            formattedPhoneNumber = formattedPhoneNumber.Insert(3, ") ");
            formattedPhoneNumber = formattedPhoneNumber.Insert(8, "-");

            return formattedPhoneNumber;
        }
    }
}
