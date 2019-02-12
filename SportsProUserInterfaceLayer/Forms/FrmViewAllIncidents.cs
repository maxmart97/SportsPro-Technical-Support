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
    public partial class FrmViewAllIncidents : Form
    {
        public FrmViewAllIncidents()
        {
            InitializeComponent();
        }

        private void FrmViewAllIncidents_Load(object sender, EventArgs e)
        {
            IncidentBLL bllIncident = new IncidentBLL();
            
            try
            {
                dgvAllIncidents.DataSource = bllIncident.GetAllIncidents();

                dgvAllIncidents.DefaultCellStyle.NullValue = "NULL";
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
        }
    }
}
