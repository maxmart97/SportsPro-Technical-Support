using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SportsProBLLClassLibrary;

namespace SportsProUserInterfaceLayer.Forms
{
    public partial class FrmUpdateProduct : Form
    {
        TechSupportDB_LINQ2SQLDataContext dc = new TechSupportDB_LINQ2SQLDataContext();

        public FrmUpdateProduct()
        {
            InitializeComponent();
        }

        private void FrmUpdateProduct_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadProducts();
                this.ClearAll();
            }
            catch
            {
                MessageBox.Show("Error accessing database. Please contact software developer.", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadProducts()
        {
            dc.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, dc.Products);

            var products = (from product in dc.Products
                            select product).ToList();

            bsProduct.DataSource = products;
        }

        private void LbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbName.Focused)
            {
                this.EnableProductControls();

                Product myProduct = (Product)lbName.Items[lbName.SelectedIndex];

                tbProductCode.Text = myProduct.ProductCode;
                tbProductName.Text = myProduct.Name;
                tbVersion.Text = myProduct.Version.ToString();
                dtpReleaseDate.Value = myProduct.ReleaseDate;
            }
        }

        private void BtnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (IsProductDataValid())
            {
                ProductBLL myProductBLL = new ProductBLL();

                try
                {
                    SportsProBLLClassLibrary.Product newProduct = new SportsProBLLClassLibrary.Product
                    {
                        ProductCode = tbProductCode.Text,
                        Name = tbProductName.Text,
                        Version = decimal.Parse(tbVersion.Text),
                        ReleaseDate = dtpReleaseDate.Value
                    };

                    Product oldProduct = (Product)lbName.Items[lbName.SelectedIndex];

                    if (myProductBLL.RequestToUpdateProduct(oldProduct.ProductCode, newProduct) is true)
                    {
                        MessageBox.Show(newProduct.Name + " has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.LoadProducts();
                        this.ClearAll();
                        this.DisableProductControls();
                    }
                    else
                    {
                        MessageBox.Show("Product update unsuccessful.", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Error accessing database. Please contact software developer.", "Database Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsProductDataValid()
        {
            Regex regexProdCode = new Regex(@"^[A-Z]{4,5}[0-9]{2}$");

            if (regexProdCode.IsMatch(tbProductCode.Text))
            {
                if (!string.IsNullOrWhiteSpace(tbProductName.Text) && tbProductName.Text.Length <= 50)
                {
                    Regex regexVersion = new Regex(@"^[0-9]{1,16}.[0-9]{1}$");

                    if (regexVersion.IsMatch(tbVersion.Text))
                    {
                        if (dtpReleaseDate.Value >= DateTime.Today)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Release date must be today's date or in the future.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Version is invalid.\nFormat: [0-9].[0-9]");
                    }
                }
                else
                {
                    MessageBox.Show("Product Name is invalid.");
                }
            }
            else
            {
                MessageBox.Show("Product Code is invalid.\nFormat: [A-Z][A-Z][A-Z][A-Z]([A-Z])[0-9][0-9]\nExample: LEAG10");
            }

            return false;
        }

        public void ClearAll()
        {
            lbName.SelectedIndex = -1;
            tbProductCode.ResetText();
            tbProductName.ResetText();
            tbVersion.ResetText();
            dtpReleaseDate.ResetText();
        }

        private void EnableProductControls()
        {
            tbProductCode.Enabled = true;
            tbProductName.Enabled = true;
            tbVersion.Enabled = true;
            dtpReleaseDate.Enabled = true;
            btnUpdateProduct.Enabled = true;
        }

        private void DisableProductControls()
        {
            tbProductCode.Enabled = false;
            tbProductName.Enabled = false;
            tbVersion.Enabled = false;
            dtpReleaseDate.Enabled = false;
            btnUpdateProduct.Enabled = false;
        }

        private void BtnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ClearAll();
            this.DisableProductControls();
        }
    }
}
