namespace SportsProUserInterfaceLayer.Forms
{
    partial class FrmViewAllTechnicians
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewAllTechnicians));
            this.dgvAllTechnicians = new System.Windows.Forms.DataGridView();
            this.techIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTechnicians = new System.Windows.Forms.BindingSource(this.components);
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTechnicians)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTechnicians)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllTechnicians
            // 
            this.dgvAllTechnicians.AllowUserToAddRows = false;
            this.dgvAllTechnicians.AllowUserToDeleteRows = false;
            this.dgvAllTechnicians.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllTechnicians.AutoGenerateColumns = false;
            this.dgvAllTechnicians.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllTechnicians.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllTechnicians.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.techIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dgvAllTechnicians.DataSource = this.bsTechnicians;
            this.dgvAllTechnicians.Location = new System.Drawing.Point(12, 12);
            this.dgvAllTechnicians.Name = "dgvAllTechnicians";
            this.dgvAllTechnicians.ReadOnly = true;
            this.dgvAllTechnicians.RowTemplate.Height = 24;
            this.dgvAllTechnicians.Size = new System.Drawing.Size(1037, 574);
            this.dgvAllTechnicians.TabIndex = 4;
            // 
            // techIDDataGridViewTextBoxColumn
            // 
            this.techIDDataGridViewTextBoxColumn.DataPropertyName = "TechID";
            this.techIDDataGridViewTextBoxColumn.HeaderText = "TechID";
            this.techIDDataGridViewTextBoxColumn.Name = "techIDDataGridViewTextBoxColumn";
            this.techIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsTechnicians
            // 
            this.bsTechnicians.DataSource = typeof(SportsProUserInterfaceLayer.LINQ_to_SQL.Technician);
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnToMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(887, 671);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(162, 47);
            this.btnReturnToMainMenu.TabIndex = 5;
            this.btnReturnToMainMenu.Text = "Return to Main Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.BtnReturnToMainMenu_Click);
            // 
            // FrmViewAllTechnicians
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 730);
            this.ControlBox = false;
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Controls.Add(this.dgvAllTechnicians);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmViewAllTechnicians";
            this.Text = "List of All Technicians";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTechnicians)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTechnicians)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllTechnicians;
        private System.Windows.Forms.Button btnReturnToMainMenu;
        private System.Windows.Forms.BindingSource bsTechnicians;
        private System.Windows.Forms.DataGridViewTextBoxColumn techIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
    }
}