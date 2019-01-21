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
using SportsProUserInterfaceLayer.LINQ_to_SQL;

namespace SportsProUserInterfaceLayer.Forms
{
    public partial class FrmUpdateRegistration : Form
    {
        TechSupportDB_LINQ2SQLDataContext dc = new TechSupportDB_LINQ2SQLDataContext();
        int oldCustomerID;
        string oldProductCode;

        public FrmUpdateRegistration()
        {
            InitializeComponent();
        }

        private void FrmUpdateRegistration_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadRegistrations();
                this.LoadComboBoxes();
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
                                     registration.RegistrationDate,
                                     registration.CustomerID,
                                     registration.ProductCode
                                 }).ToList();

            bsRegistration.DataSource = registrations;
        }

        public void LoadComboBoxes()
        {
            dc.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, dc.Customers);
            dc.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, dc.Products);

            var customers = from customer in dc.Customers
                            select customer;

            cboCustomers.DisplayMember = "Name";
            cboCustomers.ValueMember = "CustomerID";
            cboCustomers.DataSource = customers;

            var products = from product in dc.Products
                           select product;

            cboProducts.DisplayMember = "Name";
            cboProducts.ValueMember = "ProductCode";
            cboProducts.DataSource = products;
        }

        private void DgvRegistrations_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRegistrations.Focused && dgvRegistrations.SelectedRows.Count == 1)
            {
                cboCustomers.SelectedIndex = GetCustomerIndex(dgvRegistrations.SelectedCells[0].Value.ToString());
                cboProducts.SelectedIndex = GetProductIndex(dgvRegistrations.SelectedCells[1].Value.ToString());
                dtpRegistrationDate.Value = (DateTime)dgvRegistrations.SelectedCells[2].Value;

                oldCustomerID = (int)cboCustomers.SelectedValue;
                oldProductCode = cboProducts.SelectedValue.ToString();

                this.EnableControls();
            }
        }

        private int GetCustomerIndex(string custName)
        {
            int index = 0;
            int pos = -1;
            bool found = false;
            
            while (index < cboCustomers.Items.Count && found is false)
            {
                SportsProUserInterfaceLayer.LINQ_to_SQL.Customer cust = (SportsProUserInterfaceLayer.LINQ_to_SQL.Customer)cboCustomers.Items[index];

                if (custName == cust.Name)
                {
                    pos = index;
                    found = true;
                }

                index++;
            }

            return pos;
        }

        private int GetProductIndex(string prodName)
        {
            int index = 0;
            int pos = -1;
            bool found = false;

            while (index < cboProducts.Items.Count && found is false)
            {
                SportsProUserInterfaceLayer.LINQ_to_SQL.Product prod = (SportsProUserInterfaceLayer.LINQ_to_SQL.Product)cboProducts.Items[index];

                if (prodName == prod.Name)
                {
                    pos = index;
                    found = true;
                }

                index++;
            }

            return pos;
        }

        public void ClearAll()
        {
            dgvRegistrations.ClearSelection();
            cboCustomers.SelectedIndex = -1;
            cboProducts.SelectedIndex = -1;
            dtpRegistrationDate.ResetText();
        }

        public void EnableControls()
        {
            cboCustomers.Enabled = true;
            cboProducts.Enabled = true;
            dtpRegistrationDate.Enabled = true;
            btnUpdateRegistration.Enabled = true;
        }

        public void DisableControls()
        {
            cboCustomers.Enabled = false;
            cboProducts.Enabled = false;
            dtpRegistrationDate.Enabled = false;
            btnUpdateRegistration.Enabled = false;
        }


        private void BtnUpdateRegistration_Click(object sender, EventArgs e)
        {
            try
            {
                SportsProBLLClassLibrary.Registration newRegistration = new SportsProBLLClassLibrary.Registration
                {
                    CustomerID = (int)cboCustomers.SelectedValue,
                    ProductCode = cboProducts.SelectedValue.ToString(),
                    RegistrationDate = dtpRegistrationDate.Value
                };

                RegistrationBLL myRegistrationBLL = new RegistrationBLL();

                if (myRegistrationBLL.RequestToUpdateRegistration(oldCustomerID, oldProductCode, newRegistration) is true)
                {
                    MessageBox.Show("The registration has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.LoadRegistrations();
                    this.ClearAll();
                    this.DisableControls();
                }
                else
                {
                    MessageBox.Show("Registration update unsuccessful.", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.DisableControls();
        }
    }
}
