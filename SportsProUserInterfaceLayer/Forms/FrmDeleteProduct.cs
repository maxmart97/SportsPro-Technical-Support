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

namespace SportsProUserInterfaceLayer.Forms
{
    public partial class FrmDeleteProduct : Form
    {
        TechSupportDB_LINQ2SQLDataContext dc = new TechSupportDB_LINQ2SQLDataContext();

        public FrmDeleteProduct()
        {
            InitializeComponent();
        }

        private void FrmDeleteProduct_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadIncidents();
            }
            catch
            {
                MessageBox.Show("Error accessing database. Please contact software developer.", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadIncidents()
        {
            dc.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, dc.Products);

            var products = (from product in dc.Products
                             select product).ToList();

            bsProduct.DataSource = products;
        }

        private void DgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.Focused && dgvProducts.SelectedRows.Count == 1)
            {
                var productInformation = (from product in dc.Products
                                           where product.ProductCode == dgvProducts.SelectedCells[0].Value.ToString()
                                           select product).Single();

                lblProductCode.Text = dgvProducts.SelectedCells[0].Value.ToString();
                lblName.Text = dgvProducts.SelectedCells[1].Value.ToString();
                lblVersion.Text = dgvProducts.SelectedCells[2].Value.ToString();
                lblReleaseDate.Text = dgvProducts.SelectedCells[3].Value.ToString();
            }
        }

        public void ClearAll()
        {
            dgvProducts.ClearSelection();
            lblProductCode.ResetText();
            lblName.ResetText();
            lblVersion.ResetText();
            lblReleaseDate.ResetText();
        }

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DialogResult userChoice = MessageBox.Show("Are you sure you want to delete " + lblName.Text + "?",
                    "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (userChoice == DialogResult.Yes)
                {
                    try
                    {
                        ProductBLL myProductBLL = new ProductBLL();

                        if (myProductBLL.RequestToDeleteProduct(dgvProducts.SelectedCells[0].Value.ToString()) is true)
                        {
                            MessageBox.Show(lblName.Text + " has been successfully deleted.", "Deletion successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.LoadIncidents();
                            this.ClearAll();
                        }
                        else
                        {
                            MessageBox.Show(lblName.Text + " could not be deleted.", "Deletion unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error accessing database. Please contact software developer.", "Database Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Deletion canceled.");
                }
            }
            else
            {
                MessageBox.Show("Please select an incident.");
            }
        }

        private void BtnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ClearAll();
        }
    }
}
