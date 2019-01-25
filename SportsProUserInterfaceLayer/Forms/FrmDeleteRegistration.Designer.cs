namespace SportsProUserInterfaceLayer.Forms
{
    partial class FrmDeleteRegistration
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
            System.Windows.Forms.Label lblCustomerOutputDesc;
            System.Windows.Forms.Label lblProductOutputDesc;
            System.Windows.Forms.Label lblRegDateOutputDesc;
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.dgvRegistrations = new System.Windows.Forms.DataGridView();
            this.bsRegistration = new System.Windows.Forms.BindingSource(this.components);
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblRegDate = new System.Windows.Forms.Label();
            this.btnDeleteRegistration = new System.Windows.Forms.Button();
            this.dgvColCustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColRegistrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblCustomerOutputDesc = new System.Windows.Forms.Label();
            lblProductOutputDesc = new System.Windows.Forms.Label();
            lblRegDateOutputDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegistration)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerOutputDesc
            // 
            lblCustomerOutputDesc.AutoSize = true;
            lblCustomerOutputDesc.Location = new System.Drawing.Point(49, 438);
            lblCustomerOutputDesc.Name = "lblCustomerOutputDesc";
            lblCustomerOutputDesc.Size = new System.Drawing.Size(72, 17);
            lblCustomerOutputDesc.TabIndex = 111;
            lblCustomerOutputDesc.Text = "Customer:";
            // 
            // lblProductOutputDesc
            // 
            lblProductOutputDesc.AutoSize = true;
            lblProductOutputDesc.Location = new System.Drawing.Point(507, 438);
            lblProductOutputDesc.Name = "lblProductOutputDesc";
            lblProductOutputDesc.Size = new System.Drawing.Size(61, 17);
            lblProductOutputDesc.TabIndex = 109;
            lblProductOutputDesc.Text = "Product:";
            // 
            // lblRegDateOutputDesc
            // 
            lblRegDateOutputDesc.AutoSize = true;
            lblRegDateOutputDesc.Location = new System.Drawing.Point(945, 438);
            lblRegDateOutputDesc.Name = "lblRegDateOutputDesc";
            lblRegDateOutputDesc.Size = new System.Drawing.Size(122, 17);
            lblRegDateOutputDesc.TabIndex = 113;
            lblRegDateOutputDesc.Text = "Registration Date:";
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnToMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(1306, 742);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(162, 47);
            this.btnReturnToMainMenu.TabIndex = 106;
            this.btnReturnToMainMenu.Text = "Return to Main Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.BtnReturnToMainMenu_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(557, 71);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(360, 17);
            this.lblInstructions.TabIndex = 107;
            this.lblInstructions.Text = "Select a registration and then click \'Delete Registration.\'";
            // 
            // dgvRegistrations
            // 
            this.dgvRegistrations.AllowUserToAddRows = false;
            this.dgvRegistrations.AllowUserToDeleteRows = false;
            this.dgvRegistrations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegistrations.AutoGenerateColumns = false;
            this.dgvRegistrations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColCustName,
            this.dgvColProductName,
            this.dgvColRegistrationDate});
            this.dgvRegistrations.DataSource = this.bsRegistration;
            this.dgvRegistrations.Location = new System.Drawing.Point(12, 141);
            this.dgvRegistrations.MultiSelect = false;
            this.dgvRegistrations.Name = "dgvRegistrations";
            this.dgvRegistrations.ReadOnly = true;
            this.dgvRegistrations.RowTemplate.Height = 24;
            this.dgvRegistrations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistrations.Size = new System.Drawing.Size(1456, 258);
            this.dgvRegistrations.TabIndex = 108;
            this.dgvRegistrations.SelectionChanged += new System.EventHandler(this.DgvRegistrations_SelectionChanged);
            // 
            // bsRegistration
            // 
            this.bsRegistration.DataSource = typeof(SportsProUserInterfaceLayer.LINQ_to_SQL.Registration);
            // 
            // lblCustomer
            // 
            this.lblCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomer.Enabled = false;
            this.lblCustomer.Location = new System.Drawing.Point(127, 438);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(330, 31);
            this.lblCustomer.TabIndex = 112;
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProduct
            // 
            this.lblProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProduct.Enabled = false;
            this.lblProduct.Location = new System.Drawing.Point(570, 438);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(330, 31);
            this.lblProduct.TabIndex = 110;
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRegDate
            // 
            this.lblRegDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRegDate.Enabled = false;
            this.lblRegDate.Location = new System.Drawing.Point(1073, 438);
            this.lblRegDate.Name = "lblRegDate";
            this.lblRegDate.Size = new System.Drawing.Size(330, 31);
            this.lblRegDate.TabIndex = 114;
            this.lblRegDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDeleteRegistration
            // 
            this.btnDeleteRegistration.Enabled = false;
            this.btnDeleteRegistration.Location = new System.Drawing.Point(594, 549);
            this.btnDeleteRegistration.Name = "btnDeleteRegistration";
            this.btnDeleteRegistration.Size = new System.Drawing.Size(294, 65);
            this.btnDeleteRegistration.TabIndex = 115;
            this.btnDeleteRegistration.Text = "Delete Registration";
            this.btnDeleteRegistration.UseVisualStyleBackColor = true;
            this.btnDeleteRegistration.Click += new System.EventHandler(this.BtnDeleteRegistration_Click);
            // 
            // dgvColCustName
            // 
            this.dgvColCustName.DataPropertyName = "CustomerName";
            this.dgvColCustName.HeaderText = "Customer Name";
            this.dgvColCustName.Name = "dgvColCustName";
            this.dgvColCustName.ReadOnly = true;
            // 
            // dgvColProductName
            // 
            this.dgvColProductName.DataPropertyName = "ProductName";
            this.dgvColProductName.HeaderText = "Product Name";
            this.dgvColProductName.Name = "dgvColProductName";
            this.dgvColProductName.ReadOnly = true;
            // 
            // dgvColRegistrationDate
            // 
            this.dgvColRegistrationDate.DataPropertyName = "RegistrationDate";
            this.dgvColRegistrationDate.HeaderText = "Registration Date";
            this.dgvColRegistrationDate.Name = "dgvColRegistrationDate";
            this.dgvColRegistrationDate.ReadOnly = true;
            // 
            // FrmDeleteRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 801);
            this.ControlBox = false;
            this.Controls.Add(this.btnDeleteRegistration);
            this.Controls.Add(this.lblRegDate);
            this.Controls.Add(lblRegDateOutputDesc);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(lblCustomerOutputDesc);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(lblProductOutputDesc);
            this.Controls.Add(this.dgvRegistrations);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Name = "FrmDeleteRegistration";
            this.Text = "Delete Registration";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegistration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnToMainMenu;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.DataGridView dgvRegistrations;
        private System.Windows.Forms.BindingSource bsRegistration;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblRegDate;
        private System.Windows.Forms.Button btnDeleteRegistration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColRegistrationDate;
    }
}