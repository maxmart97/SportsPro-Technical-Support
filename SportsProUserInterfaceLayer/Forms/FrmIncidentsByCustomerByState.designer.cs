namespace SportsProUserInterfaceLayer
{
    partial class FrmIncidentsByCustomerByState
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
            System.Windows.Forms.Label lblInstructions;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsState = new System.Windows.Forms.BindingSource(this.components);
            this.cboState = new System.Windows.Forms.ComboBox();
            this.bsCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.dgvColCustomersCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.lblNoResultsFoundCustomer = new System.Windows.Forms.Label();
            this.grpIncidents = new System.Windows.Forms.GroupBox();
            this.lblNoResultsFoundIncident = new System.Windows.Forms.Label();
            this.dgvIncidents = new System.Windows.Forms.DataGridView();
            this.dgvColIncidentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColIncidentsCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColDateOpened = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColDateClosed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColTechID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsIncident = new System.Windows.Forms.BindingSource(this.components);
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            lblInstructions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.grpCustomer.SuspendLayout();
            this.grpIncidents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIncident)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblInstructions.Location = new System.Drawing.Point(418, 42);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new System.Drawing.Size(155, 25);
            lblInstructions.TabIndex = 1;
            lblInstructions.Text = "Select a State:";
            // 
            // bsState
            // 
            this.bsState.DataSource = typeof(SportsProUserInterfaceLayer.State);
            // 
            // cboState
            // 
            this.cboState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboState.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsState, "StateName", true));
            this.cboState.DataSource = this.bsState;
            this.cboState.DisplayMember = "StateName";
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(616, 42);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(314, 24);
            this.cboState.TabIndex = 2;
            this.cboState.ValueMember = "StateCode";
            this.cboState.SelectionChangeCommitted += new System.EventHandler(this.CboState_SelectionChangeCommitted);
            // 
            // bsCustomer
            // 
            this.bsCustomer.DataSource = typeof(SportsProUserInterfaceLayer.Customer);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToResizeRows = false;
            this.dgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomers.AutoGenerateColumns = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColCustomersCustomerID,
            this.dgvColName,
            this.dgvColAddress,
            this.dgvColCity,
            this.dgvColState,
            this.dgvColZipCode,
            this.dgvColPhone,
            this.dgvColEmail});
            this.dgvCustomers.DataSource = this.bsCustomer;
            this.dgvCustomers.Location = new System.Drawing.Point(6, 21);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(1326, 256);
            this.dgvCustomers.TabIndex = 2;
            this.dgvCustomers.SelectionChanged += new System.EventHandler(this.DgvCustomer_SelectionChanged);
            // 
            // dgvColCustomersCustomerID
            // 
            this.dgvColCustomersCustomerID.DataPropertyName = "CustomerID";
            dataGridViewCellStyle1.NullValue = "NULL";
            this.dgvColCustomersCustomerID.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvColCustomersCustomerID.HeaderText = "CustomerID";
            this.dgvColCustomersCustomerID.Name = "dgvColCustomersCustomerID";
            this.dgvColCustomersCustomerID.ReadOnly = true;
            this.dgvColCustomersCustomerID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvColName
            // 
            this.dgvColName.DataPropertyName = "Name";
            dataGridViewCellStyle2.NullValue = "NULL";
            this.dgvColName.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvColName.HeaderText = "Name";
            this.dgvColName.Name = "dgvColName";
            this.dgvColName.ReadOnly = true;
            this.dgvColName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvColAddress
            // 
            this.dgvColAddress.DataPropertyName = "Address";
            dataGridViewCellStyle3.NullValue = "NULL";
            this.dgvColAddress.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvColAddress.HeaderText = "Address";
            this.dgvColAddress.Name = "dgvColAddress";
            this.dgvColAddress.ReadOnly = true;
            this.dgvColAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvColCity
            // 
            this.dgvColCity.DataPropertyName = "City";
            dataGridViewCellStyle4.NullValue = "NULL";
            this.dgvColCity.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvColCity.HeaderText = "City";
            this.dgvColCity.Name = "dgvColCity";
            this.dgvColCity.ReadOnly = true;
            this.dgvColCity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvColState
            // 
            this.dgvColState.DataPropertyName = "State";
            dataGridViewCellStyle5.NullValue = "NULL";
            this.dgvColState.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvColState.HeaderText = "State";
            this.dgvColState.Name = "dgvColState";
            this.dgvColState.ReadOnly = true;
            this.dgvColState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvColZipCode
            // 
            this.dgvColZipCode.DataPropertyName = "ZipCode";
            dataGridViewCellStyle6.NullValue = "NULL";
            this.dgvColZipCode.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvColZipCode.HeaderText = "ZipCode";
            this.dgvColZipCode.Name = "dgvColZipCode";
            this.dgvColZipCode.ReadOnly = true;
            this.dgvColZipCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvColPhone
            // 
            this.dgvColPhone.DataPropertyName = "Phone";
            dataGridViewCellStyle7.NullValue = "NULL";
            this.dgvColPhone.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvColPhone.HeaderText = "Phone";
            this.dgvColPhone.Name = "dgvColPhone";
            this.dgvColPhone.ReadOnly = true;
            this.dgvColPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvColEmail
            // 
            this.dgvColEmail.DataPropertyName = "Email";
            dataGridViewCellStyle8.NullValue = "NULL";
            this.dgvColEmail.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvColEmail.HeaderText = "Email";
            this.dgvColEmail.Name = "dgvColEmail";
            this.dgvColEmail.ReadOnly = true;
            this.dgvColEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // grpCustomer
            // 
            this.grpCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCustomer.Controls.Add(this.lblNoResultsFoundCustomer);
            this.grpCustomer.Controls.Add(this.dgvCustomers);
            this.grpCustomer.Location = new System.Drawing.Point(12, 97);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(1338, 283);
            this.grpCustomer.TabIndex = 3;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Select a Customer:";
            // 
            // lblNoResultsFoundCustomer
            // 
            this.lblNoResultsFoundCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoResultsFoundCustomer.Location = new System.Drawing.Point(599, 134);
            this.lblNoResultsFoundCustomer.Name = "lblNoResultsFoundCustomer";
            this.lblNoResultsFoundCustomer.Size = new System.Drawing.Size(172, 26);
            this.lblNoResultsFoundCustomer.TabIndex = 5;
            this.lblNoResultsFoundCustomer.Text = "No results found.";
            this.lblNoResultsFoundCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoResultsFoundCustomer.Visible = false;
            // 
            // grpIncidents
            // 
            this.grpIncidents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpIncidents.Controls.Add(this.lblNoResultsFoundIncident);
            this.grpIncidents.Controls.Add(this.dgvIncidents);
            this.grpIncidents.Location = new System.Drawing.Point(12, 386);
            this.grpIncidents.Name = "grpIncidents";
            this.grpIncidents.Size = new System.Drawing.Size(1338, 237);
            this.grpIncidents.TabIndex = 4;
            this.grpIncidents.TabStop = false;
            this.grpIncidents.Text = "Incidents";
            // 
            // lblNoResultsFoundIncident
            // 
            this.lblNoResultsFoundIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoResultsFoundIncident.Location = new System.Drawing.Point(599, 115);
            this.lblNoResultsFoundIncident.Name = "lblNoResultsFoundIncident";
            this.lblNoResultsFoundIncident.Size = new System.Drawing.Size(172, 26);
            this.lblNoResultsFoundIncident.TabIndex = 6;
            this.lblNoResultsFoundIncident.Text = "No results found.";
            this.lblNoResultsFoundIncident.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoResultsFoundIncident.Visible = false;
            // 
            // dgvIncidents
            // 
            this.dgvIncidents.AllowUserToAddRows = false;
            this.dgvIncidents.AllowUserToDeleteRows = false;
            this.dgvIncidents.AllowUserToResizeRows = false;
            this.dgvIncidents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIncidents.AutoGenerateColumns = false;
            this.dgvIncidents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIncidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncidents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColIncidentID,
            this.dgvColIncidentsCustomerID,
            this.dgvColProductCode,
            this.dgvColTitle,
            this.dgvColDescription,
            this.dgvColDateOpened,
            this.dgvColDateClosed,
            this.dgvColTechID});
            this.dgvIncidents.DataSource = this.bsIncident;
            this.dgvIncidents.Location = new System.Drawing.Point(6, 21);
            this.dgvIncidents.Name = "dgvIncidents";
            this.dgvIncidents.ReadOnly = true;
            this.dgvIncidents.RowTemplate.Height = 24;
            this.dgvIncidents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIncidents.Size = new System.Drawing.Size(1326, 210);
            this.dgvIncidents.TabIndex = 0;
            // 
            // dgvColIncidentID
            // 
            this.dgvColIncidentID.DataPropertyName = "IncidentID";
            dataGridViewCellStyle9.NullValue = "NULL";
            this.dgvColIncidentID.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvColIncidentID.HeaderText = "IncidentID";
            this.dgvColIncidentID.Name = "dgvColIncidentID";
            this.dgvColIncidentID.ReadOnly = true;
            // 
            // dgvColIncidentsCustomerID
            // 
            this.dgvColIncidentsCustomerID.DataPropertyName = "CustomerID";
            dataGridViewCellStyle10.NullValue = "NULL";
            this.dgvColIncidentsCustomerID.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvColIncidentsCustomerID.HeaderText = "CustomerID";
            this.dgvColIncidentsCustomerID.Name = "dgvColIncidentsCustomerID";
            this.dgvColIncidentsCustomerID.ReadOnly = true;
            // 
            // dgvColProductCode
            // 
            this.dgvColProductCode.DataPropertyName = "ProductCode";
            dataGridViewCellStyle11.NullValue = "NULL";
            this.dgvColProductCode.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvColProductCode.HeaderText = "ProductCode";
            this.dgvColProductCode.Name = "dgvColProductCode";
            this.dgvColProductCode.ReadOnly = true;
            // 
            // dgvColTitle
            // 
            this.dgvColTitle.DataPropertyName = "Title";
            dataGridViewCellStyle12.NullValue = "NULL";
            this.dgvColTitle.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvColTitle.HeaderText = "Title";
            this.dgvColTitle.Name = "dgvColTitle";
            this.dgvColTitle.ReadOnly = true;
            // 
            // dgvColDescription
            // 
            this.dgvColDescription.DataPropertyName = "Description";
            dataGridViewCellStyle13.NullValue = "NULL";
            this.dgvColDescription.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvColDescription.HeaderText = "Description";
            this.dgvColDescription.Name = "dgvColDescription";
            this.dgvColDescription.ReadOnly = true;
            // 
            // dgvColDateOpened
            // 
            this.dgvColDateOpened.DataPropertyName = "DateOpened";
            dataGridViewCellStyle14.Format = "d";
            dataGridViewCellStyle14.NullValue = "NULL";
            this.dgvColDateOpened.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvColDateOpened.HeaderText = "DateOpened";
            this.dgvColDateOpened.Name = "dgvColDateOpened";
            this.dgvColDateOpened.ReadOnly = true;
            // 
            // dgvColDateClosed
            // 
            this.dgvColDateClosed.DataPropertyName = "DateClosed";
            dataGridViewCellStyle15.Format = "d";
            dataGridViewCellStyle15.NullValue = "NULL";
            this.dgvColDateClosed.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvColDateClosed.HeaderText = "DateClosed";
            this.dgvColDateClosed.Name = "dgvColDateClosed";
            this.dgvColDateClosed.ReadOnly = true;
            // 
            // dgvColTechID
            // 
            this.dgvColTechID.DataPropertyName = "TechID";
            dataGridViewCellStyle16.NullValue = "NULL";
            this.dgvColTechID.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvColTechID.HeaderText = "TechID";
            this.dgvColTechID.Name = "dgvColTechID";
            this.dgvColTechID.ReadOnly = true;
            // 
            // bsIncident
            // 
            this.bsIncident.DataSource = typeof(SportsProUserInterfaceLayer.Incident);
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnToMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(1188, 650);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(162, 47);
            this.btnReturnToMainMenu.TabIndex = 5;
            this.btnReturnToMainMenu.Text = "Return to Main Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.BtnReturnToMainMenu_Click);
            // 
            // FrmIncidentsByCustomerByState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 709);
            this.ControlBox = false;
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Controls.Add(this.grpIncidents);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(lblInstructions);
            this.Controls.Add(this.cboState);
            this.Name = "FrmIncidentsByCustomerByState";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incidents by Customer in a specific State.";
            this.Load += new System.EventHandler(this.FrmIncidentsByCustomerByState_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.grpCustomer.ResumeLayout(false);
            this.grpIncidents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIncident)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsState;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.BindingSource bsCustomer;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.GroupBox grpIncidents;
        private System.Windows.Forms.DataGridView dgvIncidents;
        private System.Windows.Forms.BindingSource bsIncident;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColIncidentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColIncidentsCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColDateOpened;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColDateClosed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColTechID;
        private System.Windows.Forms.Label lblNoResultsFoundCustomer;
        private System.Windows.Forms.Label lblNoResultsFoundIncident;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCustomersCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColState;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColZipCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColEmail;
        private System.Windows.Forms.Button btnReturnToMainMenu;
    }
}

