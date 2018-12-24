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
    }
}
