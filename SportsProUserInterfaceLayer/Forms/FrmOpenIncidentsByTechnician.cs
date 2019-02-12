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

namespace SportsProUserInterfaceLayer
{
    public partial class FrmOpenIncidentsByTechnician : Form
    {
        TechSupportDB_LINQ2SQLDataContext dc = new TechSupportDB_LINQ2SQLDataContext();

        public FrmOpenIncidentsByTechnician()
        {
            InitializeComponent();
        }

        private void FrmOpenIncidentsByTechnician_Load(object sender, EventArgs e)
        {
            var allTechnicians = from technician in dc.Technicians
                                 select technician;

            technicianBindingSource.DataSource = allTechnicians;

            ClearData();
        }

        private void BtnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Resets various controls on form to original state.
            ClearData();
        }

        //Action that occurs when user selects a technician from the CBO.
        private void CboTechnicians_SelectionChangeCommitted(object sender, EventArgs e)
        {
            technicianBindingSource.ResetCurrentItem();

            var openIncidentsForSelectedTechnician = from incident in dc.Incidents
                                                     where incident.DateClosed == null && 
                                                           incident.TechID == (int)cboTechnicians.SelectedValue
                                                     select incident;

            incidentsBindingSource.DataSource = openIncidentsForSelectedTechnician;

            if (openIncidentsForSelectedTechnician.Count() != 0)
                dgvOpenIncidentsByTechnician.DataSource = incidentsBindingSource;
            else
                MessageBox.Show(cboTechnicians.Text + " has no open incidents.");
        }

        private void ClearData()
        {
            cboTechnicians.SelectedIndex = -1;
            lblTechnicianEmail.Text = string.Empty;
            lblTechnicianPhone.Text = string.Empty;
            dgvOpenIncidentsByTechnician.DataSource = null;
        }
    }
}
