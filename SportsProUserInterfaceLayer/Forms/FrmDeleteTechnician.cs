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
    public partial class FrmDeleteTechnician : Form
    {
        TechSupportDB_LINQ2SQLDataContext dc = new TechSupportDB_LINQ2SQLDataContext();
        List<Technician> lstTechnicians = new List<Technician>();

        public FrmDeleteTechnician()
        {
            InitializeComponent();
        }

        private void FrmDeleteTechnician_Load(object sender, EventArgs e)
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

        private void LbTechnicians_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTechnicians.Focused && lbTechnicians.Items.Count >= 1 && lbTechnicians.SelectedItem != null)
            {
                Technician myTechnician = lstTechnicians[lbTechnicians.SelectedIndex];

                lblName.Text = myTechnician.Name;
                lblEmail.Text = myTechnician.Email;
                lblPhone.Text = myTechnician.Phone;
            }
        }

        private void BtnDeleteTechnician_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbTechnicians.SelectedIndex != -1)
                {
                    if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete " + lblName.Text + "?", "Delete?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        TechnicianBLL myTechnicianBLL = new TechnicianBLL();

                        if (myTechnicianBLL.RequestToDeleteTechnician((int)lbTechnicians.SelectedValue) is true)
                        {
                            MessageBox.Show("The technician has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.LoadTechnicians();
                            this.ClearAll();
                        }
                        else
                        {
                            MessageBox.Show("Registration deletion unsuccessful.", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Deletion canceled.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a Technician.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch
            {
                MessageBox.Show("Error accessing database. Please contact software developer.", "Database Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearAll()
        {
            lbTechnicians.SelectedIndex = -1;
            lblName.ResetText();
            lblEmail.ResetText();
            lblPhone.ResetText();
        }
    }
}
