namespace SportsProUserInterfaceLayer.Forms
{
    partial class FrmDeleteTechnician
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
            System.Windows.Forms.Label lblOutputDescPhone;
            System.Windows.Forms.Label lblOutputDescEmail;
            System.Windows.Forms.Label lblOutputDescName;
            this.lbTechnicians = new System.Windows.Forms.ListBox();
            this.bsTechnicians = new System.Windows.Forms.BindingSource(this.components);
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnDeleteTechnician = new System.Windows.Forms.Button();
            lblOutputDescPhone = new System.Windows.Forms.Label();
            lblOutputDescEmail = new System.Windows.Forms.Label();
            lblOutputDescName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsTechnicians)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOutputDescPhone
            // 
            lblOutputDescPhone.AutoSize = true;
            lblOutputDescPhone.Location = new System.Drawing.Point(487, 431);
            lblOutputDescPhone.Name = "lblOutputDescPhone";
            lblOutputDescPhone.Size = new System.Drawing.Size(58, 17);
            lblOutputDescPhone.TabIndex = 43;
            lblOutputDescPhone.Text = "*Phone:";
            // 
            // lblOutputDescEmail
            // 
            lblOutputDescEmail.AutoSize = true;
            lblOutputDescEmail.Location = new System.Drawing.Point(487, 376);
            lblOutputDescEmail.Name = "lblOutputDescEmail";
            lblOutputDescEmail.Size = new System.Drawing.Size(51, 17);
            lblOutputDescEmail.TabIndex = 42;
            lblOutputDescEmail.Text = "*Email:";
            // 
            // lblOutputDescName
            // 
            lblOutputDescName.AutoSize = true;
            lblOutputDescName.Location = new System.Drawing.Point(487, 326);
            lblOutputDescName.Name = "lblOutputDescName";
            lblOutputDescName.Size = new System.Drawing.Size(54, 17);
            lblOutputDescName.TabIndex = 41;
            lblOutputDescName.Text = "*Name:";
            // 
            // lbTechnicians
            // 
            this.lbTechnicians.DataSource = this.bsTechnicians;
            this.lbTechnicians.DisplayMember = "Name";
            this.lbTechnicians.FormattingEnabled = true;
            this.lbTechnicians.ItemHeight = 16;
            this.lbTechnicians.Location = new System.Drawing.Point(661, 55);
            this.lbTechnicians.Name = "lbTechnicians";
            this.lbTechnicians.Size = new System.Drawing.Size(251, 212);
            this.lbTechnicians.TabIndex = 7;
            this.lbTechnicians.ValueMember = "TechID";
            this.lbTechnicians.SelectedIndexChanged += new System.EventHandler(this.LbTechnicians_SelectedIndexChanged);
            // 
            // bsTechnicians
            // 
            this.bsTechnicians.DataSource = typeof(SportsProUserInterfaceLayer.Technician);
            // 
            // lblInstructions
            // 
            this.lblInstructions.Location = new System.Drawing.Point(466, 141);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(189, 66);
            this.lblInstructions.TabIndex = 6;
            this.lblInstructions.Text = "Select a Technician and click \'Delete Technician.\'";
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Location = new System.Drawing.Point(582, 319);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(330, 31);
            this.lblName.TabIndex = 113;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmail.Location = new System.Drawing.Point(582, 369);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(330, 31);
            this.lblEmail.TabIndex = 114;
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPhone
            // 
            this.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPhone.Location = new System.Drawing.Point(582, 424);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(330, 31);
            this.lblPhone.TabIndex = 115;
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDeleteTechnician
            // 
            this.btnDeleteTechnician.Location = new System.Drawing.Point(569, 534);
            this.btnDeleteTechnician.Name = "btnDeleteTechnician";
            this.btnDeleteTechnician.Size = new System.Drawing.Size(294, 65);
            this.btnDeleteTechnician.TabIndex = 116;
            this.btnDeleteTechnician.Text = "Delete Technician";
            this.btnDeleteTechnician.UseVisualStyleBackColor = true;
            this.btnDeleteTechnician.Click += new System.EventHandler(this.BtnDeleteTechnician_Click);
            // 
            // FrmDeleteTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 801);
            this.ControlBox = false;
            this.Controls.Add(this.btnDeleteTechnician);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(lblOutputDescPhone);
            this.Controls.Add(lblOutputDescEmail);
            this.Controls.Add(lblOutputDescName);
            this.Controls.Add(this.lbTechnicians);
            this.Controls.Add(this.lblInstructions);
            this.Name = "FrmDeleteTechnician";
            this.Text = "Delete Technician";
            this.Load += new System.EventHandler(this.FrmDeleteTechnician_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsTechnicians)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTechnicians;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnDeleteTechnician;
        private System.Windows.Forms.BindingSource bsTechnicians;
    }
}