namespace SportsProUserInterfaceLayer.Forms
{
    partial class FrmUpdateProduct
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
            System.Windows.Forms.Label lblProductCode;
            System.Windows.Forms.Label lblVersion;
            System.Windows.Forms.Label lblReleaseDate;
            System.Windows.Forms.Label lblProductName;
            this.bsProduct = new System.Windows.Forms.BindingSource(this.components);
            this.lbName = new System.Windows.Forms.ListBox();
            this.tbProductCode = new System.Windows.Forms.TextBox();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.tbVersion = new System.Windows.Forms.TextBox();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.grpProducts = new System.Windows.Forms.GroupBox();
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            lblProductCode = new System.Windows.Forms.Label();
            lblVersion = new System.Windows.Forms.Label();
            lblReleaseDate = new System.Windows.Forms.Label();
            lblProductName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduct)).BeginInit();
            this.grpProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Location = new System.Drawing.Point(652, 232);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new System.Drawing.Size(98, 17);
            lblProductCode.TabIndex = 95;
            lblProductCode.Text = "Product Code:";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new System.Drawing.Point(652, 354);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new System.Drawing.Size(60, 17);
            lblVersion.TabIndex = 94;
            lblVersion.Text = "Version:";
            // 
            // lblReleaseDate
            // 
            lblReleaseDate.AutoSize = true;
            lblReleaseDate.Location = new System.Drawing.Point(652, 421);
            lblReleaseDate.Name = "lblReleaseDate";
            lblReleaseDate.Size = new System.Drawing.Size(98, 17);
            lblReleaseDate.TabIndex = 91;
            lblReleaseDate.Text = "Release Date:";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new System.Drawing.Point(652, 287);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new System.Drawing.Size(102, 17);
            lblProductName.TabIndex = 88;
            lblProductName.Text = "Product Name:";
            // 
            // bsProduct
            // 
            this.bsProduct.DataSource = typeof(SportsProUserInterfaceLayer.LINQ_to_SQL.Product);
            // 
            // lbName
            // 
            this.lbName.DataSource = this.bsProduct;
            this.lbName.DisplayMember = "Name";
            this.lbName.FormattingEnabled = true;
            this.lbName.ItemHeight = 16;
            this.lbName.Location = new System.Drawing.Point(6, 21);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(340, 116);
            this.lbName.TabIndex = 2;
            this.lbName.ValueMember = "ProductCode";
            this.lbName.SelectedIndexChanged += new System.EventHandler(this.LbName_SelectedIndexChanged);
            // 
            // tbProductCode
            // 
            this.tbProductCode.Enabled = false;
            this.tbProductCode.Location = new System.Drawing.Point(771, 229);
            this.tbProductCode.Name = "tbProductCode";
            this.tbProductCode.Size = new System.Drawing.Size(398, 22);
            this.tbProductCode.TabIndex = 87;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Enabled = false;
            this.btnUpdateProduct.Location = new System.Drawing.Point(551, 526);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(294, 65);
            this.btnUpdateProduct.TabIndex = 93;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.BtnUpdateProduct_Click);
            // 
            // tbVersion
            // 
            this.tbVersion.Enabled = false;
            this.tbVersion.Location = new System.Drawing.Point(771, 349);
            this.tbVersion.Name = "tbVersion";
            this.tbVersion.Size = new System.Drawing.Size(398, 22);
            this.tbVersion.TabIndex = 90;
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.Enabled = false;
            this.dtpReleaseDate.Location = new System.Drawing.Point(771, 416);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(398, 22);
            this.dtpReleaseDate.TabIndex = 92;
            // 
            // tbProductName
            // 
            this.tbProductName.Enabled = false;
            this.tbProductName.Location = new System.Drawing.Point(771, 284);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(398, 22);
            this.tbProductName.TabIndex = 89;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(483, 131);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(489, 17);
            this.lblInstructions.TabIndex = 96;
            this.lblInstructions.Text = "Select a product. Update data in the textboxes below. Click \'Update Product.\'";
            // 
            // grpProducts
            // 
            this.grpProducts.Controls.Add(this.lbName);
            this.grpProducts.Location = new System.Drawing.Point(259, 232);
            this.grpProducts.Name = "grpProducts";
            this.grpProducts.Size = new System.Drawing.Size(352, 143);
            this.grpProducts.TabIndex = 97;
            this.grpProducts.TabStop = false;
            this.grpProducts.Text = "Products";
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnToMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(1282, 742);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(162, 47);
            this.btnReturnToMainMenu.TabIndex = 98;
            this.btnReturnToMainMenu.Text = "Return to Main Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.BtnReturnToMainMenu_Click);
            // 
            // FrmUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 801);
            this.ControlBox = false;
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Controls.Add(this.grpProducts);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(lblProductCode);
            this.Controls.Add(this.tbProductCode);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(lblVersion);
            this.Controls.Add(this.tbVersion);
            this.Controls.Add(lblReleaseDate);
            this.Controls.Add(this.dtpReleaseDate);
            this.Controls.Add(lblProductName);
            this.Controls.Add(this.tbProductName);
            this.Name = "FrmUpdateProduct";
            this.Text = "Update Product";
            this.Load += new System.EventHandler(this.FrmUpdateProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsProduct)).EndInit();
            this.grpProducts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsProduct;
        private System.Windows.Forms.ListBox lbName;
        private System.Windows.Forms.TextBox tbProductCode;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.TextBox tbVersion;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.GroupBox grpProducts;
        private System.Windows.Forms.Button btnReturnToMainMenu;
    }
}