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
            System.Windows.Forms.Label zipCodeLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel1;
            System.Windows.Forms.Label lblAddress;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label lblName;
            System.Windows.Forms.Label phoneLabel;
            this.lblInstructions = new System.Windows.Forms.Label();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbName = new System.Windows.Forms.ListBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            zipCodeLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel1 = new System.Windows.Forms.Label();
            lblAddress = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new System.Drawing.Point(992, 410);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new System.Drawing.Size(74, 17);
            zipCodeLabel.TabIndex = 38;
            zipCodeLabel.Text = "*Zip Code:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(667, 410);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(40, 17);
            cityLabel.TabIndex = 37;
            cityLabel.Text = "*City:";
            // 
            // stateLabel1
            // 
            stateLabel1.AutoSize = true;
            stateLabel1.Location = new System.Drawing.Point(320, 410);
            stateLabel1.Name = "stateLabel1";
            stateLabel1.Size = new System.Drawing.Size(50, 17);
            stateLabel1.TabIndex = 36;
            stateLabel1.Text = "*State:";
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
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(667, 482);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 33;
            emailLabel.Text = "Email:";
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
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(320, 482);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(53, 17);
            phoneLabel.TabIndex = 35;
            phoneLabel.Text = "Phone:";
            // 
            // lblInstructions
            // 
            this.lblInstructions.Location = new System.Drawing.Point(461, 115);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(170, 79);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Select a Customer and then modify his or her information in the textboxes at the " +
    "bottom.";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(SportsProBLLClassLibrary.Customer);
            // 
            // lbName
            // 
            this.lbName.DataSource = this.customerBindingSource;
            this.lbName.DisplayMember = "Name";
            this.lbName.FormattingEnabled = true;
            this.lbName.ItemHeight = 16;
            this.lbName.Location = new System.Drawing.Point(675, 24);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(251, 212);
            this.lbName.TabIndex = 3;
            this.lbName.ValueMember = "CustomerID";
            this.lbName.SelectedIndexChanged += new System.EventHandler(this.LbName_SelectedIndexChanged);
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "ZipCode", true));
            this.zipCodeTextBox.Location = new System.Drawing.Point(1079, 407);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(100, 22);
            this.zipCodeTextBox.TabIndex = 30;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(724, 405);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(220, 22);
            this.cityTextBox.TabIndex = 29;
            // 
            // cboState
            // 
            this.cboState.DataSource = this.stateBindingSource;
            this.cboState.DisplayMember = "StateName";
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(403, 403);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(220, 24);
            this.cboState.TabIndex = 28;
            this.cboState.ValueMember = "StateCode";
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Address", true));
            this.txtAddress.Location = new System.Drawing.Point(403, 338);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(337, 22);
            this.txtAddress.TabIndex = 27;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(724, 479);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(352, 22);
            this.emailTextBox.TabIndex = 32;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(403, 283);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(337, 22);
            this.nameTextBox.TabIndex = 25;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(403, 479);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(220, 22);
            this.phoneTextBox.TabIndex = 31;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(586, 571);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(294, 65);
            this.btnUpdateCustomer.TabIndex = 39;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
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
            // 
            // stateBindingSource
            // 
            this.stateBindingSource.DataSource = typeof(SportsProUserInterfaceLayer.State);
            // 
            // FrmUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 785);
            this.ControlBox = false;
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(zipCodeLabel);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
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
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lblInstructions);
            this.Name = "FrmUpdateCustomer";
            this.Text = "Update Customer";
            this.Load += new System.EventHandler(this.FrmUpdateCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.ListBox lbName;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnReturnToMainMenu;
        private System.Windows.Forms.BindingSource stateBindingSource;
    }
}