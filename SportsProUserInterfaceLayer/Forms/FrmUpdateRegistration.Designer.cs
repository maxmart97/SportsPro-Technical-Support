namespace SportsProUserInterfaceLayer.Forms
{
    partial class FrmUpdateRegistration
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
            System.Windows.Forms.Label lblCustomer;
            System.Windows.Forms.Label lblProduct;
            System.Windows.Forms.Label lblRegistrationDate;
            this.lblInstructions = new System.Windows.Forms.Label();
            this.dgvRegistrations = new System.Windows.Forms.DataGridView();
            this.bsRegistration = new System.Windows.Forms.BindingSource(this.components);
            this.cboCustomers = new System.Windows.Forms.ComboBox();
            this.cboProducts = new System.Windows.Forms.ComboBox();
            this.dtpRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateRegistration = new System.Windows.Forms.Button();
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            this.dgvColCustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColRegDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblCustomer = new System.Windows.Forms.Label();
            lblProduct = new System.Windows.Forms.Label();
            lblRegistrationDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegistration)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new System.Drawing.Point(62, 473);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new System.Drawing.Size(72, 17);
            lblCustomer.TabIndex = 2;
            lblCustomer.Text = "Customer:";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new System.Drawing.Point(520, 473);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new System.Drawing.Size(61, 17);
            lblProduct.TabIndex = 4;
            lblProduct.Text = "Product:";
            // 
            // lblRegistrationDate
            // 
            lblRegistrationDate.AutoSize = true;
            lblRegistrationDate.Location = new System.Drawing.Point(971, 472);
            lblRegistrationDate.Name = "lblRegistrationDate";
            lblRegistrationDate.Size = new System.Drawing.Size(122, 17);
            lblRegistrationDate.TabIndex = 6;
            lblRegistrationDate.Text = "Registration Date:";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(504, 77);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(471, 17);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Select a registration, update data below, and select \'Update Registration.\'";
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
            this.dgvColRegDate});
            this.dgvRegistrations.DataSource = this.bsRegistration;
            this.dgvRegistrations.Location = new System.Drawing.Point(12, 143);
            this.dgvRegistrations.MultiSelect = false;
            this.dgvRegistrations.Name = "dgvRegistrations";
            this.dgvRegistrations.ReadOnly = true;
            this.dgvRegistrations.RowTemplate.Height = 24;
            this.dgvRegistrations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistrations.Size = new System.Drawing.Size(1456, 258);
            this.dgvRegistrations.TabIndex = 2;
            this.dgvRegistrations.SelectionChanged += new System.EventHandler(this.DgvRegistrations_SelectionChanged);
            // 
            // bsRegistration
            // 
            this.bsRegistration.DataSource = typeof(SportsProUserInterfaceLayer.Registration);
            // 
            // cboCustomers
            // 
            this.cboCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomers.Enabled = false;
            this.cboCustomers.FormattingEnabled = true;
            this.cboCustomers.Location = new System.Drawing.Point(140, 470);
            this.cboCustomers.Name = "cboCustomers";
            this.cboCustomers.Size = new System.Drawing.Size(330, 24);
            this.cboCustomers.TabIndex = 3;
            // 
            // cboProducts
            // 
            this.cboProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducts.Enabled = false;
            this.cboProducts.FormattingEnabled = true;
            this.cboProducts.Location = new System.Drawing.Point(587, 470);
            this.cboProducts.Name = "cboProducts";
            this.cboProducts.Size = new System.Drawing.Size(321, 24);
            this.cboProducts.TabIndex = 5;
            // 
            // dtpRegistrationDate
            // 
            this.dtpRegistrationDate.Enabled = false;
            this.dtpRegistrationDate.Location = new System.Drawing.Point(1099, 468);
            this.dtpRegistrationDate.Name = "dtpRegistrationDate";
            this.dtpRegistrationDate.Size = new System.Drawing.Size(310, 22);
            this.dtpRegistrationDate.TabIndex = 7;
            // 
            // btnUpdateRegistration
            // 
            this.btnUpdateRegistration.Enabled = false;
            this.btnUpdateRegistration.Location = new System.Drawing.Point(592, 561);
            this.btnUpdateRegistration.Name = "btnUpdateRegistration";
            this.btnUpdateRegistration.Size = new System.Drawing.Size(294, 65);
            this.btnUpdateRegistration.TabIndex = 92;
            this.btnUpdateRegistration.Text = "Update Registration";
            this.btnUpdateRegistration.UseVisualStyleBackColor = true;
            this.btnUpdateRegistration.Click += new System.EventHandler(this.BtnUpdateRegistration_Click);
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnToMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(1306, 742);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(162, 47);
            this.btnReturnToMainMenu.TabIndex = 105;
            this.btnReturnToMainMenu.Text = "Return to Main Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = true;
            // 
            // dgvColCustName
            // 
            this.dgvColCustName.DataPropertyName = "CustomerName";
            this.dgvColCustName.HeaderText = "CustomerName";
            this.dgvColCustName.Name = "dgvColCustName";
            this.dgvColCustName.ReadOnly = true;
            // 
            // dgvColProductName
            // 
            this.dgvColProductName.DataPropertyName = "ProductName";
            this.dgvColProductName.HeaderText = "ProductName";
            this.dgvColProductName.Name = "dgvColProductName";
            this.dgvColProductName.ReadOnly = true;
            // 
            // dgvColRegDate
            // 
            this.dgvColRegDate.DataPropertyName = "RegistrationDate";
            this.dgvColRegDate.HeaderText = "RegistrationDate";
            this.dgvColRegDate.Name = "dgvColRegDate";
            this.dgvColRegDate.ReadOnly = true;
            // 
            // FrmUpdateRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 801);
            this.ControlBox = false;
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Controls.Add(this.btnUpdateRegistration);
            this.Controls.Add(lblRegistrationDate);
            this.Controls.Add(this.dtpRegistrationDate);
            this.Controls.Add(lblProduct);
            this.Controls.Add(this.cboProducts);
            this.Controls.Add(lblCustomer);
            this.Controls.Add(this.cboCustomers);
            this.Controls.Add(this.dgvRegistrations);
            this.Controls.Add(this.lblInstructions);
            this.Name = "FrmUpdateRegistration";
            this.Text = "Update Registration";
            this.Load += new System.EventHandler(this.FrmUpdateRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegistration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.BindingSource bsRegistration;
        private System.Windows.Forms.DataGridView dgvRegistrations;
        private System.Windows.Forms.ComboBox cboCustomers;
        private System.Windows.Forms.ComboBox cboProducts;
        private System.Windows.Forms.DateTimePicker dtpRegistrationDate;
        private System.Windows.Forms.Button btnUpdateRegistration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductName;
        private System.Windows.Forms.Button btnReturnToMainMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColRegDate;
    }
}