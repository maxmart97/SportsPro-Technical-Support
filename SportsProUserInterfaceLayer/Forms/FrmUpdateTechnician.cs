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
using SportsProUserInterfaceLayer.LINQ_to_SQL;

namespace SportsProUserInterfaceLayer.Forms
{
    public partial class FrmUpdateTechnician : Form
    {
        TechSupportDB_LINQ2SQLDataContext dc = new TechSupportDB_LINQ2SQLDataContext();
        List<SportsProUserInterfaceLayer.LINQ_to_SQL.Technician> lstTechnicians = new List<SportsProUserInterfaceLayer.LINQ_to_SQL.Technician>();

        string errorMessage;

        public FrmUpdateTechnician()
        {
            InitializeComponent();
        }

        private void FrmUpdateTechnician_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadTechnicians();
            }
            catch
            {
                MessageBox.Show("Error accessing database. Please contact software developer.", "Database Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadTechnicians()
        {
            dc.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, dc.Technicians);

            lstTechnicians = (from technician in dc.Technicians
                              select technician).ToList();

            bsTechnicians.DataSource = lstTechnicians;
        }

        public void ClearAll()
        {
            lbTechnicians.SelectedIndex = -1;
            tbName.ResetText();
            tbEmail.ResetText();
            tbPhone.ResetText();
        }

        private void BtnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ClearAll();
        }

        private void LbTechnicians_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTechnicians.Focused && lbTechnicians.Items.Count >= 1 && lbTechnicians.SelectedItem != null)
            {
                SportsProUserInterfaceLayer.LINQ_to_SQL.Technician myTechnician = lstTechnicians[lbTechnicians.SelectedIndex];

                tbName.Text = myTechnician.Name;
                tbEmail.Text = myTechnician.Email;
                tbPhone.Text = myTechnician.Phone;
            }
        }

        private void BtnUpdateTechnician_Click(object sender, EventArgs e)
        {
            if (IsTechnicianDataValid())
            {
                SportsProBLLClassLibrary.Technician myTechnician = new SportsProBLLClassLibrary.Technician
                {
                    TechID = lstTechnicians[lbTechnicians.SelectedIndex].TechID,
                    Name = tbName.Text,
                    Email = tbEmail.Text,
                    Phone = Format.PhoneNumber_Dashes(tbPhone.Text)
                };

                TechnicianBLL myTechnicianBLL = new TechnicianBLL();

                try
                {
                    if (myTechnicianBLL.RequestToUpdateTechnician(myTechnician) is true)
                    {
                        MessageBox.Show("The technician has been updated successfully.",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.LoadTechnicians();
                        this.ClearAll();
                        tbName.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Technician update unsuccessful.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Error updating technician. Please contact software developer.");
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
    }
}
