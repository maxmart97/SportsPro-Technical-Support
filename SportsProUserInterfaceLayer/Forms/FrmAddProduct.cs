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

        }

        private void IsProductDataValid()
        {
            Regex regexProdCode = new Regex(@"^[A-Z]{4,5}[0-9]{2}$");

            if (regexProdCode.IsMatch(tbProductCode.Text))
            {
                if (!string.IsNullOrWhiteSpace(tbProductName.Text) && tbProductName.Text.Length <= 50)
                {
                    if (!string.IsNullOrWhiteSpace(tbVersion.Text) && tbVersion.Text.Length <= 9)
                }
            }
            else
            {
                MessageBox.Show("Product Code is invalid.\nFormat: [A-Z][A-Z][A-Z][A-Z][A-Z][0-9][0-9]")
            }
        }
    }
}
