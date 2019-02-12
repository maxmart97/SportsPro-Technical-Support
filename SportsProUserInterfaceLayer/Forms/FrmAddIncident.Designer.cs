namespace SportsProUserInterfaceLayer.Forms
{
    partial class FrmAddIncident
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
            System.Windows.Forms.Label lblName;
            System.Windows.Forms.Label lblProducts;
            System.Windows.Forms.Label lblTechnician;
            System.Windows.Forms.Label lblDateOpened;
            System.Windows.Forms.Label lblDateClosed;
            System.Windows.Forms.Label lblTitle;
            System.Windows.Forms.Label lblDescription;
            this.lblInstructions = new System.Windows.Forms.Label();
            this.cboCustomers = new System.Windows.Forms.ComboBox();
            this.bsCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.cboProducts = new System.Windows.Forms.ComboBox();
            this.bsProducts = new System.Windows.Forms.BindingSource(this.components);
            this.cboTechnicians = new System.Windows.Forms.ComboBox();
            this.bsTechnicians = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDateOpened = new System.Windows.Forms.DateTimePicker();
            this.dtpDateClosed = new System.Windows.Forms.DateTimePicker();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            this.btnAddIncident = new System.Windows.Forms.Button();
            lblName = new System.Windows.Forms.Label();
            lblProducts = new System.Windows.Forms.Label();
            lblTechnician = new System.Windows.Forms.Label();
            lblDateOpened = new System.Windows.Forms.Label();
            lblDateClosed = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            lblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTechnicians)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(287, 227);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(77, 17);
            lblName.TabIndex = 2;
            lblName.Text = "*Customer:";
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Location = new System.Drawing.Point(298, 278);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new System.Drawing.Size(66, 17);
            lblProducts.TabIndex = 3;
            lblProducts.Text = "*Product:";
            // 
            // lblTechnician
            // 
            lblTechnician.AutoSize = true;
            lblTechnician.Location = new System.Drawing.Point(283, 328);
            lblTechnician.Name = "lblTechnician";
            lblTechnician.Size = new System.Drawing.Size(81, 17);
            lblTechnician.TabIndex = 5;
            lblTechnician.Text = "Technician:";
            // 
            // lblDateOpened
            // 
            lblDateOpened.AutoSize = true;
            lblDateOpened.Location = new System.Drawing.Point(673, 227);
            lblDateOpened.Name = "lblDateOpened";
            lblDateOpened.Size = new System.Drawing.Size(102, 17);
            lblDateOpened.TabIndex = 7;
            lblDateOpened.Text = "*Date Opened:";
            // 
            // lblDateClosed
            // 
            lblDateClosed.AutoSize = true;
            lblDateClosed.Location = new System.Drawing.Point(686, 278);
            lblDateClosed.Name = "lblDateClosed";
            lblDateClosed.Size = new System.Drawing.Size(89, 17);
            lblDateClosed.TabIndex = 9;
            lblDateClosed.Text = "Date Closed:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(727, 328);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(44, 17);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "*Title:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(278, 385);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(88, 17);
            lblDescription.TabIndex = 14;
            lblDescription.Text = "*Description:";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(447, 121);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(548, 17);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Fill out the data below and select \'Add Incident.\' Fields with an asterisk are ma" +
    "ndatory.";
            // 
            // cboCustomers
            // 
            this.cboCustomers.DataSource = this.bsCustomers;
            this.cboCustomers.DisplayMember = "Name";
            this.cboCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomers.FormattingEnabled = true;
            this.cboCustomers.Location = new System.Drawing.Point(379, 224);
            this.cboCustomers.Name = "cboCustomers";
            this.cboCustomers.Size = new System.Drawing.Size(265, 24);
            this.cboCustomers.TabIndex = 3;
            this.cboCustomers.ValueMember = "CustomerID";
            // 
            // bsCustomers
            // 
            this.bsCustomers.DataSource = typeof(SportsProBLLClassLibrary.Customer);
            // 
            // cboProducts
            // 
            this.cboProducts.DataSource = this.bsProducts;
            this.cboProducts.DisplayMember = "Name";
            this.cboProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducts.FormattingEnabled = true;
            this.cboProducts.Location = new System.Drawing.Point(379, 275);
            this.cboProducts.Name = "cboProducts";
            this.cboProducts.Size = new System.Drawing.Size(265, 24);
            this.cboProducts.TabIndex = 4;
            this.cboProducts.ValueMember = "ProductCode";
            // 
            // bsProducts
            // 
            this.bsProducts.DataSource = typeof(SportsProBLLClassLibrary.Product);
            // 
            // cboTechnicians
            // 
            this.cboTechnicians.DataSource = this.bsTechnicians;
            this.cboTechnicians.DisplayMember = "Name";
            this.cboTechnicians.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTechnicians.FormattingEnabled = true;
            this.cboTechnicians.Location = new System.Drawing.Point(379, 325);
            this.cboTechnicians.Name = "cboTechnicians";
            this.cboTechnicians.Size = new System.Drawing.Size(265, 24);
            this.cboTechnicians.TabIndex = 6;
            this.cboTechnicians.ValueMember = "TechID";
            // 
            // bsTechnicians
            // 
            this.bsTechnicians.DataSource = typeof(SportsProBLLClassLibrary.Technician);
            // 
            // dtpDateOpened
            // 
            this.dtpDateOpened.Location = new System.Drawing.Point(790, 222);
            this.dtpDateOpened.Name = "dtpDateOpened";
            this.dtpDateOpened.Size = new System.Drawing.Size(265, 22);
            this.dtpDateOpened.TabIndex = 8;
            // 
            // dtpDateClosed
            // 
            this.dtpDateClosed.Checked = false;
            this.dtpDateClosed.Location = new System.Drawing.Point(790, 273);
            this.dtpDateClosed.Name = "dtpDateClosed";
            this.dtpDateClosed.ShowCheckBox = true;
            this.dtpDateClosed.Size = new System.Drawing.Size(265, 22);
            this.dtpDateClosed.TabIndex = 10;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(790, 325);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(265, 22);
            this.tbTitle.TabIndex = 12;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(379, 382);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(676, 86);
            this.rtbDescription.TabIndex = 13;
            this.rtbDescription.Text = "";
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnToMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(1266, 726);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(162, 47);
            this.btnReturnToMainMenu.TabIndex = 67;
            this.btnReturnToMainMenu.Text = "Return to Main Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.BtnReturnToMainMenu_Click);
            // 
            // btnAddIncident
            // 
            this.btnAddIncident.Location = new System.Drawing.Point(555, 513);
            this.btnAddIncident.Name = "btnAddIncident";
            this.btnAddIncident.Size = new System.Drawing.Size(294, 65);
            this.btnAddIncident.TabIndex = 68;
            this.btnAddIncident.Text = "Add Incident";
            this.btnAddIncident.UseVisualStyleBackColor = true;
            this.btnAddIncident.Click += new System.EventHandler(this.BtnAddIncident_Click);
            // 
            // FrmAddIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 785);
            this.ControlBox = false;
            this.Controls.Add(this.btnAddIncident);
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Controls.Add(lblDescription);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(lblTitle);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(lblDateClosed);
            this.Controls.Add(this.dtpDateClosed);
            this.Controls.Add(lblDateOpened);
            this.Controls.Add(this.dtpDateOpened);
            this.Controls.Add(lblTechnician);
            this.Controls.Add(this.cboTechnicians);
            this.Controls.Add(lblProducts);
            this.Controls.Add(this.cboProducts);
            this.Controls.Add(lblName);
            this.Controls.Add(this.cboCustomers);
            this.Controls.Add(this.lblInstructions);
            this.Name = "FrmAddIncident";
            this.Text = "Add Incident";
            this.Load += new System.EventHandler(this.FrmAddIncident_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTechnicians)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.ComboBox cboCustomers;
        private System.Windows.Forms.ComboBox cboProducts;
        private System.Windows.Forms.ComboBox cboTechnicians;
        private System.Windows.Forms.DateTimePicker dtpDateOpened;
        private System.Windows.Forms.DateTimePicker dtpDateClosed;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnReturnToMainMenu;
        private System.Windows.Forms.Button btnAddIncident;
        private System.Windows.Forms.BindingSource bsCustomers;
        private System.Windows.Forms.BindingSource bsProducts;
        private System.Windows.Forms.BindingSource bsTechnicians;
    }
}