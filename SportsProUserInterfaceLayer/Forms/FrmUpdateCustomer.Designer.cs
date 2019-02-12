namespace SportsProUserInterfaceLayer.Forms
{
    partial class FrmUpdateCustomer
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
            System.Windows.Forms.Label lblZipCode;
            System.Windows.Forms.Label lblCity;
            System.Windows.Forms.Label lblState;
            System.Windows.Forms.Label lblAddress;
            System.Windows.Forms.Label lblEmail;
            System.Windows.Forms.Label lblName;
            System.Windows.Forms.Label lblPhone;
            this.lblInstructions = new System.Windows.Forms.Label();
            this.bsCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.lbCustomers = new System.Windows.Forms.ListBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.bsState = new System.Windows.Forms.BindingSource(this.components);
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            lblZipCode = new System.Windows.Forms.Label();
            lblCity = new System.Windows.Forms.Label();
            lblState = new System.Windows.Forms.Label();
            lblAddress = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            lblPhone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsState)).BeginInit();
            this.SuspendLayout();
            // 
            // lblZipCode
            // 
            lblZipCode.AutoSize = true;
            lblZipCode.Location = new System.Drawing.Point(992, 410);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new System.Drawing.Size(74, 17);
            lblZipCode.TabIndex = 38;
            lblZipCode.Text = "*Zip Code:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new System.Drawing.Point(667, 410);
            lblCity.Name = "lblCity";
            lblCity.Size = new System.Drawing.Size(40, 17);
            lblCity.TabIndex = 37;
            lblCity.Text = "*City:";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Location = new System.Drawing.Point(320, 410);
            lblState.Name = "lblState";
            lblState.Size = new System.Drawing.Size(50, 17);
            lblState.TabIndex = 36;
            lblState.Text = "*State:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new System.Drawing.Point(320, 341);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new System.Drawing.Size(69, 17);
            lblAddress.TabIndex = 26;
            lblAddress.Text = "*Address:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(667, 482);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(46, 17);
            lblEmail.TabIndex = 33;
            lblEmail.Text = "Email:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(320, 286);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(54, 17);
            lblName.TabIndex = 34;
            lblName.Text = "*Name:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new System.Drawing.Point(320, 482);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new System.Drawing.Size(53, 17);
            lblPhone.TabIndex = 35;
            lblPhone.Text = "Phone:";
            // 
            // lblInstructions
            // 
            this.lblInstructions.Location = new System.Drawing.Point(461, 115);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(189, 79);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Select a Customer and then modify his or her information in the textboxes.";
            // 
            // bsCustomer
            // 
            this.bsCustomer.DataSource = typeof(SportsProBLLClassLibrary.Customer);
            // 
            // lbCustomers
            // 
            this.lbCustomers.DataSource = this.bsCustomer;
            this.lbCustomers.DisplayMember = "Name";
            this.lbCustomers.FormattingEnabled = true;
            this.lbCustomers.ItemHeight = 16;
            this.lbCustomers.Location = new System.Drawing.Point(675, 24);
            this.lbCustomers.Name = "lbCustomers";
            this.lbCustomers.Size = new System.Drawing.Size(251, 212);
            this.lbCustomers.TabIndex = 3;
            this.lbCustomers.ValueMember = "CustomerID";
            this.lbCustomers.SelectedIndexChanged += new System.EventHandler(this.LbName_SelectedIndexChanged);
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(1079, 407);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(100, 22);
            this.txtZipCode.TabIndex = 30;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(724, 405);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(220, 22);
            this.txtCity.TabIndex = 29;
            // 
            // cboState
            // 
            this.cboState.DataSource = this.bsState;
            this.cboState.DisplayMember = "StateName";
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(403, 403);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(220, 24);
            this.cboState.TabIndex = 28;
            this.cboState.ValueMember = "StateCode";
            // 
            // bsState
            // 
            this.bsState.DataSource = typeof(SportsProUserInterfaceLayer.LINQ_to_SQL.State);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(403, 338);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(337, 22);
            this.txtAddress.TabIndex = 27;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(724, 479);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(352, 22);
            this.txtEmail.TabIndex = 32;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(403, 283);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(337, 22);
            this.txtName.TabIndex = 25;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(403, 479);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(220, 22);
            this.txtPhone.TabIndex = 31;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(586, 571);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(294, 65);
            this.btnUpdateCustomer.TabIndex = 39;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.BtnUpdateCustomer_Click);
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnToMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(1266, 726);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(162, 47);
            this.btnReturnToMainMenu.TabIndex = 40;
            this.btnReturnToMainMenu.Text = "Return to Main Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.BtnReturnToMainMenu_Click);
            // 
            // FrmUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 785);
            this.ControlBox = false;
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(lblZipCode);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(lblState);
            this.Controls.Add(this.cboState);
            this.Controls.Add(lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lbCustomers);
            this.Controls.Add(this.lblInstructions);
            this.Name = "FrmUpdateCustomer";
            this.Text = "Update Customer";
            this.Load += new System.EventHandler(this.FrmUpdateCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.BindingSource bsCustomer;
        private System.Windows.Forms.ListBox lbCustomers;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnReturnToMainMenu;
        private System.Windows.Forms.BindingSource bsState;
    }
}