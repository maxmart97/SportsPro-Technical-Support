namespace SportsProUserInterfaceLayer.Forms
{
    partial class FrmAddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblProductName;
            System.Windows.Forms.Label lblReleaseDate;
            System.Windows.Forms.Label lblVersion;
            System.Windows.Forms.Label lblProductCode;
            this.bsProduct = new System.Windows.Forms.BindingSource(this.components);
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.tbVersion = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            this.tbProductCode = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            lblProductName = new System.Windows.Forms.Label();
            lblReleaseDate = new System.Windows.Forms.Label();
            lblVersion = new System.Windows.Forms.Label();
            lblProductCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new System.Drawing.Point(432, 282);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new System.Drawing.Size(102, 17);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "Product Name:";
            // 
            // lblReleaseDate
            // 
            lblReleaseDate.AutoSize = true;
            lblReleaseDate.Location = new System.Drawing.Point(432, 416);
            lblReleaseDate.Name = "lblReleaseDate";
            lblReleaseDate.Size = new System.Drawing.Size(98, 17);
            lblReleaseDate.TabIndex = 3;
            lblReleaseDate.Text = "Release Date:";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new System.Drawing.Point(432, 349);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new System.Drawing.Size(60, 17);
            lblVersion.TabIndex = 5;
            lblVersion.Text = "Version:";
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Location = new System.Drawing.Point(432, 227);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new System.Drawing.Size(98, 17);
            lblProductCode.TabIndex = 86;
            lblProductCode.Text = "Product Code:";
            // 
            // bsProduct
            // 
            this.bsProduct.DataSource = typeof(SportsProUserInterfaceLayer.LINQ_to_SQL.Product);
            // 
            // tbProductName
            // 
            this.tbProductName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduct, "Name", true));
            this.tbProductName.Location = new System.Drawing.Point(551, 279);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(398, 22);
            this.tbProductName.TabIndex = 1;
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProduct, "ReleaseDate", true));
            this.dtpReleaseDate.Location = new System.Drawing.Point(551, 411);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(398, 22);
            this.dtpReleaseDate.TabIndex = 3;
            // 
            // tbVersion
            // 
            this.tbVersion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduct, "Version", true));
            this.tbVersion.Location = new System.Drawing.Point(551, 344);
            this.tbVersion.Name = "tbVersion";
            this.tbVersion.Size = new System.Drawing.Size(398, 22);
            this.tbVersion.TabIndex = 2;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(551, 502);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(294, 65);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnToMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(1272, 637);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(162, 47);
            this.btnReturnToMainMenu.TabIndex = 5;
            this.btnReturnToMainMenu.Text = "Return to Main Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.BtnReturnToMainMenu_Click);
            // 
            // tbProductCode
            // 
            this.tbProductCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduct, "ProductCode", true));
            this.tbProductCode.Location = new System.Drawing.Point(551, 224);
            this.tbProductCode.Name = "tbProductCode";
            this.tbProductCode.Size = new System.Drawing.Size(398, 22);
            this.tbProductCode.TabIndex = 0;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(396, 132);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(617, 17);
            this.lblInstructions.TabIndex = 87;
            this.lblInstructions.Text = "Enter data in the textboxes below. Select a release date from the date picker. Cl" +
    "ick \'Add Product.\'";
            // 
            // FrmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 696);
            this.ControlBox = false;
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(lblProductCode);
            this.Controls.Add(this.tbProductCode);
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(lblVersion);
            this.Controls.Add(this.tbVersion);
            this.Controls.Add(lblReleaseDate);
            this.Controls.Add(this.dtpReleaseDate);
            this.Controls.Add(lblProductName);
            this.Controls.Add(this.tbProductName);
            this.Name = "FrmAddProduct";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.bsProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsProduct;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.TextBox tbVersion;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnReturnToMainMenu;
        private System.Windows.Forms.TextBox tbProductCode;
        private System.Windows.Forms.Label lblInstructions;
    }
}