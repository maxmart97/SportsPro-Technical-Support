namespace SportsProUserInterfaceLayer.Forms
{
    partial class FrmUpdateTechnician
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
            System.Windows.Forms.Label lblEmail;
            System.Windows.Forms.Label lblPhone;
            this.lbTechnicians = new System.Windows.Forms.ListBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.bsTechnicians = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpdateTechnician = new System.Windows.Forms.Button();
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            lblName = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblPhone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsTechnicians)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTechnicians
            // 
            this.lbTechnicians.DataSource = this.bsTechnicians;
            this.lbTechnicians.DisplayMember = "Name";
            this.lbTechnicians.FormattingEnabled = true;
            this.lbTechnicians.ItemHeight = 16;
            this.lbTechnicians.Location = new System.Drawing.Point(663, 56);
            this.lbTechnicians.Name = "lbTechnicians";
            this.lbTechnicians.Size = new System.Drawing.Size(251, 212);
            this.lbTechnicians.TabIndex = 5;
            this.lbTechnicians.ValueMember = "TechID";
            this.lbTechnicians.SelectedIndexChanged += new System.EventHandler(this.LbTechnicians_SelectedIndexChanged);
            // 
            // lblInstructions
            // 
            this.lblInstructions.Location = new System.Drawing.Point(449, 147);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(189, 66);
            this.lblInstructions.TabIndex = 4;
            this.lblInstructions.Text = "Select a Technician and then modify his or her information in the textboxes.";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(484, 307);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(54, 17);
            lblName.TabIndex = 36;
            lblName.Text = "*Name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(567, 304);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(337, 22);
            this.tbName.TabIndex = 35;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(484, 357);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(51, 17);
            lblEmail.TabIndex = 38;
            lblEmail.Text = "*Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(567, 354);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(337, 22);
            this.tbEmail.TabIndex = 37;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new System.Drawing.Point(484, 405);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new System.Drawing.Size(58, 17);
            lblPhone.TabIndex = 40;
            lblPhone.Text = "*Phone:";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(567, 402);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(337, 22);
            this.tbPhone.TabIndex = 39;
            // 
            // bsTechnicians
            // 
            this.bsTechnicians.DataSource = typeof(SportsProUserInterfaceLayer.Technician);
            // 
            // btnUpdateTechnician
            // 
            this.btnUpdateTechnician.Location = new System.Drawing.Point(567, 485);
            this.btnUpdateTechnician.Name = "btnUpdateTechnician";
            this.btnUpdateTechnician.Size = new System.Drawing.Size(294, 65);
            this.btnUpdateTechnician.TabIndex = 41;
            this.btnUpdateTechnician.Text = "Update Technician";
            this.btnUpdateTechnician.UseVisualStyleBackColor = true;
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnToMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(1282, 742);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(162, 47);
            this.btnReturnToMainMenu.TabIndex = 42;
            this.btnReturnToMainMenu.Text = "Return to Main Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.BtnReturnToMainMenu_Click);
            // 
            // FrmUpdateTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 801);
            this.ControlBox = false;
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Controls.Add(this.btnUpdateTechnician);
            this.Controls.Add(lblPhone);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(lblEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(lblName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbTechnicians);
            this.Controls.Add(this.lblInstructions);
            this.Name = "FrmUpdateTechnician";
            this.Text = "Update Technician";
            this.Load += new System.EventHandler(this.FrmUpdateTechnician_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsTechnicians)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTechnicians;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.BindingSource bsTechnicians;
        private System.Windows.Forms.Button btnUpdateTechnician;
        private System.Windows.Forms.Button btnReturnToMainMenu;
    }
}