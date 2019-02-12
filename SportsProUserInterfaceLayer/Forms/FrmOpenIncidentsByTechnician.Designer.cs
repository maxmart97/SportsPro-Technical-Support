namespace SportsProUserInterfaceLayer
{
    partial class FrmOpenIncidentsByTechnician
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblTechnicianEmailOutputDesc = new System.Windows.Forms.Label();
            this.lblTechnicianPhoneOutputDesc = new System.Windows.Forms.Label();
            this.cboTechnicians = new System.Windows.Forms.ComboBox();
            this.lblTechnicianEmail = new System.Windows.Forms.Label();
            this.lblTechnicianPhone = new System.Windows.Forms.Label();
            this.tlpFrmOpenIncidentsByTechnician = new System.Windows.Forms.TableLayoutPanel();
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            this.dgvOpenIncidentsByTechnician = new System.Windows.Forms.DataGridView();
            this.technicianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incidentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incidentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOpenedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateClosedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpFrmOpenIncidentsByTechnician.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpenIncidentsByTechnician)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(42, 47);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(203, 20);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Please Select Technician:";
            // 
            // lblTechnicianEmailOutputDesc
            // 
            this.lblTechnicianEmailOutputDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTechnicianEmailOutputDesc.AutoSize = true;
            this.lblTechnicianEmailOutputDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechnicianEmailOutputDesc.Location = new System.Drawing.Point(42, 116);
            this.lblTechnicianEmailOutputDesc.Name = "lblTechnicianEmailOutputDesc";
            this.lblTechnicianEmailOutputDesc.Size = new System.Drawing.Size(142, 20);
            this.lblTechnicianEmailOutputDesc.TabIndex = 0;
            this.lblTechnicianEmailOutputDesc.Text = "Technician EMail:";
            // 
            // lblTechnicianPhoneOutputDesc
            // 
            this.lblTechnicianPhoneOutputDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTechnicianPhoneOutputDesc.AutoSize = true;
            this.lblTechnicianPhoneOutputDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechnicianPhoneOutputDesc.Location = new System.Drawing.Point(42, 194);
            this.lblTechnicianPhoneOutputDesc.Name = "lblTechnicianPhoneOutputDesc";
            this.lblTechnicianPhoneOutputDesc.Size = new System.Drawing.Size(147, 20);
            this.lblTechnicianPhoneOutputDesc.TabIndex = 0;
            this.lblTechnicianPhoneOutputDesc.Text = "Technician Phone:";
            // 
            // cboTechnicians
            // 
            this.cboTechnicians.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboTechnicians.DataSource = this.technicianBindingSource;
            this.cboTechnicians.DisplayMember = "Name";
            this.cboTechnicians.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTechnicians.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTechnicians.FormattingEnabled = true;
            this.cboTechnicians.Location = new System.Drawing.Point(294, 43);
            this.cboTechnicians.Name = "cboTechnicians";
            this.cboTechnicians.Size = new System.Drawing.Size(386, 28);
            this.cboTechnicians.TabIndex = 0;
            this.cboTechnicians.ValueMember = "TechID";
            this.cboTechnicians.SelectionChangeCommitted += new System.EventHandler(this.CboTechnicians_SelectionChangeCommitted);
            // 
            // lblTechnicianEmail
            // 
            this.lblTechnicianEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTechnicianEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTechnicianEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technicianBindingSource, "Email", true));
            this.lblTechnicianEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechnicianEmail.Location = new System.Drawing.Point(294, 112);
            this.lblTechnicianEmail.Name = "lblTechnicianEmail";
            this.lblTechnicianEmail.Size = new System.Drawing.Size(386, 28);
            this.lblTechnicianEmail.TabIndex = 1;
            this.lblTechnicianEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTechnicianPhone
            // 
            this.lblTechnicianPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTechnicianPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTechnicianPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technicianBindingSource, "Phone", true));
            this.lblTechnicianPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechnicianPhone.Location = new System.Drawing.Point(294, 190);
            this.lblTechnicianPhone.Name = "lblTechnicianPhone";
            this.lblTechnicianPhone.Size = new System.Drawing.Size(386, 28);
            this.lblTechnicianPhone.TabIndex = 2;
            this.lblTechnicianPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpFrmOpenIncidentsByTechnician
            // 
            this.tlpFrmOpenIncidentsByTechnician.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpFrmOpenIncidentsByTechnician.ColumnCount = 3;
            this.tlpFrmOpenIncidentsByTechnician.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.760849F));
            this.tlpFrmOpenIncidentsByTechnician.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.30087F));
            this.tlpFrmOpenIncidentsByTechnician.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.74542F));
            this.tlpFrmOpenIncidentsByTechnician.Controls.Add(this.btnReturnToMainMenu, 2, 5);
            this.tlpFrmOpenIncidentsByTechnician.Controls.Add(this.lblTechnicianEmail, 2, 2);
            this.tlpFrmOpenIncidentsByTechnician.Controls.Add(this.lblTechnicianPhoneOutputDesc, 1, 3);
            this.tlpFrmOpenIncidentsByTechnician.Controls.Add(this.lblInstructions, 1, 1);
            this.tlpFrmOpenIncidentsByTechnician.Controls.Add(this.cboTechnicians, 2, 1);
            this.tlpFrmOpenIncidentsByTechnician.Controls.Add(this.lblTechnicianEmailOutputDesc, 1, 2);
            this.tlpFrmOpenIncidentsByTechnician.Controls.Add(this.dgvOpenIncidentsByTechnician, 2, 3);
            this.tlpFrmOpenIncidentsByTechnician.Controls.Add(this.lblTechnicianPhone, 1, 3);
            this.tlpFrmOpenIncidentsByTechnician.Location = new System.Drawing.Point(12, 12);
            this.tlpFrmOpenIncidentsByTechnician.Name = "tlpFrmOpenIncidentsByTechnician";
            this.tlpFrmOpenIncidentsByTechnician.RowCount = 6;
            this.tlpFrmOpenIncidentsByTechnician.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpFrmOpenIncidentsByTechnician.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpFrmOpenIncidentsByTechnician.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tlpFrmOpenIncidentsByTechnician.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tlpFrmOpenIncidentsByTechnician.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 345F));
            this.tlpFrmOpenIncidentsByTechnician.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tlpFrmOpenIncidentsByTechnician.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFrmOpenIncidentsByTechnician.Size = new System.Drawing.Size(1037, 706);
            this.tlpFrmOpenIncidentsByTechnician.TabIndex = 5;
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnToMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(872, 656);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(162, 47);
            this.btnReturnToMainMenu.TabIndex = 2;
            this.btnReturnToMainMenu.Text = "Return to Main Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.BtnReturnToMainMenu_Click);
            // 
            // dgvOpenIncidentsByTechnician
            // 
            this.dgvOpenIncidentsByTechnician.AllowUserToAddRows = false;
            this.dgvOpenIncidentsByTechnician.AllowUserToDeleteRows = false;
            this.dgvOpenIncidentsByTechnician.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOpenIncidentsByTechnician.AutoGenerateColumns = false;
            this.dgvOpenIncidentsByTechnician.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOpenIncidentsByTechnician.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpenIncidentsByTechnician.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.incidentIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.productCodeDataGridViewTextBoxColumn,
            this.techIDDataGridViewTextBoxColumn,
            this.dateOpenedDataGridViewTextBoxColumn,
            this.dateClosedDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.tlpFrmOpenIncidentsByTechnician.SetColumnSpan(this.dgvOpenIncidentsByTechnician, 3);
            this.dgvOpenIncidentsByTechnician.DataSource = this.incidentsBindingSource;
            this.dgvOpenIncidentsByTechnician.Location = new System.Drawing.Point(3, 247);
            this.dgvOpenIncidentsByTechnician.Name = "dgvOpenIncidentsByTechnician";
            this.dgvOpenIncidentsByTechnician.ReadOnly = true;
            this.dgvOpenIncidentsByTechnician.RowTemplate.Height = 24;
            this.dgvOpenIncidentsByTechnician.Size = new System.Drawing.Size(1031, 339);
            this.dgvOpenIncidentsByTechnician.TabIndex = 1;
            // 
            // technicianBindingSource
            // 
            this.technicianBindingSource.DataSource = typeof(SportsProUserInterfaceLayer.LINQ_to_SQL.Technician);
            // 
            // incidentsBindingSource
            // 
            this.incidentsBindingSource.DataSource = typeof(SportsProUserInterfaceLayer.LINQ_to_SQL.Incident);
            // 
            // incidentIDDataGridViewTextBoxColumn
            // 
            this.incidentIDDataGridViewTextBoxColumn.DataPropertyName = "IncidentID";
            this.incidentIDDataGridViewTextBoxColumn.HeaderText = "IncidentID";
            this.incidentIDDataGridViewTextBoxColumn.Name = "incidentIDDataGridViewTextBoxColumn";
            this.incidentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.HeaderText = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            this.productCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // techIDDataGridViewTextBoxColumn
            // 
            this.techIDDataGridViewTextBoxColumn.DataPropertyName = "TechID";
            this.techIDDataGridViewTextBoxColumn.HeaderText = "TechID";
            this.techIDDataGridViewTextBoxColumn.Name = "techIDDataGridViewTextBoxColumn";
            this.techIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOpenedDataGridViewTextBoxColumn
            // 
            this.dateOpenedDataGridViewTextBoxColumn.DataPropertyName = "DateOpened";
            this.dateOpenedDataGridViewTextBoxColumn.HeaderText = "DateOpened";
            this.dateOpenedDataGridViewTextBoxColumn.Name = "dateOpenedDataGridViewTextBoxColumn";
            this.dateOpenedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateClosedDataGridViewTextBoxColumn
            // 
            this.dateClosedDataGridViewTextBoxColumn.DataPropertyName = "DateClosed";
            this.dateClosedDataGridViewTextBoxColumn.HeaderText = "DateClosed";
            this.dateClosedDataGridViewTextBoxColumn.Name = "dateClosedDataGridViewTextBoxColumn";
            this.dateClosedDataGridViewTextBoxColumn.ReadOnly = true;
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
            // FrmOpenIncidentsByTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReturnToMainMenu;
            this.ClientSize = new System.Drawing.Size(1061, 730);
            this.ControlBox = false;
            this.Controls.Add(this.tlpFrmOpenIncidentsByTechnician);
            this.Name = "FrmOpenIncidentsByTechnician";
            this.Text = "List of Incidents Assigned to Specified Technician";
            this.Load += new System.EventHandler(this.FrmOpenIncidentsByTechnician_Load);
            this.tlpFrmOpenIncidentsByTechnician.ResumeLayout(false);
            this.tlpFrmOpenIncidentsByTechnician.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpenIncidentsByTechnician)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblTechnicianEmailOutputDesc;
        private System.Windows.Forms.Label lblTechnicianPhoneOutputDesc;
        public System.Windows.Forms.ComboBox cboTechnicians;
        public System.Windows.Forms.Label lblTechnicianEmail;
        public System.Windows.Forms.Label lblTechnicianPhone;
        private System.Windows.Forms.TableLayoutPanel tlpFrmOpenIncidentsByTechnician;
        private System.Windows.Forms.Button btnReturnToMainMenu;
        public System.Windows.Forms.DataGridView dgvOpenIncidentsByTechnician;
        private System.Windows.Forms.BindingSource technicianBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn incidentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn techIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOpenedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateClosedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource incidentsBindingSource;
    }
}