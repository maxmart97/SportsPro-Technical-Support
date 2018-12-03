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

namespace SportsProUserInterfaceLayer
{
    public partial class FrmOpenIncidentsByTechnician : Form
    {
        //Variable to reference close button.
        private const int CP_NOCLOSE_BUTTON = 0x200;

        //Property method to disable to close button.
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public FrmOpenIncidentsByTechnician()
        {
            InitializeComponent();
        }

        private void FrmOpenIncidentsByTechnician_Load(object sender, EventArgs e)
        {
            TechnicianBLL myTechnicianBLL = new TechnicianBLL();

            try
            {
                //Sets up technician ComboBox.
                cboTechnicians.DisplayMember = "Name";
                cboTechnicians.ValueMember = "TechID";
                cboTechnicians.DataSource = myTechnicianBLL.GetTechnicianNames();
                cboTechnicians.SelectedIndex = -1;
            }
            /* Action performed after exception has bubbled up from DAL
             * when the database is unreachable. */
            catch
            {
                MessageBox.Show("Error accessing database.");
            }
            
        }

        private void BtnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Resets various controls on form to original state.
            cboTechnicians.SelectedIndex = -1;
            lblTechnicianEmail.Text = string.Empty;
            lblTechnicianPhone.Text = string.Empty;
            dgvOpenIncidentsByTechnician.DataSource = null;
        }

        //Action that occurs when user selects a technician from the CBO.
        private void CboTechnicians_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TechnicianBLL myTechnicianBLL = new TechnicianBLL();
            IncidentBLL myIncidentBLL = new IncidentBLL();
            SportsProBLLClassLibrary.Technician selectedTechnician = new SportsProBLLClassLibrary.Technician();
            List<SportsProBLLClassLibrary.Incident> lstOpenIncidentsByTechnician = new List<SportsProBLLClassLibrary.Incident>();

            //Gets the selected technician.
            int techID = (int)cboTechnicians.SelectedValue;

            /* Prevents data from appearing in DGV from previously selected technician
               if the next technician selected has no open incidents. */
            dgvOpenIncidentsByTechnician.DataSource = null;

            try
            {
                selectedTechnician = myTechnicianBLL.GetTechnicianDetails(techID);

                //Sets the email and phone lables to corresponding technician values.
                lblTechnicianEmail.Text = selectedTechnician.TechEmail;
                lblTechnicianPhone.Text = selectedTechnician.TechPhone;

                lstOpenIncidentsByTechnician = myIncidentBLL.GetOpenIncidentsByTechnician(techID);

                //Checks if the selected technician actually has any open incidents.
                if (lstOpenIncidentsByTechnician.Count == 0)
                {
                    MessageBox.Show("No open incidents for selected technician.");
                    cboTechnicians.Focus();
                }
                else
                {
                    dgvOpenIncidentsByTechnician.DataSource = lstOpenIncidentsByTechnician;
                }
            }
            /* Action performed after exception has bubbled up from DAL
             * when the database is unreachable. */
            catch
            {
                MessageBox.Show("Error accessing database.");
            }
        }
    }
}
