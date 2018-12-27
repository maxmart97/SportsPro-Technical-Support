namespace SportsProUserInterfaceLayer.Forms
{
    partial class FrmDeleteIncident
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
            System.Windows.Forms.Label lblIncidentIDOutputDesc;
            System.Windows.Forms.Label lblDescOutputDesc;
            System.Windows.Forms.Label lblTitleOutputDesc;
            System.Windows.Forms.Label lblProductOutputDesc;
            System.Windows.Forms.Label lblDateClosedOutputDesc;
            System.Windows.Forms.Label lblCustomerOutputDesc;
            System.Windows.Forms.Label lblDateOpenedOutputDesc;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblIncidentID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDateOpened = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDateClosed = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.btnDeleteIncident = new System.Windows.Forms.Button();
            this.dgvIncidents = new System.Windows.Forms.DataGridView();
            this.dgvColIncidentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColDateClosed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            this.dgvColTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColDateOpened = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsIncident = new System.Windows.Forms.BindingSource(this.components);
            lblIncidentIDOutputDesc = new System.Windows.Forms.Label();
            lblDescOutputDesc = new System.Windows.Forms.Label();
            lblTitleOutputDesc = new System.Windows.Forms.Label();
            lblProductOutputDesc = new System.Windows.Forms.Label();
            lblDateClosedOutputDesc = new System.Windows.Forms.Label();
            lblCustomerOutputDesc = new System.Windows.Forms.Label();
            lblDateOpenedOutputDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIncident)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIncidentIDOutputDesc
            // 
            lblIncidentIDOutputDesc.AutoSize = true;
            lblIncidentIDOutputDesc.Location = new System.Drawing.Point(80, 376);
            lblIncidentIDOutputDesc.Name = "lblIncidentIDOutputDesc";
            lblIncidentIDOutputDesc.Size = new System.Drawing.Size(74, 17);
            lblIncidentIDOutputDesc.TabIndex = 81;
            lblIncidentIDOutputDesc.Text = "IncidentID:";
            // 
            // lblDescOutputDesc
            // 
            lblDescOutputDesc.AutoSize = true;
            lblDescOutputDesc.Location = new System.Drawing.Point(524, 425);
            lblDescOutputDesc.Name = "lblDescOutputDesc";
            lblDescOutputDesc.Size = new System.Drawing.Size(83, 17);
            lblDescOutputDesc.TabIndex = 71;
            lblDescOutputDesc.Text = "Description:";
            // 
            // lblTitleOutputDesc
            // 
            lblTitleOutputDesc.AutoSize = true;
            lblTitleOutputDesc.Location = new System.Drawing.Point(524, 375);
            lblTitleOutputDesc.Name = "lblTitleOutputDesc";
            lblTitleOutputDesc.Size = new System.Drawing.Size(39, 17);
            lblTitleOutputDesc.TabIndex = 70;
            lblTitleOutputDesc.Text = "Title:";
            // 
            // lblProductOutputDesc
            // 
            lblProductOutputDesc.AutoSize = true;
            lblProductOutputDesc.Location = new System.Drawing.Point(80, 466);
            lblProductOutputDesc.Name = "lblProductOutputDesc";
            lblProductOutputDesc.Size = new System.Drawing.Size(61, 17);
            lblProductOutputDesc.TabIndex = 66;
            lblProductOutputDesc.Text = "Product:";
            // 
            // lblDateClosedOutputDesc
            // 
            lblDateClosedOutputDesc.AutoSize = true;
            lblDateClosedOutputDesc.Location = new System.Drawing.Point(1130, 425);
            lblDateClosedOutputDesc.Name = "lblDateClosedOutputDesc";
            lblDateClosedOutputDesc.Size = new System.Drawing.Size(89, 17);
            lblDateClosedOutputDesc.TabIndex = 67;
            lblDateClosedOutputDesc.Text = "Date Closed:";
            // 
            // lblCustomerOutputDesc
            // 
            lblCustomerOutputDesc.AutoSize = true;
            lblCustomerOutputDesc.Location = new System.Drawing.Point(80, 421);
            lblCustomerOutputDesc.Name = "lblCustomerOutputDesc";
            lblCustomerOutputDesc.Size = new System.Drawing.Size(72, 17);
            lblCustomerOutputDesc.TabIndex = 68;
            lblCustomerOutputDesc.Text = "Customer:";
            // 
            // lblDateOpenedOutputDesc
            // 
            lblDateOpenedOutputDesc.AutoSize = true;
            lblDateOpenedOutputDesc.Location = new System.Drawing.Point(1130, 375);
            lblDateOpenedOutputDesc.Name = "lblDateOpenedOutputDesc";
            lblDateOpenedOutputDesc.Size = new System.Drawing.Size(97, 17);
            lblDateOpenedOutputDesc.TabIndex = 69;
            lblDateOpenedOutputDesc.Text = "Date Opened:";
            // 
            // lblIncidentID
            // 
            this.lblIncidentID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIncidentID.Location = new System.Drawing.Point(160, 376);
            this.lblIncidentID.Name = "lblIncidentID";
            this.lblIncidentID.Size = new System.Drawing.Size(71, 24);
            this.lblIncidentID.TabIndex = 82;
            this.lblIncidentID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Location = new System.Drawing.Point(613, 376);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(416, 31);
            this.lblTitle.TabIndex = 80;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateOpened
            // 
            this.lblDateOpened.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDateOpened.Location = new System.Drawing.Point(1233, 375);
            this.lblDateOpened.Name = "lblDateOpened";
            this.lblDateOpened.Size = new System.Drawing.Size(159, 31);
            this.lblDateOpened.TabIndex = 79;
            this.lblDateOpened.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescription
            // 
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDescription.Location = new System.Drawing.Point(613, 425);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(416, 86);
            this.lblDescription.TabIndex = 77;
            // 
            // lblDateClosed
            // 
            this.lblDateClosed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDateClosed.Location = new System.Drawing.Point(1233, 425);
            this.lblDateClosed.Name = "lblDateClosed";
            this.lblDateClosed.Size = new System.Drawing.Size(159, 31);
            this.lblDateClosed.TabIndex = 76;
            this.lblDateClosed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProduct
            // 
            this.lblProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProduct.Location = new System.Drawing.Point(160, 466);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(337, 24);
            this.lblProduct.TabIndex = 75;
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomer
            // 
            this.lblCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomer.Location = new System.Drawing.Point(160, 421);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(337, 24);
            this.lblCustomer.TabIndex = 74;
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDeleteIncident
            // 
            this.btnDeleteIncident.Location = new System.Drawing.Point(560, 559);
            this.btnDeleteIncident.Name = "btnDeleteIncident";
            this.btnDeleteIncident.Size = new System.Drawing.Size(294, 65);
            this.btnDeleteIncident.TabIndex = 73;
            this.btnDeleteIncident.Text = "Delete Incident";
            this.btnDeleteIncident.UseVisualStyleBackColor = true;
            this.btnDeleteIncident.Click += new System.EventHandler(this.BtnDeleteIncident_Click);
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
            this.dgvColIncidentID,
            this.dgvColCustomer,
            this.dgvColProduct,
            this.dgvColTitle,
            this.dgvColDescription,
            this.dgvColDateOpened,
            this.dgvColDateClosed});
            this.dgvIncidents.DataSource = this.bsIncident;
            this.dgvIncidents.Location = new System.Drawing.Point(12, 79);
            this.dgvIncidents.MultiSelect = false;
            this.dgvIncidents.Name = "dgvIncidents";
            this.dgvIncidents.ReadOnly = true;
            this.dgvIncidents.RowTemplate.Height = 24;
            this.dgvIncidents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIncidents.Size = new System.Drawing.Size(1424, 263);
            this.dgvIncidents.TabIndex = 83;
            this.dgvIncidents.SelectionChanged += new System.EventHandler(this.DgvIncidents_SelectionChanged);
            // 
            // dgvColIncidentID
            // 
            this.dgvColIncidentID.DataPropertyName = "IncidentID";
            this.dgvColIncidentID.HeaderText = "IncidentID";
            this.dgvColIncidentID.Name = "dgvColIncidentID";
            this.dgvColIncidentID.ReadOnly = true;
            // 
            // dgvColCustomer
            // 
            this.dgvColCustomer.DataPropertyName = "CustomerName";
            this.dgvColCustomer.HeaderText = "Customer";
            this.dgvColCustomer.Name = "dgvColCustomer";
            this.dgvColCustomer.ReadOnly = true;
            // 
            // dgvColProduct
            // 
            this.dgvColProduct.DataPropertyName = "ProductName";
            this.dgvColProduct.HeaderText = "Product";
            this.dgvColProduct.Name = "dgvColProduct";
            this.dgvColProduct.ReadOnly = true;
            // 
            // dgvColDateClosed
            // 
            this.dgvColDateClosed.DataPropertyName = "DateClosed";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dgvColDateClosed.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvColDateClosed.HeaderText = "DateClosed";
            this.dgvColDateClosed.Name = "dgvColDateClosed";
            this.dgvColDateClosed.ReadOnly = true;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(567, 31);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(287, 17);
            this.lblInstructions.TabIndex = 84;
            this.lblInstructions.Text = "Select an incident and click \'Delete Incident.\'";
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnToMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(1274, 734);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(162, 47);
            this.btnReturnToMainMenu.TabIndex = 85;
            this.btnReturnToMainMenu.Text = "Return to Main Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.BtnReturnToMainMenu_Click);
            // 
            // dgvColTitle
            // 
            this.dgvColTitle.DataPropertyName = "Title";
            this.dgvColTitle.HeaderText = "Title";
            this.dgvColTitle.Name = "dgvColTitle";
            this.dgvColTitle.ReadOnly = true;
            // 
            // dgvColDescription
            // 
            this.dgvColDescription.DataPropertyName = "Description";
            this.dgvColDescription.HeaderText = "Description";
            this.dgvColDescription.Name = "dgvColDescription";
            this.dgvColDescription.ReadOnly = true;
            // 
            // dgvColDateOpened
            // 
            this.dgvColDateOpened.DataPropertyName = "DateOpened";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dgvColDateOpened.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvColDateOpened.HeaderText = "DateOpened";
            this.dgvColDateOpened.Name = "dgvColDateOpened";
            this.dgvColDateOpened.ReadOnly = true;
            // 
            // bsIncident
            // 
            this.bsIncident.DataSource = typeof(SportsProUserInterfaceLayer.Incident);
            // 
            // FrmDeleteIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 793);
            this.ControlBox = false;
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.dgvIncidents);
            this.Controls.Add(this.lblIncidentID);
            this.Controls.Add(lblIncidentIDOutputDesc);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDateOpened);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDateClosed);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.btnDeleteIncident);
            this.Controls.Add(lblDescOutputDesc);
            this.Controls.Add(lblTitleOutputDesc);
            this.Controls.Add(lblProductOutputDesc);
            this.Controls.Add(lblDateClosedOutputDesc);
            this.Controls.Add(lblCustomerOutputDesc);
            this.Controls.Add(lblDateOpenedOutputDesc);
            this.Name = "FrmDeleteIncident";
            this.Text = "Delete Incident";
            this.Load += new System.EventHandler(this.FrmDeleteIncident_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIncident)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIncidentID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDateOpened;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDateClosed;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Button btnDeleteIncident;
        public System.Windows.Forms.DataGridView dgvIncidents;
        private System.Windows.Forms.BindingSource bsIncident;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColIncidentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColDateOpened;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColDateClosed;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnReturnToMainMenu;
    }
}