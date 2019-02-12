namespace SportsProUserInterfaceLayer.Forms
{
    partial class FrmAddTechnician
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblNameInputDesc = new System.Windows.Forms.Label();
            this.lblEmailInputDesc = new System.Windows.Forms.Label();
            this.lblPhoneInputDesc = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.btnAddTechnician = new System.Windows.Forms.Button();
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(512, 116);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(396, 17);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Fill out the technician\'s information and click \'Add Technician.\'";
            // 
            // lblNameInputDesc
            // 
            this.lblNameInputDesc.AutoSize = true;
            this.lblNameInputDesc.Location = new System.Drawing.Point(512, 192);
            this.lblNameInputDesc.Name = "lblNameInputDesc";
            this.lblNameInputDesc.Size = new System.Drawing.Size(54, 17);
            this.lblNameInputDesc.TabIndex = 1;
            this.lblNameInputDesc.Text = "*Name:";
            // 
            // lblEmailInputDesc
            // 
            this.lblEmailInputDesc.AutoSize = true;
            this.lblEmailInputDesc.Location = new System.Drawing.Point(512, 253);
            this.lblEmailInputDesc.Name = "lblEmailInputDesc";
            this.lblEmailInputDesc.Size = new System.Drawing.Size(51, 17);
            this.lblEmailInputDesc.TabIndex = 2;
            this.lblEmailInputDesc.Text = "*Email:";
            // 
            // lblPhoneInputDesc
            // 
            this.lblPhoneInputDesc.AutoSize = true;
            this.lblPhoneInputDesc.Location = new System.Drawing.Point(512, 310);
            this.lblPhoneInputDesc.Name = "lblPhoneInputDesc";
            this.lblPhoneInputDesc.Size = new System.Drawing.Size(58, 17);
            this.lblPhoneInputDesc.TabIndex = 3;
            this.lblPhoneInputDesc.Text = "*Phone:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(578, 192);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(312, 22);
            this.tbName.TabIndex = 4;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(578, 253);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(312, 22);
            this.tbEmail.TabIndex = 5;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(578, 310);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(312, 22);
            this.tbPhone.TabIndex = 6;
            // 
            // btnAddTechnician
            // 
            this.btnAddTechnician.Location = new System.Drawing.Point(557, 430);
            this.btnAddTechnician.Name = "btnAddTechnician";
            this.btnAddTechnician.Size = new System.Drawing.Size(294, 65);
            this.btnAddTechnician.TabIndex = 7;
            this.btnAddTechnician.Text = "Add Technician";
            this.btnAddTechnician.UseVisualStyleBackColor = true;
            this.btnAddTechnician.Click += new System.EventHandler(this.BtnAddTechnician_Click);
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnToMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(1282, 742);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(162, 47);
            this.btnReturnToMainMenu.TabIndex = 8;
            this.btnReturnToMainMenu.Text = "Return to Main Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.btnReturnToMainMenu_Click);
            // 
            // FrmAddTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 801);
            this.ControlBox = false;
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Controls.Add(this.btnAddTechnician);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblPhoneInputDesc);
            this.Controls.Add(this.lblEmailInputDesc);
            this.Controls.Add(this.lblNameInputDesc);
            this.Controls.Add(this.lblInstructions);
            this.Name = "FrmAddTechnician";
            this.Text = "Add Technician";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblNameInputDesc;
        private System.Windows.Forms.Label lblEmailInputDesc;
        private System.Windows.Forms.Label lblPhoneInputDesc;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Button btnAddTechnician;
        private System.Windows.Forms.Button btnReturnToMainMenu;
    }
}