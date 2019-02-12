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
    public partial class FrmDeleteIncident : Form
    {
        TechSupportDB_LINQ2SQLDataContext dc = new TechSupportDB_LINQ2SQLDataContext();

        public FrmDeleteIncident()
        {
            InitializeComponent();
        }

        private void FrmDeleteIncident_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadIncidents();
            }
            catch
            {
                MessageBox.Show("Error accessing database. Please contact software developer.", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadIncidents()
        {
            dc.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, dc.Incidents);

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
            if (dgvIncidents.Focused && dgvIncidents.SelectedRows.Count == 1)
            {
                var incidentInformation = (from incident in dc.Incidents
                                           where incident.IncidentID == (int)dgvIncidents.SelectedCells[0].Value
                                           select incident).Single();

                lblIncidentID.Text = incidentInformation.IncidentID.ToString();
                lblCustomer.Text = incidentInformation.Customer.Name;
                lblProduct.Text = incidentInformation.Product.Name;
                lblTitle.Text = incidentInformation.Title;
                lblDateOpened.Text = incidentInformation.DateOpened.ToShortDateString();

                if (incidentInformation.DateClosed.HasValue)
                {
                    lblDateClosed.Text = ((DateTime)incidentInformation.DateClosed).ToShortDateString();
                }
                else
                {
                    lblDateClosed.Text = string.Empty;
                }

                lblDescription.Text = incidentInformation.Description;
            }
        }

        public void ClearAll()
        {
            dgvIncidents.ClearSelection();
            lblIncidentID.ResetText();
            lblCustomer.ResetText();
            lblProduct.ResetText();
            lblTitle.ResetText();
            lblDateOpened.ResetText();
            lblDateClosed.ResetText();
            lblDescription.ResetText();
        }

        private void BtnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ClearAll();
        }

        private void BtnDeleteIncident_Click(object sender, EventArgs e)
        {
            if (dgvIncidents.SelectedRows.Count > 0)
            {
                DialogResult userChoice = MessageBox.Show("Are you sure you want to delete Incident " + lblIncidentID.Text + "?",
                    "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (userChoice == DialogResult.Yes)
                {
                    try
                    {
                        IncidentBLL myIncidentBLL = new IncidentBLL();

                        if (myIncidentBLL.RequestToDeleteIncident((int)dgvIncidents.SelectedCells[0].Value) is true)
                        {
                            MessageBox.Show("Incident " + lblIncidentID.Text + " has been successfully deleted.", "Deletion successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.LoadIncidents();
                            this.ClearAll();
                        }
                        else
                        {
                            MessageBox.Show("Incident " + lblIncidentID.Text + " could not be deleted.", "Deletion unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Deletion canceled.");
                }
            }
            else
            {
                MessageBox.Show("Please select an incident.");
            }
        }
    }
}
