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
    public partial class FrmUpdateIncident : Form
    {
        TechSupportDB_LINQ2SQLDataContext dc = new TechSupportDB_LINQ2SQLDataContext();
        List<SportsProBLLClassLibrary.Incident> lstIncidents = new List<SportsProBLLClassLibrary.Incident>();
        IncidentBLL myIncidentBLL = new IncidentBLL();

        public FrmUpdateIncident()
        {
            InitializeComponent();
        }

        private void FrmUpdateIncident_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadIncidents();
                this.LoadComboBoxes();
            }
            catch
            {
                MessageBox.Show("Error accessing database. Please contact software developer.", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadIncidents()
        {
            var incidents = (from incident in dc.Incidents
                            select new
                            {
                              incident.IncidentID,
                              CustomerName = incident.Customer.Name,
                              ProductName = incident.Product.Name,
                              incident.Title,
                              incident.Description,
                              incident.DateOpened,
                              incident.DateClosed
                            }).ToList();

            bsIncident.DataSource = incidents;
        }

        private void LoadComboBoxes()
        {
            var customers = (from customer in dc.Customers
                             select customer).ToList();

            cboCustomers.DisplayMember = "Name";
            cboCustomers.ValueMember = "CustomerID";
            cboCustomers.DataSource = customers;
            cboCustomers.SelectedIndex = -1;

            var products = (from product in dc.Products
                            select product).ToList();

            cboProducts.DisplayMember = "Name";
            cboProducts.ValueMember = "ProductCode";
            cboProducts.DataSource = products;
            cboProducts.SelectedIndex = -1;

            var technicians = (from technician in dc.Technicians
                               select technician).ToList();

            cboTechnicians.DisplayMember = "Name";
            cboTechnicians.ValueMember = "TechID";
            cboTechnicians.DataSource = technicians;
            cboTechnicians.SelectedIndex = -1;
        }

        private void DgvIncidents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvIncidents.Focused)
            {
                var incidentInformation = (from incident in dc.Incidents
                                           where incident.IncidentID == (int)dgvIncidents.SelectedCells[0].Value
                                           select incident).Single();

                this.EnableIncidentControls();

                cboCustomers.SelectedItem = incidentInformation.Customer;
                cboProducts.SelectedItem = incidentInformation.Product;
                cboTechnicians.SelectedItem = incidentInformation.Technician;
                dtpDateOpened.Value = incidentInformation.DateOpened;

                if (incidentInformation.DateClosed.HasValue)
                {
                    dtpDateClosed.Value = (DateTime)incidentInformation.DateClosed;
                }
                else
                {
                    dtpDateClosed.ResetText();
                    dtpDateClosed.Checked = false;
                }

                tbTitle.Text = incidentInformation.Title;
                rtbDescription.Text = incidentInformation.Description;
            }
        }

        private void EnableIncidentControls()
        {
            cboCustomers.Enabled = true;
            cboProducts.Enabled = true;
            cboTechnicians.Enabled = true;
            dtpDateOpened.Enabled = true;
            dtpDateClosed.Enabled = true;
            tbTitle.Enabled = true;
            rtbDescription.Enabled = true;
        }

        private void DisableIncidentControls()
        {
            cboCustomers.Enabled = false;
            cboProducts.Enabled = false;
            cboTechnicians.Enabled = false;
            dtpDateOpened.Enabled = false;
            dtpDateClosed.Enabled = false;
            tbTitle.Enabled = false;
            rtbDescription.Enabled = false;
        }
        
        private void FrmUpdateIncident_Shown(object sender, EventArgs e)
        {
            dgvIncidents.ClearSelection();
        }

        private void BtnUpdateIncident_Click(object sender, EventArgs e)
        {
            if (IsRequiredIncidentDataValid())
            {
                SportsProBLLClassLibrary.Incident myIncident = new SportsProBLLClassLibrary.Incident
                {
                    IncidentID = (int)dgvIncidents.SelectedCells[0].Value,
                    CustomerID = (int)cboCustomers.SelectedValue,
                    ProductCode = cboProducts.SelectedValue.ToString(),
                    DateOpened = dtpDateOpened.Value,
                    Title = tbTitle.Text,
                    Description = rtbDescription.Text
                };

                if (IsOptionalIncidentDataValid(ref myIncident))
                {
                    try
                    {
                        if (myIncidentBLL.RequestToUpdateIncident(myIncident) is true)
                        {
                            MessageBox.Show("Incident was successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dc.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, dc.Incidents);
                            this.LoadIncidents();
                            this.DisableIncidentControls();
                            this.ClearAll();
                        }
                        else
                        {
                            MessageBox.Show("Update unsuccessful.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error accessing database. Please contact software developer.", "Database Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void ClearAll()
        {
            dgvIncidents.ClearSelection();
            cboCustomers.SelectedIndex = -1;
            cboProducts.SelectedIndex = -1;
            cboTechnicians.SelectedIndex = -1;
            dtpDateOpened.ResetText();
            dtpDateClosed.ResetText();
            tbTitle.ResetText();
            rtbDescription.ResetText();
        }

        private bool IsRequiredIncidentDataValid()
        {
            if (cboCustomers.SelectedIndex != -1)
            {
                if (cboProducts.SelectedIndex != -1)
                {
                    if (dtpDateOpened.Value <= DateTime.Now)
                    {
                        if (!string.IsNullOrWhiteSpace(tbTitle.Text) && tbTitle.Text.Length <= 50)
                        {
                            if (!string.IsNullOrWhiteSpace(rtbDescription.Text) && rtbDescription.Text.Length <= 2000)
                            {
                                return true;
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
                        MessageBox.Show("Date opened cannot be greater than today's date.");
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

            return false;
        }

        private bool IsOptionalIncidentDataValid(ref SportsProBLLClassLibrary.Incident inc)
        {
            if (dtpDateClosed.Checked)
            {
                if (dtpDateClosed.Value <= DateTime.Now && dtpDateClosed.Value >= inc.DateOpened)
                {
                    inc.DateClosed = dtpDateClosed.Value;
                }
                else
                {
                    MessageBox.Show("Date closed cannot be greater than today's date or less than " +
                       "date opened.", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
            else
            {
                inc.DateClosed = null;
            }

            if (cboTechnicians.SelectedIndex == -1)
                inc.TechID = null;
            else
                inc.TechID = (int)cboTechnicians.SelectedValue;

            return true;
        }

        private void BtnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ClearAll();
        }
    }
}
