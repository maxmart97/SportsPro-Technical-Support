namespace SportsProUserInterfaceLayer.Forms
{
    partial class FrmUpdateIncident
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
            System.Windows.Forms.Label lblDescription;
            System.Windows.Forms.Label lblTitle;
            System.Windows.Forms.Label lblDateClosed;
            System.Windows.Forms.Label lblDateOpened;
            System.Windows.Forms.Label lblTechnician;
            System.Windows.Forms.Label lblProducts;
            System.Windows.Forms.Label lblName;
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            this.bsIncident = new System.Windows.Forms.BindingSource(this.components);
            this.dgvIncidents = new System.Windows.Forms.DataGridView();
            this.IncidentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOpenedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateClosed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnUpdateIncident = new System.Windows.Forms.Button();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.dtpDateClosed = new System.Windows.Forms.DateTimePicker();
            this.dtpDateOpened = new System.Windows.Forms.DateTimePicker();
            this.cboTechnicians = new System.Windows.Forms.ComboBox();
            this.cboProducts = new System.Windows.Forms.ComboBox();
            this.cboCustomers = new System.Windows.Forms.ComboBox();
            lblDescription = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            lblDateClosed = new System.Windows.Forms.Label();
            lblDateOpened = new System.Windows.Forms.Label();
            lblTechnician = new System.Windows.Forms.Label();
            lblProducts = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsIncident)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(312, 472);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(88, 17);
            lblDescription.TabIndex = 84;
            lblDescription.Text = "*Description:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(761, 415);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(44, 17);
            lblTitle.TabIndex = 81;
            lblTitle.Text = "*Title:";
            // 
            // lblDateClosed
            // 
            lblDateClosed.AutoSize = true;
            lblDateClosed.Location = new System.Drawing.Point(720, 365);
            lblDateClosed.Name = "lblDateClosed";
            lblDateClosed.Size = new System.Drawing.Size(89, 17);
            lblDateClosed.TabIndex = 79;
            lblDateClosed.Text = "Date Closed:";
            // 
            // lblDateOpened
            // 
            lblDateOpened.AutoSize = true;
            lblDateOpened.Location = new System.Drawing.Point(707, 314);
            lblDateOpened.Name = "lblDateOpened";
            lblDateOpened.Size = new System.Drawing.Size(102, 17);
            lblDateOpened.TabIndex = 77;
            lblDateOpened.Text = "*Date Opened:";
            // 
            // lblTechnician
            // 
            lblTechnician.AutoSize = true;
            lblTechnician.Location = new System.Drawing.Point(317, 415);
            lblTechnician.Name = "lblTechnician";
            lblTechnician.Size = new System.Drawing.Size(81, 17);
            lblTechnician.TabIndex = 75;
            lblTechnician.Text = "Technician:";
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Location = new System.Drawing.Point(332, 365);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new System.Drawing.Size(66, 17);
            lblProducts.TabIndex = 72;
            lblProducts.Text = "*Product:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(321, 314);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(77, 17);
            lblName.TabIndex = 71;
            lblName.Text = "*Customer:";
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnToMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(1274, 734);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(162, 47);
            this.btnReturnToMainMenu.TabIndex = 68;
            this.btnReturnToMainMenu.Text = "Return to Main Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.btnReturnToMainMenu_Click);
            // 
            // bsIncident
            // 
            this.bsIncident.DataSource = typeof(SportsProUserInterfaceLayer.Incident);
            // 
            // dgvIncidents
            // 
            this.dgvIncidents.AllowUserToAddRows = false;
            this.dgvIncidents.AllowUserToDeleteRows = false;
            this.dgvIncidents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIncidents.AutoGenerateColumns = false;
            this.dgvIncidents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIncidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncidents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IncidentID,
            this.Customer,
            this.Product,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.dateOpenedDataGridViewTextBoxColumn,
            this.DateClosed});
            this.dgvIncidents.DataSource = this.bsIncident;
            this.dgvIncidents.Location = new System.Drawing.Point(12, 60);
            this.dgvIncidents.MultiSelect = false;
            this.dgvIncidents.Name = "dgvIncidents";
            this.dgvIncidents.ReadOnly = true;
            this.dgvIncidents.RowTemplate.Height = 24;
            this.dgvIncidents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIncidents.Size = new System.Drawing.Size(1424, 220);
            this.dgvIncidents.TabIndex = 69;
            this.dgvIncidents.SelectionChanged += new System.EventHandler(this.DgvIncidents_SelectionChanged);
            // 
            // IncidentID
            // 
            this.IncidentID.DataPropertyName = "IncidentID";
            this.IncidentID.HeaderText = "IncidentID";
            this.IncidentID.Name = "IncidentID";
            this.IncidentID.ReadOnly = true;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "CustomerName";
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // Product
            // 
            this.Product.DataPropertyName = "ProductName";
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOpenedDataGridViewTextBoxColumn
            // 
            this.dateOpenedDataGridViewTextBoxColumn.DataPropertyName = "DateOpened";
            this.dateOpenedDataGridViewTextBoxColumn.HeaderText = "DateOpened";
            this.dateOpenedDataGridViewTextBoxColumn.Name = "dateOpenedDataGridViewTextBoxColumn";
            this.dateOpenedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DateClosed
            // 
            this.DateClosed.DataPropertyName = "DateClosed";
            this.DateClosed.HeaderText = "DateClosed";
            this.DateClosed.Name = "DateClosed";
            this.DateClosed.ReadOnly = true;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(490, 20);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(431, 17);
            this.lblInstructions.TabIndex = 70;
            this.lblInstructions.Text = "Select an incident, edit data below, and then click \'Update Incident.\'";
            // 
            // btnUpdateIncident
            // 
            this.btnUpdateIncident.Location = new System.Drawing.Point(589, 600);
            this.btnUpdateIncident.Name = "btnUpdateIncident";
            this.btnUpdateIncident.Size = new System.Drawing.Size(294, 65);
            this.btnUpdateIncident.TabIndex = 85;
            this.btnUpdateIncident.Text = "Update Incident";
            this.btnUpdateIncident.UseVisualStyleBackColor = true;
            this.btnUpdateIncident.Click += new System.EventHandler(this.BtnUpdateIncident_Click);
            // 
            // rtbDescription
            // 
            this.rtbDescription.Enabled = false;
            this.rtbDescription.Location = new System.Drawing.Point(413, 469);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(676, 86);
            this.rtbDescription.TabIndex = 83;
            this.rtbDescription.Text = "";
            // 
            // tbTitle
            // 
            this.tbTitle.Enabled = false;
            this.tbTitle.Location = new System.Drawing.Point(824, 412);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(265, 22);
            this.tbTitle.TabIndex = 82;
            // 
            // dtpDateClosed
            // 
            this.dtpDateClosed.Checked = false;
            this.dtpDateClosed.Enabled = false;
            this.dtpDateClosed.Location = new System.Drawing.Point(824, 360);
            this.dtpDateClosed.Name = "dtpDateClosed";
            this.dtpDateClosed.ShowCheckBox = true;
            this.dtpDateClosed.Size = new System.Drawing.Size(265, 22);
            this.dtpDateClosed.TabIndex = 80;
            // 
            // dtpDateOpened
            // 
            this.dtpDateOpened.Enabled = false;
            this.dtpDateOpened.Location = new System.Drawing.Point(824, 309);
            this.dtpDateOpened.Name = "dtpDateOpened";
            this.dtpDateOpened.Size = new System.Drawing.Size(265, 22);
            this.dtpDateOpened.TabIndex = 78;
            // 
            // cboTechnicians
            // 
            this.cboTechnicians.DisplayMember = "Name";
            this.cboTechnicians.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTechnicians.Enabled = false;
            this.cboTechnicians.FormattingEnabled = true;
            this.cboTechnicians.Location = new System.Drawing.Point(413, 412);
            this.cboTechnicians.Name = "cboTechnicians";
            this.cboTechnicians.Size = new System.Drawing.Size(265, 24);
            this.cboTechnicians.TabIndex = 76;
            this.cboTechnicians.ValueMember = "TechID";
            // 
            // cboProducts
            // 
            this.cboProducts.DisplayMember = "Name";
            this.cboProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducts.Enabled = false;
            this.cboProducts.FormattingEnabled = true;
            this.cboProducts.Location = new System.Drawing.Point(413, 362);
            this.cboProducts.Name = "cboProducts";
            this.cboProducts.Size = new System.Drawing.Size(265, 24);
            this.cboProducts.TabIndex = 74;
            this.cboProducts.ValueMember = "ProductCode";
            // 
            // cboCustomers
            // 
            this.cboCustomers.DisplayMember = "Name";
            this.cboCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomers.Enabled = false;
            this.cboCustomers.FormattingEnabled = true;
            this.cboCustomers.Location = new System.Drawing.Point(413, 311);
            this.cboCustomers.Name = "cboCustomers";
            this.cboCustomers.Size = new System.Drawing.Size(265, 24);
            this.cboCustomers.TabIndex = 73;
            this.cboCustomers.ValueMember = "CustomerID";
            // 
            // FrmUpdateIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 793);
            this.ControlBox = false;
            this.Controls.Add(this.btnUpdateIncident);
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
            this.Controls.Add(this.dgvIncidents);
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Name = "FrmUpdateIncident";
            this.Text = "Update Incident";
            this.Load += new System.EventHandler(this.FrmUpdateIncident_Load);
            this.Shown += new System.EventHandler(this.FrmUpdateIncident_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bsIncident)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnToMainMenu;
        private System.Windows.Forms.BindingSource bsIncident;
        private System.Windows.Forms.DataGridView dgvIncidents;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnUpdateIncident;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.DateTimePicker dtpDateClosed;
        private System.Windows.Forms.DateTimePicker dtpDateOpened;
        private System.Windows.Forms.ComboBox cboTechnicians;
        private System.Windows.Forms.ComboBox cboProducts;
        private System.Windows.Forms.ComboBox cboCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncidentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOpenedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateClosed;
    }
}