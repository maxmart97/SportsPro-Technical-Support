using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsProUserInterfaceLayer.Forms
{
    public partial class FrmUpdateTechnician : Form
    {
        TechSupportDB_LINQ2SQLDataContext dc = new TechSupportDB_LINQ2SQLDataContext();
        List<Technician> lstTechnicians = new List<Technician>();

        public FrmUpdateTechnician()
        {
            InitializeComponent();
        }

        private void FrmUpdateTechnician_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadTechnicians();
            }
            catch
            {
                MessageBox.Show("Error accessing database. Please contact software developer.", "Database Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadTechnicians()
        {
            dc.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, dc.Technicians);

            lstTechnicians = (from technician in dc.Technicians
                              select technician).ToList();

            bsTechnicians.DataSource = lstTechnicians;
        }

        public void ClearAll()
        {
            lbTechnicians.SelectedIndex = -1;
            tbName.ResetText();
            tbEmail.ResetText();
            tbPhone.ResetText();
        }

        private void BtnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ClearAll();
        }

        private void LbTechnicians_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTechnicians.Focused && lbTechnicians.Items.Count >= 1)
            {
                Technician myTechnician = lstTechnicians[lbTechnicians.SelectedIndex];
                tbName.Text = myTechnician.Name;
                tbEmail.Text = myTechnician.Email;
                tbPhone.Text = myTechnician.Phone;
            }
            //this.SetTextBoxesWithTechnicianData(lbTechnicians[lbTechnicians.SelectedIndex]);
        }

        private void SetTextBoxesWithTechnicianData(SportsProBLLClassLibrary.Technician tech)
        {
            tbName.Text = tech.Name;
            tbEmail.Text = tech.Email;
            tbPhone.Text = tech.Phone;
        }
    }
}
