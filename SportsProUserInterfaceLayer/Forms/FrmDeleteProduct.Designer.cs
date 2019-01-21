namespace SportsProUserInterfaceLayer.Forms
{
    partial class FrmDeleteProduct
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
            System.Windows.Forms.Label lblProdCodeOutputDesc;
            System.Windows.Forms.Label lblNameOutputDesc;
            System.Windows.Forms.Label lblVersionOutputDesc;
            System.Windows.Forms.Label lblReleaseDateOutputDesc;
            this.lblInstructions = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsProduct = new System.Windows.Forms.BindingSource(this.components);
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            lblProdCodeOutputDesc = new System.Windows.Forms.Label();
            lblNameOutputDesc = new System.Windows.Forms.Label();
            lblVersionOutputDesc = new System.Windows.Forms.Label();
            lblReleaseDateOutputDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProdCodeOutputDesc
            // 
            lblProdCodeOutputDesc.AutoSize = true;
            lblProdCodeOutputDesc.Location = new System.Drawing.Point(303, 396);
            lblProdCodeOutputDesc.Name = "lblProdCodeOutputDesc";
            lblProdCodeOutputDesc.Size = new System.Drawing.Size(98, 17);
            lblProdCodeOutputDesc.TabIndex = 98;
            lblProdCodeOutputDesc.Text = "Product Code:";
            // 
            // lblNameOutputDesc
            // 
            lblNameOutputDesc.AutoSize = true;
            lblNameOutputDesc.Location = new System.Drawing.Point(616, 396);
            lblNameOutputDesc.Name = "lblNameOutputDesc";
            lblNameOutputDesc.Size = new System.Drawing.Size(49, 17);
            lblNameOutputDesc.TabIndex = 89;
            lblNameOutputDesc.Text = "Name:";
            // 
            // lblVersionOutputDesc
            // 
            lblVersionOutputDesc.AutoSize = true;
            lblVersionOutputDesc.Location = new System.Drawing.Point(303, 490);
            lblVersionOutputDesc.Name = "lblVersionOutputDesc";
            lblVersionOutputDesc.Size = new System.Drawing.Size(60, 17);
            lblVersionOutputDesc.TabIndex = 88;
            lblVersionOutputDesc.Text = "Version:";
            // 
            // lblReleaseDateOutputDesc
            // 
            lblReleaseDateOutputDesc.AutoSize = true;
            lblReleaseDateOutputDesc.Location = new System.Drawing.Point(616, 490);
            lblReleaseDateOutputDesc.Name = "lblReleaseDateOutputDesc";
            lblReleaseDateOutputDesc.Size = new System.Drawing.Size(98, 17);
            lblReleaseDateOutputDesc.TabIndex = 103;
            lblReleaseDateOutputDesc.Text = "Release Date:";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(582, 44);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(278, 17);
            this.lblInstructions.TabIndex = 101;
            this.lblInstructions.Text = "Select a product and click \'Delete Product.\'";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productCodeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.releaseDateDataGridViewTextBoxColumn});
            this.dgvProducts.DataSource = this.bsProduct;
            this.dgvProducts.Location = new System.Drawing.Point(12, 92);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1424, 263);
            this.dgvProducts.TabIndex = 100;
            this.dgvProducts.SelectionChanged += new System.EventHandler(this.DgvProducts_SelectionChanged);
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.HeaderText = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            this.productCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // versionDataGridViewTextBoxColumn
            // 
            this.versionDataGridViewTextBoxColumn.DataPropertyName = "Version";
            this.versionDataGridViewTextBoxColumn.HeaderText = "Version";
            this.versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
            this.versionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // releaseDateDataGridViewTextBoxColumn
            // 
            this.releaseDateDataGridViewTextBoxColumn.DataPropertyName = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.HeaderText = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.Name = "releaseDateDataGridViewTextBoxColumn";
            this.releaseDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsProduct
            // 
            this.bsProduct.DataSource = typeof(SportsProUserInterfaceLayer.LINQ_to_SQL.Product);
            // 
            // lblProductCode
            // 
            this.lblProductCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProductCode.Location = new System.Drawing.Point(407, 396);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(158, 31);
            this.lblProductCode.TabIndex = 99;
            this.lblProductCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Location = new System.Drawing.Point(738, 396);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(416, 31);
            this.lblName.TabIndex = 97;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVersion
            // 
            this.lblVersion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVersion.Location = new System.Drawing.Point(407, 490);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(158, 31);
            this.lblVersion.TabIndex = 96;
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(585, 582);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(294, 65);
            this.btnDeleteProduct.TabIndex = 91;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.BtnDeleteProduct_Click);
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnToMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(1274, 734);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(162, 47);
            this.btnReturnToMainMenu.TabIndex = 104;
            this.btnReturnToMainMenu.Text = "Return to Main Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.BtnReturnToMainMenu_Click);
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReleaseDate.Location = new System.Drawing.Point(738, 483);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(416, 31);
            this.lblReleaseDate.TabIndex = 105;
            this.lblReleaseDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmDeleteProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 793);
            this.ControlBox = false;
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Controls.Add(lblReleaseDateOutputDesc);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(lblProdCodeOutputDesc);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(lblNameOutputDesc);
            this.Controls.Add(lblVersionOutputDesc);
            this.Name = "FrmDeleteProduct";
            this.Text = "Delete Product";
            this.Load += new System.EventHandler(this.FrmDeleteProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        public System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsProduct;
        private System.Windows.Forms.Button btnReturnToMainMenu;
        private System.Windows.Forms.Label lblReleaseDate;
    }
}