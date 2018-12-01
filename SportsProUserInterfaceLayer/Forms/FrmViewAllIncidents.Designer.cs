namespace SportsProUserInterfaceLayer
{
    partial class FrmViewAllIncidents
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
            this.dgvAllIncidents = new System.Windows.Forms.DataGridView();
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllIncidents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllIncidents
            // 
            this.dgvAllIncidents.AllowUserToAddRows = false;
            this.dgvAllIncidents.AllowUserToDeleteRows = false;
            this.dgvAllIncidents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllIncidents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllIncidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllIncidents.Location = new System.Drawing.Point(12, 12);
            this.dgvAllIncidents.Name = "dgvAllIncidents";
            this.dgvAllIncidents.ReadOnly = true;
            this.dgvAllIncidents.RowTemplate.Height = 24;
            this.dgvAllIncidents.Size = new System.Drawing.Size(1037, 574);
            this.dgvAllIncidents.TabIndex = 0;
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnToMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(887, 671);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(162, 47);
            this.btnReturnToMainMenu.TabIndex = 1;
            this.btnReturnToMainMenu.Text = "Return to Main Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.BtnReturnToMainMenu_Click);
            // 
            // FrmViewAllIncidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReturnToMainMenu;
            this.ClientSize = new System.Drawing.Size(1061, 730);
            this.ControlBox = false;
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Controls.Add(this.dgvAllIncidents);
            this.Name = "FrmViewAllIncidents";
            this.Text = "List of All Incidents";
            this.Load += new System.EventHandler(this.FrmViewAllIncidents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllIncidents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllIncidents;
        private System.Windows.Forms.Button btnReturnToMainMenu;
    }
}