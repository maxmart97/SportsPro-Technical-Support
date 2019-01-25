namespace SportsProUserInterfaceLayer.Forms
{
    partial class FrmContactDeveloper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContactDeveloper));
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            this.lblInputDescName = new System.Windows.Forms.Label();
            this.lblInputDescEmail = new System.Windows.Forms.Label();
            this.lblInputDescQuestion = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.rtbQuestion = new System.Windows.Forms.RichTextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnToMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(1272, 637);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(162, 47);
            this.btnReturnToMainMenu.TabIndex = 4;
            this.btnReturnToMainMenu.Text = "Return to Main Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.BtnReturnToMainMenu_Click);
            // 
            // lblInputDescName
            // 
            this.lblInputDescName.AutoSize = true;
            this.lblInputDescName.Location = new System.Drawing.Point(401, 120);
            this.lblInputDescName.Name = "lblInputDescName";
            this.lblInputDescName.Size = new System.Drawing.Size(49, 17);
            this.lblInputDescName.TabIndex = 4;
            this.lblInputDescName.Text = "Name:";
            // 
            // lblInputDescEmail
            // 
            this.lblInputDescEmail.AutoSize = true;
            this.lblInputDescEmail.Location = new System.Drawing.Point(401, 196);
            this.lblInputDescEmail.Name = "lblInputDescEmail";
            this.lblInputDescEmail.Size = new System.Drawing.Size(46, 17);
            this.lblInputDescEmail.TabIndex = 5;
            this.lblInputDescEmail.Text = "Email:";
            // 
            // lblInputDescQuestion
            // 
            this.lblInputDescQuestion.AutoSize = true;
            this.lblInputDescQuestion.Location = new System.Drawing.Point(401, 285);
            this.lblInputDescQuestion.Name = "lblInputDescQuestion";
            this.lblInputDescQuestion.Size = new System.Drawing.Size(69, 17);
            this.lblInputDescQuestion.TabIndex = 6;
            this.lblInputDescQuestion.Text = "Question:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(494, 193);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(500, 22);
            this.tbEmail.TabIndex = 1;
            // 
            // rtbQuestion
            // 
            this.rtbQuestion.Location = new System.Drawing.Point(494, 285);
            this.rtbQuestion.Name = "rtbQuestion";
            this.rtbQuestion.Size = new System.Drawing.Size(500, 171);
            this.rtbQuestion.TabIndex = 2;
            this.rtbQuestion.Text = "";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(494, 117);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(500, 22);
            this.tbName.TabIndex = 0;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(606, 49);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(237, 17);
            this.lblInstructions.TabIndex = 10;
            this.lblInstructions.Text = "Fill out form below and click \'Submit.\'";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(573, 535);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(294, 65);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // FrmContactDeveloper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 696);
            this.ControlBox = false;
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.rtbQuestion);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblInputDescQuestion);
            this.Controls.Add(this.lblInputDescEmail);
            this.Controls.Add(this.lblInputDescName);
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmContactDeveloper";
            this.Text = "Contact Developer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnToMainMenu;
        private System.Windows.Forms.Label lblInputDescName;
        private System.Windows.Forms.Label lblInputDescEmail;
        private System.Windows.Forms.Label lblInputDescQuestion;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.RichTextBox rtbQuestion;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnSubmit;
    }
}