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
    public partial class FrmUpdateCustomer : Form
    {
        TechSupportDB_LINQ2SQLDataContext dc = new TechSupportDB_LINQ2SQLDataContext();
        List<SportsProBLLClassLibrary.Customer> lstCustomers = new List<SportsProBLLClassLibrary.Customer>();

        public FrmUpdateCustomer()
        {
            InitializeComponent();
        }

        private void FrmUpdateCustomer_Load(object sender, EventArgs e)
        {
            CustomerBLL myCustomerBLL = new CustomerBLL();

            try
            {
                lstCustomers = myCustomerBLL.GetAllCustomers();
            }
            catch
            {
                MessageBox.Show("Error accessing the database.");
            }

            customerBindingSource.DataSource = lstCustomers;

            var states = from state in dc.States
                         select state;

            stateBindingSource.DataSource = states;

            cboState.SelectedIndex = -1;
        }

        private void LbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbName.Focused)
            {
                var selectedCustomer = (from customer in lstCustomers
                                        where customer.CustomerID == (int)lbName.SelectedValue
                                        select customer).Single();

                int indexOfStateInCBO = 0;
                bool found = false;

                while (found is false)
                {
                    foreach (State state in cboState.Items)
                    {
                        if (state.StateCode == selectedCustomer.State)
                        {
                            indexOfStateInCBO = cboState.Items.IndexOf(state);
                            found = true;
                        }
                    }
                }

                cboState.SelectedIndex = indexOfStateInCBO;
            }
        }
    }
}
