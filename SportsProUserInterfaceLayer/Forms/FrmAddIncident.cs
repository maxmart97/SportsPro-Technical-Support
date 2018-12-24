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
    public partial class FrmAddIncident : Form
    {
        List<SportsProBLLClassLibrary.Customer> lstCustomers = new List<SportsProBLLClassLibrary.Customer>();
        List<SportsProBLLClassLibrary.Product> lstProducts = new List<SportsProBLLClassLibrary.Product>();
        List<SportsProBLLClassLibrary.Technician> lstTechnicians = new List<SportsProBLLClassLibrary.Technician>();

        CustomerBLL myCustomerBLL = new CustomerBLL();
        ProductBLL myProductBLL = new ProductBLL();
        TechnicianBLL myTechnicianBLL = new TechnicianBLL();

        public FrmAddIncident()
        {
            InitializeComponent();
        }

        private void FrmAddIncident_Load(object sender, EventArgs e)
        {
            try
            {
                lstCustomers = myCustomerBLL.GetAllCustomers();
                lstProducts = myProductBLL.GetAllProducts();
                lstTechnicians = myTechnicianBLL.GetAllTechnicians_AsList();

                this.LoadFormData();
            }
            catch
            {
                MessageBox.Show("Error accessing database. Please contact software developer.", "Database Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFormData()
        {
            bsCustomers.DataSource = lstCustomers;
            bsProducts.DataSource = lstProducts;
            bsTechnicians.DataSource = lstTechnicians;

            cboCustomers.SelectedIndex = -1;
            cboProducts.SelectedIndex = -1;
            cboTechnicians.SelectedIndex = -1;
        }

        private void BtnAddIncident_Click(object sender, EventArgs e)
        {
            IncidentBLL myIncidentBLL = new IncidentBLL();

            if (cboCustomers.SelectedIndex != -1)
            {
                if (cboProducts.SelectedIndex != -1)
                {
                    if (!string.IsNullOrWhiteSpace(tbTitle.Text) && tbTitle.Text.Length <= 50)
                    {
                        if (!string.IsNullOrWhiteSpace(rtbDescription.Text) && rtbDescription.Text.Length <= 2000)
                        {
                            SportsProBLLClassLibrary.Incident myIncident = new SportsProBLLClassLibrary.Incident
                            {
                                CustomerID = (int)cboCustomers.SelectedValue,
                                ProductCode = cboProducts.SelectedValue.ToString(),
                                DateOpened = dtpDateOpened.Value,
                                Title = tbTitle.Text,
                                Description = rtbDescription.Text
                            };

                            if (dtpDateClosed.Checked)
                            {
                                if (dtpDateClosed.Value <= DateTime.Now && dtpDateClosed.Value >= myIncident.DateOpened)
                                {
                                    myIncident.DateClosed = dtpDateClosed.Value;
                                }
                                else
                                {
                                    MessageBox.Show("Date closed cannot be greater than today's date or less than " +
                                       "date opened.", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    return;
                                }
                            }
                            else
                            {
                                myIncident.DateClosed = null;
                            }

                            if (cboTechnicians.SelectedIndex == -1)
                                myIncident.TechID = null;
                            else
                                myIncident.TechID = (int)cboTechnicians.SelectedValue;

                            try
                            {
                                if (myIncidentBLL.RequestToAddIncident(myIncident) is true)
                                {
                                    MessageBox.Show("Incident was successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.ClearAll();
                                    cboCustomers.Focus();
                                }
                                    
                                else
                                {
                                    MessageBox.Show("Incident already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            MessageBox.Show("Description is invalid.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Title is invalid.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a product.");
                }
            }
            else
            {
                MessageBox.Show("Please select a customer.");
            }
        }

        private void ClearAll()
        {
            cboCustomers.SelectedIndex = -1;
            cboProducts.SelectedIndex = -1;
            cboTechnicians.SelectedIndex = -1;
            dtpDateOpened.ResetText();
            dtpDateClosed.Checked = false;
            dtpDateClosed.ResetText();
            tbTitle.Clear();
            rtbDescription.Clear();
        }

        private void BtnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ClearAll();
        }
    }
}
