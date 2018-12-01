namespace SportsProUserInterfaceLayer
{
    partial class FrmAddRegistration
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
            this.lblCustNameOutputDesc = new System.Windows.Forms.Label();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.lblProductOutputDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCustNameOutputDesc
            // 
            this.lblCustNameOutputDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCustNameOutputDesc.Location = new System.Drawing.Point(174, 166);
            this.lblCustNameOutputDesc.Name = "lblCustNameOutputDesc";
            this.lblCustNameOutputDesc.Size = new System.Drawing.Size(113, 17);
            this.lblCustNameOutputDesc.TabIndex = 0;
            this.lblCustNameOutputDesc.Text = "Customer Name:";
            // 
            // cboProduct
            // 
            this.cboProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(569, 209);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(321, 24);
            this.cboProduct.TabIndex = 1;
            // 
            // btnRegistration
            // 
            this.btnRegistration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistration.Location = new System.Drawing.Point(177, 265);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(321, 49);
            this.btnRegistration.TabIndex = 2;
            this.btnRegistration.Text = "Registration";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.BtnRegistration_Click);
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReturnToMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(569, 265);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(321, 49);
            this.btnReturnToMainMenu.TabIndex = 3;
            this.btnReturnToMainMenu.Text = "Return to Main Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.BtnReturnToMainMenu_Click);
            // 
            // cboCustomer
            // 
            this.cboCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(177, 209);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(321, 24);
            this.cboCustomer.TabIndex = 0;
            // 
            // lblProductOutputDesc
            // 
            this.lblProductOutputDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductOutputDesc.Location = new System.Drawing.Point(566, 166);
            this.lblProductOutputDesc.Name = "lblProductOutputDesc";
            this.lblProductOutputDesc.Size = new System.Drawing.Size(61, 17);
            this.lblProductOutputDesc.TabIndex = 1;
            this.lblProductOutputDesc.Text = "Product:";
            // 
            // FrmAddRegistration
            // 
            this.AcceptButton = this.btnRegistration;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReturnToMainMenu;
            this.ClientSize = new System.Drawing.Size(1097, 512);
            this.ControlBox = false;
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.lblCustNameOutputDesc);
            this.Controls.Add(this.cboCustomer);
            this.Controls.Add(this.cboProduct);
            this.Controls.Add(this.lblProductOutputDesc);
            this.Name = "FrmAddRegistration";
            this.Text = "Add Registration";
            this.Load += new System.EventHandler(this.FrmAddRegistration_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCustNameOutputDesc;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Label lblProductOutputDesc;
        private System.Windows.Forms.Button btnReturnToMainMenu;
        public System.Windows.Forms.ComboBox cboCustomer;
        public System.Windows.Forms.ComboBox cboProduct;
    }
}