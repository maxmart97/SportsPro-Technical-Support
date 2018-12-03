using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsProUserInterfaceLayer
{
    public partial class FrmAddCustomer : Form
    {
        TechSupportDB_LINQ2SQLDataContext dcTechSupportDB = new TechSupportDB_LINQ2SQLDataContext();

        public FrmAddCustomer()
        {
            InitializeComponent();
        }

        private void FrmAddCustomer_Load(object sender, EventArgs e)
        {
            var states = (from state in dcTechSupportDB.States
                          select state).ToList();

            bsState.DataSource = states;

            cboState.SelectedIndex = -1;
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            /* Example of how to insert a customer with LINQ to SQL

                Customer myCustomer = new Customer
                {
                    Name = "Joe Smith",
                    Address = "123 Main Street",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78701",
                    Phone = "(512) 123-4567",
                    Email = "joe.smith@gmail.com"
                };

                dcTechSupportDB.Customers.InsertOnSubmit(myCustomer);

                try
                {
                    dcTechSupportDB.SubmitChanges();
                    MessageBox.Show("Successfully added a customer.");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            */
        }
    }
}
