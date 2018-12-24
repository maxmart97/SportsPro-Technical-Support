namespace SportsProUserInterfaceLayer.Forms
{
    partial class FrmDeleteCustomer
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
            System.Windows.Forms.Label lblCustomerID;
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.lbCustomers = new System.Windows.Forms.ListBox();
            this.bsCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustomerCity = new System.Windows.Forms.Label();
            this.lblCustomerZipCode = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblCustomerState = new System.Windows.Forms.Label();
            this.lblCustomerIDNumber = new System.Windows.Forms.Label();
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            lblZipCode = new System.Windows.Forms.Label();
            lblCity = new System.Windows.Forms.Label();
            lblState = new System.Windows.Forms.Label();
            lblAddress = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            lblPhone = new System.Windows.Forms.Label();
            lblCustomerID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblZipCode
            // 
            lblZipCode.AutoSize = true;
            lblZipCode.Location = new System.Drawing.Point(836, 440);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new System.Drawing.Size(69, 17);
            lblZipCode.TabIndex = 55;
            lblZipCode.Text = "Zip Code:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new System.Drawing.Point(511, 440);
            lblCity.Name = "lblCity";
            lblCity.Size = new System.Drawing.Size(35, 17);
            lblCity.TabIndex = 54;
            lblCity.Text = "City:";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Location = new System.Drawing.Point(330, 440);
            lblState.Name = "lblState";
            lblState.Size = new System.Drawing.Size(45, 17);
            lblState.TabIndex = 53;
            lblState.Text = "State:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new System.Drawing.Point(330, 371);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new System.Drawing.Size(64, 17);
            lblAddress.TabIndex = 43;
            lblAddress.Text = "Address:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(677, 512);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(46, 17);
            lblEmail.TabIndex = 50;
            lblEmail.Text = "Email:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(330, 316);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(49, 17);
            lblName.TabIndex = 51;
            lblName.Text = "Name:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new System.Drawing.Point(330, 512);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new System.Drawing.Size(53, 17);
            lblPhone.TabIndex = 52;
            lblPhone.Text = "Phone:";
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Location = new System.Drawing.Point(825, 316);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new System.Drawing.Size(85, 17);
            lblCustomerID.TabIndex = 64;
            lblCustomerID.Text = "CustomerID:";
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(561, 597);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(294, 65);
            this.btnDeleteCustomer.TabIndex = 56;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.BtnDeleteCustomer_Click);
            // 
            // lbCustomers
            // 
            this.lbCustomers.DataSource = this.bsCustomer;
            this.lbCustomers.DisplayMember = "Name";
            this.lbCustomers.FormattingEnabled = true;
            this.lbCustomers.ItemHeight = 16;
            this.lbCustomers.Location = new System.Drawing.Point(650, 50);
            this.lbCustomers.Name = "lbCustomers";
            this.lbCustomers.Size = new System.Drawing.Size(251, 212);
            this.lbCustomers.TabIndex = 41;
            this.lbCustomers.ValueMember = "CustomerID";
            this.lbCustomers.SelectedIndexChanged += new System.EventHandler(this.LbCustomers_SelectedIndexChanged);
            // 
            // bsCustomer
            // 
            this.bsCustomer.DataSource = typeof(SportsProBLLClassLibrary.Customer);
            // 
            // lblInstructions
            // 
            this.lblInstructions.Location = new System.Drawing.Point(436, 141);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(189, 44);
            this.lblInstructions.TabIndex = 40;
            this.lblInstructions.Text = "Select a Customer and then click \'Delete Customer.\'";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerName.Location = new System.Drawing.Point(410, 316);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(337, 22);
            this.lblCustomerName.TabIndex = 57;
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerAddress.Location = new System.Drawing.Point(410, 368);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(337, 22);
            this.lblCustomerAddress.TabIndex = 58;
            this.lblCustomerAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerEmail.Location = new System.Drawing.Point(734, 509);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(337, 22);
            this.lblCustomerEmail.TabIndex = 59;
            this.lblCustomerEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerCity
            // 
            this.lblCustomerCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerCity.Location = new System.Drawing.Point(568, 437);
            this.lblCustomerCity.Name = "lblCustomerCity";
            this.lblCustomerCity.Size = new System.Drawing.Size(220, 22);
            this.lblCustomerCity.TabIndex = 60;
            this.lblCustomerCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerZipCode
            // 
            this.lblCustomerZipCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerZipCode.Location = new System.Drawing.Point(929, 437);
            this.lblCustomerZipCode.Name = "lblCustomerZipCode";
            this.lblCustomerZipCode.Size = new System.Drawing.Size(100, 22);
            this.lblCustomerZipCode.TabIndex = 61;
            this.lblCustomerZipCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerPhone.Location = new System.Drawing.Point(413, 509);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(220, 22);
            this.lblCustomerPhone.TabIndex = 62;
            this.lblCustomerPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerState
            // 
            this.lblCustomerState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerState.Location = new System.Drawing.Point(410, 437);
            this.lblCustomerState.Name = "lblCustomerState";
            this.lblCustomerState.Size = new System.Drawing.Size(62, 22);
            this.lblCustomerState.TabIndex = 63;
            this.lblCustomerState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerIDNumber
            // 
            this.lblCustomerIDNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerIDNumber.Location = new System.Drawing.Point(929, 313);
            this.lblCustomerIDNumber.Name = "lblCustomerIDNumber";
            this.lblCustomerIDNumber.Size = new System.Drawing.Size(100, 22);
            this.lblCustomerIDNumber.TabIndex = 65;
            this.lblCustomerIDNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnToMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(1266, 726);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(162, 47);
            this.btnReturnToMainMenu.TabIndex = 66;
            this.btnReturnToMainMenu.Text = "Return to Main Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.BtnReturnToMainMenu_Click);
            // 
            // FrmDeleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 785);
            this.ControlBox = false;
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Controls.Add(this.lblCustomerIDNumber);
            this.Controls.Add(lblCustomerID);
            this.Controls.Add(this.lblCustomerState);
            this.Controls.Add(this.lblCustomerPhone);
            this.Controls.Add(this.lblCustomerZipCode);
            this.Controls.Add(this.lblCustomerCity);
            this.Controls.Add(this.lblCustomerEmail);
            this.Controls.Add(this.lblCustomerAddress);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(lblZipCode);
            this.Controls.Add(lblCity);
            this.Controls.Add(lblState);
            this.Controls.Add(lblAddress);
            this.Controls.Add(lblEmail);
            this.Controls.Add(lblName);
            this.Controls.Add(lblPhone);
            this.Controls.Add(this.lbCustomers);
            this.Controls.Add(this.lblInstructions);
            this.Name = "FrmDeleteCustomer";
            this.Text = "Delete Customer";
            this.Load += new System.EventHandler(this.FrmDeleteCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.ListBox lbCustomers;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblCustomerCity;
        private System.Windows.Forms.Label lblCustomerZipCode;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblCustomerState;
        private System.Windows.Forms.Label lblCustomerIDNumber;
        private System.Windows.Forms.BindingSource bsCustomer;
        private System.Windows.Forms.Button btnReturnToMainMenu;
    }
}