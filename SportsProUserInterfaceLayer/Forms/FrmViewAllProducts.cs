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
    public partial class FrmViewAllProducts : Form
    {
        TechSupportDB_LINQ2SQLDataContext dc = new TechSupportDB_LINQ2SQLDataContext();

        public FrmViewAllProducts()
        {
            InitializeComponent();
        }

        public void LoadProducts()
        {
            dc.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, dc.Products);

            var products = (from product in dc.Products
                            select product).ToList();

            bsProducts.DataSource = products;
        }

        private void BtnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
