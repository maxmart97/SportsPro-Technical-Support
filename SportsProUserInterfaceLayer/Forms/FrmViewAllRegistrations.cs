using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportsProUserInterfaceLayer.LINQ_to_SQL;

namespace SportsProUserInterfaceLayer.Forms
{
    public partial class FrmViewAllRegistrations : Form
    {
        TechSupportDB_LINQ2SQLDataContext dc = new TechSupportDB_LINQ2SQLDataContext();

        public FrmViewAllRegistrations()
        {
            InitializeComponent();
        }

        public void LoadRegistrations()
        {
            dc.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, dc.Registrations);

            var registrations = (from registration in dc.Registrations
                                 select new
                                 {
                                     registration.CustomerID,
                                     registration.ProductCode,
                                     registration.RegistrationDate
                                 }).ToList();

            bsRegistrations.DataSource = registrations;
        }

        private void BtnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
