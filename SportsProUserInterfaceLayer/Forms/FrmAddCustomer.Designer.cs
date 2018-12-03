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
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label lblName;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label stateLabel1;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label zipCodeLabel;
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            this.bsCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.bsState = new System.Windows.Forms.BindingSource(this.components);
            lblAddress = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            stateLabel1 = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            zipCodeLabel = new System.Windows.Forms.Label();
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
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(631, 408);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email:";
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
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(284, 408);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(53, 17);
            phoneLabel.TabIndex = 11;
            phoneLabel.Text = "Phone:";
            // 
            // stateLabel1
            // 
            stateLabel1.AutoSize = true;
            stateLabel1.Location = new System.Drawing.Point(284, 336);
            stateLabel1.Name = "stateLabel1";
            stateLabel1.Size = new System.Drawing.Size(50, 17);
            stateLabel1.TabIndex = 16;
            stateLabel1.Text = "*State:";
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCustomer, "Address", true));
            this.txtAddress.Location = new System.Drawing.Point(367, 264);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(337, 22);
            this.txtAddress.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCustomer, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(688, 405);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(352, 22);
            this.emailTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCustomer, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(367, 209);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(337, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCustomer, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(367, 405);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(220, 22);
            this.phoneTextBox.TabIndex = 5;
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
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(397, 127);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(665, 17);
            this.lblInstructions.TabIndex = 20;
            this.lblInstructions.Text = "Enter in values for the customer you want to add. Fields with an asterisk at the " +
    "beginning are mandatory.";
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
            // 
            // bsCustomer
            // 
            this.bsCustomer.DataSource = typeof(SportsProUserInterfaceLayer.Customer);
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(631, 336);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(40, 17);
            cityLabel.TabIndex = 23;
            cityLabel.Text = "*City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCustomer, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(688, 331);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(220, 22);
            this.cityTextBox.TabIndex = 3;
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new System.Drawing.Point(956, 336);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new System.Drawing.Size(74, 17);
            zipCodeLabel.TabIndex = 24;
            zipCodeLabel.Text = "*Zip Code:";
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCustomer, "ZipCode", true));
            this.zipCodeTextBox.Location = new System.Drawing.Point(1043, 333);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(100, 22);
            this.zipCodeTextBox.TabIndex = 4;
            // 
            // bsState
            // 
            this.bsState.DataSource = typeof(SportsProUserInterfaceLayer.State);
            // 
            // FrmAddCustomer
            // 
            this.AcceptButton = this.btnAddCustomer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReturnToMainMenu;
            this.ClientSize = new System.Drawing.Size(1432, 777);
            this.ControlBox = false;
            this.Controls.Add(zipCodeLabel);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(stateLabel1);
            this.Controls.Add(this.cboState);
            this.Controls.Add(lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(lblName);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
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
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnReturnToMainMenu;
        private System.Windows.Forms.BindingSource bsCustomer;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.BindingSource bsState;
    }
}