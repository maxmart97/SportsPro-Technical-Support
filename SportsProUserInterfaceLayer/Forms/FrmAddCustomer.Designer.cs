namespace SportsProUserInterfaceLayer
{
    partial class FrmAddCustomer
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
            System.Windows.Forms.Label lblAddress;
            System.Windows.Forms.Label lblEmail;
            System.Windows.Forms.Label lblName;
            System.Windows.Forms.Label lblPhone;
            System.Windows.Forms.Label lblState;
            System.Windows.Forms.Label lblCity;
            System.Windows.Forms.Label lblZipCode;
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.bsCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.bsState = new System.Windows.Forms.BindingSource(this.components);
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            lblAddress = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            lblPhone = new System.Windows.Forms.Label();
            lblState = new System.Windows.Forms.Label();
            lblCity = new System.Windows.Forms.Label();
            lblZipCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsState)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new System.Drawing.Point(284, 267);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new System.Drawing.Size(69, 17);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "*Address:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(631, 408);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(46, 17);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(284, 212);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(54, 17);
            lblName.TabIndex = 9;
            lblName.Text = "*Name:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new System.Drawing.Point(284, 408);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new System.Drawing.Size(53, 17);
            lblPhone.TabIndex = 11;
            lblPhone.Text = "Phone:";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Location = new System.Drawing.Point(284, 336);
            lblState.Name = "lblState";
            lblState.Size = new System.Drawing.Size(50, 17);
            lblState.TabIndex = 16;
            lblState.Text = "*State:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new System.Drawing.Point(631, 336);
            lblCity.Name = "lblCity";
            lblCity.Size = new System.Drawing.Size(40, 17);
            lblCity.TabIndex = 23;
            lblCity.Text = "*City:";
            // 
            // lblZipCode
            // 
            lblZipCode.AutoSize = true;
            lblZipCode.Location = new System.Drawing.Point(956, 336);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new System.Drawing.Size(74, 17);
            lblZipCode.TabIndex = 24;
            lblZipCode.Text = "*Zip Code:";
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCustomer, "Address", true));
            this.txtAddress.Location = new System.Drawing.Point(367, 264);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(337, 22);
            this.txtAddress.TabIndex = 1;
            // 
            // bsCustomer
            // 
            this.bsCustomer.DataSource = typeof(SportsProUserInterfaceLayer.LINQ_to_SQL.Customer);
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCustomer, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(688, 405);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(352, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCustomer, "Name", true));
            this.txtName.Location = new System.Drawing.Point(367, 209);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(337, 22);
            this.txtName.TabIndex = 0;
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCustomer, "Phone", true));
            this.txtPhone.Location = new System.Drawing.Point(367, 405);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(220, 22);
            this.txtPhone.TabIndex = 5;
            // 
            // cboState
            // 
            this.cboState.DataSource = this.bsState;
            this.cboState.DisplayMember = "StateName";
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(367, 329);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(220, 24);
            this.cboState.TabIndex = 2;
            this.cboState.ValueMember = "StateCode";
            // 
            // bsState
            // 
            this.bsState.DataSource = typeof(SportsProUserInterfaceLayer.LINQ_to_SQL.State);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(424, 126);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(559, 17);
            this.lblInstructions.TabIndex = 20;
            this.lblInstructions.Text = "Enter in values for the customer you want to add. Fields with an asterisk are mandatory.";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(592, 533);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(294, 65);
            this.btnAddCustomer.TabIndex = 7;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnToMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(1258, 718);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(162, 47);
            this.btnReturnToMainMenu.TabIndex = 22;
            this.btnReturnToMainMenu.Text = "Return to Main Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.BtnReturnToMainMenu_Click);
            // 
            // txtCity
            // 
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCustomer, "City", true));
            this.txtCity.Location = new System.Drawing.Point(688, 331);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(220, 22);
            this.txtCity.TabIndex = 3;
            // 
            // txtZipCode
            // 
            this.txtZipCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCustomer, "ZipCode", true));
            this.txtZipCode.Location = new System.Drawing.Point(1043, 333);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(100, 22);
            this.txtZipCode.TabIndex = 4;
            // 
            // FrmAddCustomer
            // 
            this.AcceptButton = this.btnAddCustomer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReturnToMainMenu;
            this.ClientSize = new System.Drawing.Size(1432, 777);
            this.ControlBox = false;
            this.Controls.Add(lblZipCode);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lblInstructions);
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
            this.Name = "FrmAddCustomer";
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.FrmAddCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnReturnToMainMenu;
        private System.Windows.Forms.BindingSource bsCustomer;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.BindingSource bsState;
    }
}