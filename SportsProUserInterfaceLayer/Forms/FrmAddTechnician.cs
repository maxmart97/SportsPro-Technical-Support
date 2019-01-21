using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SportsProBLLClassLibrary;
using SportsProBLLClassLibrary.Miscellaneous_Classes;

namespace SportsProUserInterfaceLayer.Forms
{
    public partial class FrmAddTechnician : Form
    {
        string errorMessage;

        public FrmAddTechnician()
        {
            InitializeComponent();
        }

        private void BtnAddTechnician_Click(object sender, EventArgs e)
        {
            if (IsTechnicianDataValid())
            {
                SportsProBLLClassLibrary.Technician myTechnician = new SportsProBLLClassLibrary.Technician
                {
                    Name = tbName.Text,
                    Email = tbEmail.Text,
                    Phone = Format.PhoneNumber_Dashes(tbPhone.Text)
                };

                TechnicianBLL myTechnicianBLL = new TechnicianBLL();

                try
                {
                    if (myTechnicianBLL.RequestToAddTechnician(myTechnician) is true)
                    {
                        MessageBox.Show(tbName.Text + " has been added successfully.", 
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.ClearAll();
                        tbName.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Technician addition unsuccessful.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Error adding technician. Please contact software developer.");
                }
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        private bool IsTechnicianDataValid()
        {
            if (!string.IsNullOrWhiteSpace(tbName.Text) && tbName.Text.Length <= 50)
            {
                if (IsEmailValid(tbEmail.Text))
                {
                    if (IsPhoneNumberValid(tbPhone.Text))
                    {
                        return true;
                    }
                    else
                    {
                        errorMessage = "Phone number is invalid.";
                    }
                }
                else
                {
                    errorMessage = "Email is invalid.";
                }
            }
            else
            {
                errorMessage = "Name must be less than or equal to 50 characters.";
            }

            return false;
        }

        private static bool IsPhoneNumberValid(string phone)
        {
            Regex regexPhoneNumberNoSymb = new Regex(@"^[0-9]{10}$");
            Regex regexPhoneNumberParenth = new Regex(@"^\([0-9]{3}\) [0-9]{3}-[0-9]{4}$");
            Regex regextPhoneNumberDashes = new Regex(@"^[0-9]{3}-[0-9]{3}-[0-9]{4}$");

            if (regexPhoneNumberNoSymb.IsMatch(phone))
                return true;
            else if (regexPhoneNumberParenth.IsMatch(phone))
                return true;
            else if (regextPhoneNumberDashes.IsMatch(phone))
                return true;
            else
                return false;
        }

        public static bool IsEmailValid(string email)
        {
            Regex regexEmail = new Regex(@"^(?i)[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}$");

            if (email.Length <= 254 && regexEmail.IsMatch(email))
                return true;
            else
                return false;
        }

        public void ClearAll()
        {
            tbName.ResetText();
            tbEmail.ResetText();
            tbPhone.ResetText();
        }

        private void btnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ClearAll();
        }
    }
}
