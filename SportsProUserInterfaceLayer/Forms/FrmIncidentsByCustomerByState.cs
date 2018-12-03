using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportsProBLLClassLibrary;

namespace SportsProUserInterfaceLayer
{
    public partial class FrmIncidentsByCustomerByState : Form
    {
        TechSupportDB_LINQ2SQLDataContext dcTechSupportDB = new TechSupportDB_LINQ2SQLDataContext();

        public FrmIncidentsByCustomerByState()
        {
            InitializeComponent();
        }

        private void FrmIncidentsByCustomerByState_Load(object sender, EventArgs e)
        {
            SetupErrorLabels();

            //LINQ query to get all states from the TechSupportDB database.
            var states = from aState in dcTechSupportDB.States
                         orderby aState.StateName
                         select new { aState.StateName, aState.StateCode };

            //Executes query and displays data in states combobox.
            bsState.DataSource = states;

            //Prevents a pre-selected state.
            cboState.SelectedIndex = -1;
        }

        private void CboState_SelectionChangeCommitted(object sender, EventArgs e)
        {
            /* Prevents error label from appearing over a selection with data
             * after a selection contained no data. */
            lblNoResultsFoundCustomer.Hide();

            /* Prevents error label from staying visible in incident DGV when
             * user selects a new state. */
            lblNoResultsFoundIncident.Hide();

            /* Prevents groupbox text from staying as the previous customer selected.
             * Resets the groupbox text to default. */
            grpIncidents.Text = "Incidents";

            //Prevents previous data from stacking on top of each other.
            dgvIncidents.Rows.Clear();

            string selectedState = cboState.SelectedValue.ToString();

            //LINQ query to retrieve all customers in the selected state.
            var customers = from customer in dcTechSupportDB.Customers
                            where customer.State == selectedState
                            orderby customer.Name
                            select customer;

            //Executes query and displays customer(s) data in corresponding DGV.
            bsCustomer.DataSource = customers;

            //Prevents a pre-selected customer in DGV.
            dgvCustomers.ClearSelection();

            GenericMethods.DisplayLabelWhenNoResultsFound(lblNoResultsFoundCustomer, dgvCustomers);
        }

        private void DgvCustomer_SelectionChanged(object sender, EventArgs e)
        {
            /* The DataGridView's SelectionChanged event can fire without having input focus. In that case,
             * I don't want anything to occur. Below makes nothing happen during this event unless the DGV 
             * has the input focus. */
            if (dgvCustomers.Focused)
            {
                /* Prevents error label from appearing over a selection with data
                 * after a selection contained no data. */
                lblNoResultsFoundIncident.Hide();

                //Sets groupbox text to represent selected customer.
                grpIncidents.Text = "Incidents for " + dgvCustomers.SelectedCells[1].Value;

                //LINQ query to get all incidents for the selected customer.
                var incidents = from incident in dcTechSupportDB.Incidents
                                where incident.CustomerID == (int)dgvCustomers.SelectedCells[0].Value
                                select incident;

                //Executes query and displays data in incidents DGV.
                bsIncident.DataSource = incidents;

                //Prevents a pre-selected incident in DGV.
                dgvIncidents.ClearSelection();

                GenericMethods.DisplayLabelWhenNoResultsFound(lblNoResultsFoundIncident, dgvIncidents);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        /// <summary>
        /// Centers a label vertically and horizontally in each DataGridView.
        /// </summary>
        private void SetupErrorLabels()
        {
            lblNoResultsFoundCustomer.Parent = dgvCustomers;
            lblNoResultsFoundIncident.Parent = dgvIncidents;

            Rectangle parentRect1 = lblNoResultsFoundCustomer.Parent.ClientRectangle;
            lblNoResultsFoundCustomer.Left = (parentRect1.Width - lblNoResultsFoundCustomer.Width) / 2;
            lblNoResultsFoundCustomer.Top = (parentRect1.Height - lblNoResultsFoundCustomer.Height) / 2;

            Rectangle parentRect2 = lblNoResultsFoundIncident.Parent.ClientRectangle;
            lblNoResultsFoundIncident.Left = (parentRect2.Width - lblNoResultsFoundIncident.Width) / 2;
            lblNoResultsFoundIncident.Top = (parentRect2.Height - lblNoResultsFoundIncident.Height) / 2;
        }

        private void BtnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
