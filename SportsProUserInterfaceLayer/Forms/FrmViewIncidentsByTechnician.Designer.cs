namespace SportsProUserInterfaceLayer
{
    partial class FrmViewIncidentsByTechnician
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
            this.dgvIncidentsByTechnician = new System.Windows.Forms.DataGridView();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtInputTechID = new System.Windows.Forms.TextBox();
            this.btnGetIncidents = new System.Windows.Forms.Button();
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidentsByTechnician)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIncidentsByTechnician
            // 
            this.dgvIncidentsByTechnician.AllowUserToAddRows = false;
            this.dgvIncidentsByTechnician.AllowUserToDeleteRows = false;
            this.dgvIncidentsByTechnician.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIncidentsByTechnician.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIncidentsByTechnician.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncidentsByTechnician.Location = new System.Drawing.Point(12, 151);
            this.dgvIncidentsByTechnician.Name = "dgvIncidentsByTechnician";
            this.dgvIncidentsByTechnician.ReadOnly = true;
            this.dgvIncidentsByTechnician.RowTemplate.Height = 24;
            this.dgvIncidentsByTechnician.Size = new System.Drawing.Size(1037, 449);
            this.dgvIncidentsByTechnician.TabIndex = 2;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(91, 69);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(241, 24);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Please enter Technician ID:";
            // 
            // txtInputTechID
            // 
            this.txtInputTechID.Location = new System.Drawing.Point(357, 71);
            this.txtInputTechID.Name = "txtInputTechID";
            this.txtInputTechID.Size = new System.Drawing.Size(111, 22);
            this.txtInputTechID.TabIndex = 0;
            this.txtInputTechID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnGetIncidents
            // 
            this.btnGetIncidents.Location = new System.Drawing.Point(499, 66);
            this.btnGetIncidents.Name = "btnGetIncidents";
            this.btnGetIncidents.Size = new System.Drawing.Size(139, 32);
            this.btnGetIncidents.TabIndex = 1;
            this.btnGetIncidents.Text = "Get Incidents";
            this.btnGetIncidents.UseVisualStyleBackColor = true;
            this.btnGetIncidents.Click += new System.EventHandler(this.BtnGetIncidents_Click);
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnToMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(887, 671);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(162, 47);
            this.btnReturnToMainMenu.TabIndex = 3;
            this.btnReturnToMainMenu.Text = "Return to Main Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.BtnReturnToMainMenu_Click);
            // 
            // FrmViewIncidentsByTechnician
            // 
            this.AcceptButton = this.btnGetIncidents;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReturnToMainMenu;
            this.ClientSize = new System.Drawing.Size(1061, 730);
            this.ControlBox = false;
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Controls.Add(this.btnGetIncidents);
            this.Controls.Add(this.txtInputTechID);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.dgvIncidentsByTechnician);
            this.Name = "FrmViewIncidentsByTechnician";
            this.Text = "List of Incidents by Technician";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidentsByTechnician)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnGetIncidents;
        private System.Windows.Forms.Button btnReturnToMainMenu;
        public System.Windows.Forms.DataGridView dgvIncidentsByTechnician;
        public System.Windows.Forms.TextBox txtInputTechID;
    }
}