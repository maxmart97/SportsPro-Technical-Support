namespace SportsProUserInterfaceLayer.Forms
{
    partial class FrmTitleScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTitleScreen));
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblUsernameInputDesc = new System.Windows.Forms.Label();
            this.lblPasswordInputDesc = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.ForeColor = System.Drawing.Color.Blue;
            this.lblCompany.Location = new System.Drawing.Point(233, 157);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(986, 71);
            this.lblCompany.TabIndex = 0;
            this.lblCompany.Text = "SportsPro Technical Support";
            // 
            // lblUsernameInputDesc
            // 
            this.lblUsernameInputDesc.AutoSize = true;
            this.lblUsernameInputDesc.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameInputDesc.Location = new System.Drawing.Point(398, 340);
            this.lblUsernameInputDesc.Name = "lblUsernameInputDesc";
            this.lblUsernameInputDesc.Size = new System.Drawing.Size(185, 37);
            this.lblUsernameInputDesc.TabIndex = 1;
            this.lblUsernameInputDesc.Text = "Username:";
            // 
            // lblPasswordInputDesc
            // 
            this.lblPasswordInputDesc.AutoSize = true;
            this.lblPasswordInputDesc.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordInputDesc.Location = new System.Drawing.Point(398, 451);
            this.lblPasswordInputDesc.Name = "lblPasswordInputDesc";
            this.lblPasswordInputDesc.Size = new System.Drawing.Size(180, 37);
            this.lblPasswordInputDesc.TabIndex = 2;
            this.lblPasswordInputDesc.Text = "Password:";
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(634, 342);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(367, 38);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.WordWrap = false;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(634, 453);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(367, 38);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.WordWrap = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(577, 578);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(294, 65);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // FrmTitleScreen
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1464, 798);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lblPasswordInputDesc);
            this.Controls.Add(this.lblUsernameInputDesc);
            this.Controls.Add(this.lblCompany);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTitleScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblUsernameInputDesc;
        private System.Windows.Forms.Label lblPasswordInputDesc;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}