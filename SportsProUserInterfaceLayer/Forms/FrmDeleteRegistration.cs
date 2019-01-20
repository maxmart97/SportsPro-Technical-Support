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
    public partial class FrmDeleteRegistration : Form
    {
        TechSupportDB_LINQ2SQLDataContext dc = new TechSupportDB_LINQ2SQLDataContext();

        public FrmDeleteRegistration()
        {
            InitializeComponent();
        }

        private void FrmDeleteRegistration_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadRegistrations();
            }
            catch
            {
                MessageBox.Show("Error accessing database. Please contact software developer.", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadRegistrations()
        {
            dc.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, dc.Registrations);

            var registrations = (from registration in dc.Registrations
                                 select new
                                 {
                                     CustomerName = registration.Customer.Name,
                                     ProductName = registration.Product.Name,
                                     registration.RegistrationDate
                                 }).ToList();

            bsRegistration.DataSource = registrations;
        }

        private void DgvRegistrations_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRegistrations.Focused && dgvRegistrations.SelectedRows.Count == 1)
            {
                lblCustomer.Text = dgvRegistrations.SelectedCells[0].Value.ToString();
                lblProduct.Text = dgvRegistrations.SelectedCells[1].Value.ToString();
                lblRegDate.Text = dgvRegistrations.SelectedCells[2].Value.ToString();

                this.EnableControls();
            }
        }

        public void ClearAll()
        {
            dgvRegistrations.ClearSelection();
            lblCustomer.ResetText();
            lblProduct.ResetText();
            lblRegDate.ResetText();
        }

        public void EnableControls()
        {
            lblCustomer.Enabled = true;
            lblProduct.Enabled = true;
            lblRegDate.Enabled = true;
            btnDeleteRegistration.Enabled = true;
        }

        public void DisableControls()
        {
            lblCustomer.Enabled = false;
            lblProduct.Enabled = false;
            lblRegDate.Enabled = false;
            btnDeleteRegistration.Enabled = false;
        }

        private void BtnDeleteRegistration_Click(object sender, EventArgs e)
        {
            try
            {
                RegistrationBLL myRegistrationBLL = new RegistrationBLL();

                var selectedRegInfo = (from registration in dc.Registrations
                               where registration.Customer.Name == dgvRegistrations.SelectedCells[0].Value.ToString()
                               where registration.Product.Name == dgvRegistrations.SelectedCells[1].Value.ToString()
                               select new { registration.CustomerID, registration.ProductCode }).ToList();

                var customerID = selectedRegInfo[0].CustomerID;
                var productCode = selectedRegInfo[0].ProductCode;

                if (myRegistrationBLL.RequestToDeleteRegistration(customerID, productCode) is true)
                {
                    MessageBox.Show("The registration has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.LoadRegistrations();
                    this.ClearAll();
                    this.DisableControls();
                }
                else
                {
                    MessageBox.Show("Registration deletion unsuccessful.", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error accessing database. Please contact software developer.", "Database Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ClearAll();
        }
    }
}
