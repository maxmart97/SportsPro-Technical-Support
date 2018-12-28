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
    public partial class FrmAddProduct : Form
    {
        public FrmAddProduct()
        {
            InitializeComponent();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            if (IsProductDataValid())
            {
                ProductBLL myProductBLL = new ProductBLL();

                try
                {
                    SportsProBLLClassLibrary.Product myProduct = new SportsProBLLClassLibrary.Product
                    {
                        ProductCode = tbProductCode.Text,
                        Name = tbProductName.Text,
                        Version = decimal.Parse(tbVersion.Text),
                        ReleaseDate = dtpReleaseDate.Value
                    };
                
                    if (myProductBLL.RequestToAddProduct(myProduct) is true)
                    {
                        MessageBox.Show(myProduct.Name + " has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Product addition unsuccessful.", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        if (dtpReleaseDate.Value >= DateTime.Now)
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

        private void BtnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ClearAll();
        }

        public void ClearAll()
        {
            tbProductCode.Focus();
            tbProductCode.ResetText();
            tbProductName.ResetText();
            tbVersion.ResetText();
            dtpReleaseDate.ResetText();
        }
    }
}
