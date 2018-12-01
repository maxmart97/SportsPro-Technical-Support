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
    public partial class FrmViewIncidentsByTechnician : Form
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

        public FrmViewIncidentsByTechnician()
        {
            InitializeComponent();
        }

        private void BtnGetIncidents_Click(object sender, EventArgs e)
        {
            int techID;

            //Prevents data in DGV from being added on top of each other.
            dgvIncidentsByTechnician.DataSource = null;

            //Checks if Technician ID entered is a valid integer.
            if (int.TryParse(txtInputTechID.Text, out techID))
            {
                List<SportsProBLLClassLibrary.Incident> lstAllIncidentsByTechnician = new List<SportsProBLLClassLibrary.Incident>();
                IncidentBLL bllIncident = new IncidentBLL();

                try
                {
                    lstAllIncidentsByTechnician = bllIncident.GetIncidentsByTechnician(techID);

                    //Checks if the returned list has any Incidents in it.
                    if (lstAllIncidentsByTechnician.Count == 0)
                    {
                        MessageBox.Show("No results found.");
                        txtInputTechID.Focus();
                    }
                    else
                    {
                        dgvIncidentsByTechnician.DataSource = lstAllIncidentsByTechnician;
                        txtInputTechID.Focus();
                    }
                }
                /* Action performed after exception has bubbled up from DAL
                 * when the database is unreachable. */
                catch
                {
                    MessageBox.Show("Error accessing database.");
                }
            }
            else
            {
                MessageBox.Show("Technician ID entered is invalid.");
                txtInputTechID.Focus();
            }
        }

        private void BtnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Resets DataGridView and TextBox to original state.
            dgvIncidentsByTechnician.DataSource = null;
            txtInputTechID.Clear();
        }
    }
}
