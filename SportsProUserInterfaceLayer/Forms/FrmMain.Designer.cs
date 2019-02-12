namespace SportsProUserInterfaceLayer
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.msMainMenuForm = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMaintainCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMaintainIncidents = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddIncident = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateIncident = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteIncident = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMaintainProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMaintainRegistrations = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMaintainTechnicians = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddTechnician = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateTechnician = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteTechnician = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDisplayAllCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIncidents = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDisplayAllIncidents = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDisplayIncidentsByTechnician = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDisplayOpenIncidentsByTechnician = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDisplayIncidentsByCustByState = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRegistrations = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDisplayRegByProd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTechnicians = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMainMenuForm = new System.Windows.Forms.StatusStrip();
            this.tsslMainMenuForm = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsmiDisplayAllProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDisplayAllRegistrations = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDisplayAllTechnicians = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiContactDeveloper = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenuForm.SuspendLayout();
            this.ssMainMenuForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainMenuForm
            // 
            this.msMainMenuForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMainMenuForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiMaintenance,
            this.tsmiCustomers,
            this.tsmiIncidents,
            this.tsmiProducts,
            this.tsmiRegistrations,
            this.tsmiTechnicians,
            this.tsmiHelp});
            this.msMainMenuForm.Location = new System.Drawing.Point(0, 0);
            this.msMainMenuForm.Name = "msMainMenuForm";
            this.msMainMenuForm.Size = new System.Drawing.Size(1464, 28);
            this.msMainMenuForm.TabIndex = 1;
            this.msMainMenuForm.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLogout,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(44, 24);
            this.tsmiFile.Text = "File";
            // 
            // tsmiLogout
            // 
            this.tsmiLogout.Name = "tsmiLogout";
            this.tsmiLogout.Size = new System.Drawing.Size(131, 26);
            this.tsmiLogout.Text = "Logout";
            this.tsmiLogout.Click += new System.EventHandler(this.LogoutUser);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(131, 26);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.ExitApplication);
            // 
            // tsmiMaintenance
            // 
            this.tsmiMaintenance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMaintainCustomers,
            this.tsmiMaintainIncidents,
            this.tsmiMaintainProducts,
            this.tsmiMaintainRegistrations,
            this.tsmiMaintainTechnicians});
            this.tsmiMaintenance.Name = "tsmiMaintenance";
            this.tsmiMaintenance.Size = new System.Drawing.Size(106, 24);
            this.tsmiMaintenance.Text = "Maintenance";
            // 
            // tsmiMaintainCustomers
            // 
            this.tsmiMaintainCustomers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddCustomer,
            this.tsmiUpdateCustomer,
            this.tsmiDeleteCustomer});
            this.tsmiMaintainCustomers.Name = "tsmiMaintainCustomers";
            this.tsmiMaintainCustomers.Size = new System.Drawing.Size(232, 26);
            this.tsmiMaintainCustomers.Text = "Maintain Customers";
            // 
            // tsmiAddCustomer
            // 
            this.tsmiAddCustomer.Name = "tsmiAddCustomer";
            this.tsmiAddCustomer.Size = new System.Drawing.Size(200, 26);
            this.tsmiAddCustomer.Text = "Add Customer";
            this.tsmiAddCustomer.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiUpdateCustomer
            // 
            this.tsmiUpdateCustomer.Name = "tsmiUpdateCustomer";
            this.tsmiUpdateCustomer.Size = new System.Drawing.Size(200, 26);
            this.tsmiUpdateCustomer.Text = "Update Customer";
            this.tsmiUpdateCustomer.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiDeleteCustomer
            // 
            this.tsmiDeleteCustomer.Name = "tsmiDeleteCustomer";
            this.tsmiDeleteCustomer.Size = new System.Drawing.Size(200, 26);
            this.tsmiDeleteCustomer.Text = "Delete Customer";
            this.tsmiDeleteCustomer.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiMaintainIncidents
            // 
            this.tsmiMaintainIncidents.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddIncident,
            this.tsmiUpdateIncident,
            this.tsmiDeleteIncident});
            this.tsmiMaintainIncidents.Name = "tsmiMaintainIncidents";
            this.tsmiMaintainIncidents.Size = new System.Drawing.Size(232, 26);
            this.tsmiMaintainIncidents.Text = "Maintain Incidents";
            // 
            // tsmiAddIncident
            // 
            this.tsmiAddIncident.Name = "tsmiAddIncident";
            this.tsmiAddIncident.Size = new System.Drawing.Size(190, 26);
            this.tsmiAddIncident.Text = "Add Incident";
            this.tsmiAddIncident.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiUpdateIncident
            // 
            this.tsmiUpdateIncident.Name = "tsmiUpdateIncident";
            this.tsmiUpdateIncident.Size = new System.Drawing.Size(190, 26);
            this.tsmiUpdateIncident.Text = "Update Incident";
            this.tsmiUpdateIncident.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiDeleteIncident
            // 
            this.tsmiDeleteIncident.Name = "tsmiDeleteIncident";
            this.tsmiDeleteIncident.Size = new System.Drawing.Size(190, 26);
            this.tsmiDeleteIncident.Text = "Delete Incident";
            this.tsmiDeleteIncident.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiMaintainProducts
            // 
            this.tsmiMaintainProducts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddProduct,
            this.tsmiUpdateProduct,
            this.tsmiDeleteProduct});
            this.tsmiMaintainProducts.Name = "tsmiMaintainProducts";
            this.tsmiMaintainProducts.Size = new System.Drawing.Size(232, 26);
            this.tsmiMaintainProducts.Text = "Maintain Products";
            // 
            // tsmiAddProduct
            // 
            this.tsmiAddProduct.Name = "tsmiAddProduct";
            this.tsmiAddProduct.Size = new System.Drawing.Size(188, 26);
            this.tsmiAddProduct.Text = "Add Product";
            this.tsmiAddProduct.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiUpdateProduct
            // 
            this.tsmiUpdateProduct.Name = "tsmiUpdateProduct";
            this.tsmiUpdateProduct.Size = new System.Drawing.Size(188, 26);
            this.tsmiUpdateProduct.Text = "Update Product";
            this.tsmiUpdateProduct.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiDeleteProduct
            // 
            this.tsmiDeleteProduct.Name = "tsmiDeleteProduct";
            this.tsmiDeleteProduct.Size = new System.Drawing.Size(188, 26);
            this.tsmiDeleteProduct.Text = "Delete Product";
            this.tsmiDeleteProduct.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiMaintainRegistrations
            // 
            this.tsmiMaintainRegistrations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddRegistration,
            this.tsmiUpdateRegistration,
            this.tsmiDeleteRegistration});
            this.tsmiMaintainRegistrations.Name = "tsmiMaintainRegistrations";
            this.tsmiMaintainRegistrations.Size = new System.Drawing.Size(232, 26);
            this.tsmiMaintainRegistrations.Text = "Maintain Registrations";
            // 
            // tsmiAddRegistration
            // 
            this.tsmiAddRegistration.Name = "tsmiAddRegistration";
            this.tsmiAddRegistration.Size = new System.Drawing.Size(217, 26);
            this.tsmiAddRegistration.Text = "Add Registration";
            this.tsmiAddRegistration.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiUpdateRegistration
            // 
            this.tsmiUpdateRegistration.Name = "tsmiUpdateRegistration";
            this.tsmiUpdateRegistration.Size = new System.Drawing.Size(217, 26);
            this.tsmiUpdateRegistration.Text = "Update Registration";
            this.tsmiUpdateRegistration.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiDeleteRegistration
            // 
            this.tsmiDeleteRegistration.Name = "tsmiDeleteRegistration";
            this.tsmiDeleteRegistration.Size = new System.Drawing.Size(217, 26);
            this.tsmiDeleteRegistration.Text = "Delete Registration";
            this.tsmiDeleteRegistration.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiMaintainTechnicians
            // 
            this.tsmiMaintainTechnicians.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddTechnician,
            this.tsmiUpdateTechnician,
            this.tsmiDeleteTechnician});
            this.tsmiMaintainTechnicians.Name = "tsmiMaintainTechnicians";
            this.tsmiMaintainTechnicians.Size = new System.Drawing.Size(232, 26);
            this.tsmiMaintainTechnicians.Text = "Maintain Technicians";
            // 
            // tsmiAddTechnician
            // 
            this.tsmiAddTechnician.Name = "tsmiAddTechnician";
            this.tsmiAddTechnician.Size = new System.Drawing.Size(206, 26);
            this.tsmiAddTechnician.Text = "Add Technician";
            this.tsmiAddTechnician.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiUpdateTechnician
            // 
            this.tsmiUpdateTechnician.Name = "tsmiUpdateTechnician";
            this.tsmiUpdateTechnician.Size = new System.Drawing.Size(206, 26);
            this.tsmiUpdateTechnician.Text = "Update Technician";
            this.tsmiUpdateTechnician.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiDeleteTechnician
            // 
            this.tsmiDeleteTechnician.Name = "tsmiDeleteTechnician";
            this.tsmiDeleteTechnician.Size = new System.Drawing.Size(206, 26);
            this.tsmiDeleteTechnician.Text = "Delete Technician";
            this.tsmiDeleteTechnician.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiCustomers
            // 
            this.tsmiCustomers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDisplayAllCustomers});
            this.tsmiCustomers.Name = "tsmiCustomers";
            this.tsmiCustomers.Size = new System.Drawing.Size(90, 24);
            this.tsmiCustomers.Text = "Customers";
            // 
            // tsmiDisplayAllCustomers
            // 
            this.tsmiDisplayAllCustomers.Name = "tsmiDisplayAllCustomers";
            this.tsmiDisplayAllCustomers.Size = new System.Drawing.Size(228, 26);
            this.tsmiDisplayAllCustomers.Text = "Display All Customers";
            this.tsmiDisplayAllCustomers.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiIncidents
            // 
            this.tsmiIncidents.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDisplayAllIncidents,
            this.tsmiDisplayIncidentsByTechnician,
            this.tsmiDisplayOpenIncidentsByTechnician,
            this.tsmiDisplayIncidentsByCustByState});
            this.tsmiIncidents.Name = "tsmiIncidents";
            this.tsmiIncidents.Size = new System.Drawing.Size(80, 24);
            this.tsmiIncidents.Text = "Incidents";
            // 
            // tsmiDisplayAllIncidents
            // 
            this.tsmiDisplayAllIncidents.Name = "tsmiDisplayAllIncidents";
            this.tsmiDisplayAllIncidents.Size = new System.Drawing.Size(341, 26);
            this.tsmiDisplayAllIncidents.Text = "Display All Incidents";
            this.tsmiDisplayAllIncidents.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiDisplayIncidentsByTechnician
            // 
            this.tsmiDisplayIncidentsByTechnician.Name = "tsmiDisplayIncidentsByTechnician";
            this.tsmiDisplayIncidentsByTechnician.Size = new System.Drawing.Size(341, 26);
            this.tsmiDisplayIncidentsByTechnician.Text = "Display Incidents By Technician";
            this.tsmiDisplayIncidentsByTechnician.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiDisplayOpenIncidentsByTechnician
            // 
            this.tsmiDisplayOpenIncidentsByTechnician.Name = "tsmiDisplayOpenIncidentsByTechnician";
            this.tsmiDisplayOpenIncidentsByTechnician.Size = new System.Drawing.Size(341, 26);
            this.tsmiDisplayOpenIncidentsByTechnician.Text = "Display Open Incidents By Technician";
            this.tsmiDisplayOpenIncidentsByTechnician.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiDisplayIncidentsByCustByState
            // 
            this.tsmiDisplayIncidentsByCustByState.Name = "tsmiDisplayIncidentsByCustByState";
            this.tsmiDisplayIncidentsByCustByState.Size = new System.Drawing.Size(341, 26);
            this.tsmiDisplayIncidentsByCustByState.Text = "Display Incidents by Customer by State";
            this.tsmiDisplayIncidentsByCustByState.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiProducts
            // 
            this.tsmiProducts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDisplayAllProducts});
            this.tsmiProducts.Name = "tsmiProducts";
            this.tsmiProducts.Size = new System.Drawing.Size(78, 24);
            this.tsmiProducts.Text = "Products";
            // 
            // tsmiRegistrations
            // 
            this.tsmiRegistrations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDisplayAllRegistrations,
            this.tsmiDisplayRegByProd});
            this.tsmiRegistrations.Name = "tsmiRegistrations";
            this.tsmiRegistrations.Size = new System.Drawing.Size(107, 24);
            this.tsmiRegistrations.Text = "Registrations";
            // 
            // tsmiDisplayRegByProd
            // 
            this.tsmiDisplayRegByProd.Name = "tsmiDisplayRegByProd";
            this.tsmiDisplayRegByProd.Size = new System.Drawing.Size(298, 26);
            this.tsmiDisplayRegByProd.Text = "Display Registrations by Product";
            this.tsmiDisplayRegByProd.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiTechnicians
            // 
            this.tsmiTechnicians.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDisplayAllTechnicians});
            this.tsmiTechnicians.Name = "tsmiTechnicians";
            this.tsmiTechnicians.Size = new System.Drawing.Size(96, 24);
            this.tsmiTechnicians.Text = "Technicians";
            // 
            // ssMainMenuForm
            // 
            this.ssMainMenuForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssMainMenuForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMainMenuForm,
            this.tsslVersion});
            this.ssMainMenuForm.Location = new System.Drawing.Point(0, 773);
            this.ssMainMenuForm.Name = "ssMainMenuForm";
            this.ssMainMenuForm.Size = new System.Drawing.Size(1464, 25);
            this.ssMainMenuForm.TabIndex = 2;
            this.ssMainMenuForm.Text = "statusStrip1";
            // 
            // tsslMainMenuForm
            // 
            this.tsslMainMenuForm.Name = "tsslMainMenuForm";
            this.tsslMainMenuForm.Size = new System.Drawing.Size(208, 20);
            this.tsslMainMenuForm.Text = "Developed by Maxwell Martin";
            // 
            // tsslVersion
            // 
            this.tsslVersion.Margin = new System.Windows.Forms.Padding(1145, 3, 0, 2);
            this.tsslVersion.Name = "tsslVersion";
            this.tsslVersion.Size = new System.Drawing.Size(91, 20);
            this.tsslVersion.Text = "Version 2.0.0";
            // 
            // tsmiDisplayAllProducts
            // 
            this.tsmiDisplayAllProducts.Name = "tsmiDisplayAllProducts";
            this.tsmiDisplayAllProducts.Size = new System.Drawing.Size(216, 26);
            this.tsmiDisplayAllProducts.Text = "Display All Products";
            this.tsmiDisplayAllProducts.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiDisplayAllRegistrations
            // 
            this.tsmiDisplayAllRegistrations.Name = "tsmiDisplayAllRegistrations";
            this.tsmiDisplayAllRegistrations.Size = new System.Drawing.Size(298, 26);
            this.tsmiDisplayAllRegistrations.Text = "Display All Registrations";
            this.tsmiDisplayAllRegistrations.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiDisplayAllTechnicians
            // 
            this.tsmiDisplayAllTechnicians.Name = "tsmiDisplayAllTechnicians";
            this.tsmiDisplayAllTechnicians.Size = new System.Drawing.Size(234, 26);
            this.tsmiDisplayAllTechnicians.Text = "Display All Technicians";
            this.tsmiDisplayAllTechnicians.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiContactDeveloper});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(53, 24);
            this.tsmiHelp.Text = "Help";
            // 
            // tsmiContactDeveloper
            // 
            this.tsmiContactDeveloper.Name = "tsmiContactDeveloper";
            this.tsmiContactDeveloper.Size = new System.Drawing.Size(216, 26);
            this.tsmiContactDeveloper.Text = "Contact Developer";
            this.tsmiContactDeveloper.Click += new System.EventHandler(this.DisplayForm);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 798);
            this.Controls.Add(this.ssMainMenuForm);
            this.Controls.Add(this.msMainMenuForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMainMenuForm;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SportsPro Technical Support";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.msMainMenuForm.ResumeLayout(false);
            this.msMainMenuForm.PerformLayout();
            this.ssMainMenuForm.ResumeLayout(false);
            this.ssMainMenuForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenuForm;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiMaintenance;
        private System.Windows.Forms.ToolStripMenuItem tsmiMaintainProducts;
        private System.Windows.Forms.ToolStripMenuItem tsmiMaintainCustomers;
        private System.Windows.Forms.ToolStripMenuItem tsmiMaintainRegistrations;
        private System.Windows.Forms.ToolStripMenuItem tsmiMaintainTechnicians;
        private System.Windows.Forms.ToolStripMenuItem tsmiRegistrations;
        private System.Windows.Forms.ToolStripMenuItem tsmiIncidents;
        private System.Windows.Forms.ToolStripMenuItem tsmiDisplayAllIncidents;
        private System.Windows.Forms.ToolStripMenuItem tsmiDisplayIncidentsByTechnician;
        private System.Windows.Forms.StatusStrip ssMainMenuForm;
        private System.Windows.Forms.ToolStripStatusLabel tsslMainMenuForm;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddProduct;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateProduct;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteProduct;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddRegistration;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateRegistration;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteRegistration;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddTechnician;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateTechnician;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteTechnician;
        private System.Windows.Forms.ToolStripMenuItem tsmiDisplayOpenIncidentsByTechnician;
        private System.Windows.Forms.ToolStripMenuItem tsmiMaintainIncidents;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddIncident;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateIncident;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteIncident;
        private System.Windows.Forms.ToolStripMenuItem tsmiDisplayRegByProd;
        private System.Windows.Forms.ToolStripMenuItem tsmiDisplayIncidentsByCustByState;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersion;
        private System.Windows.Forms.ToolStripMenuItem tsmiCustomers;
        private System.Windows.Forms.ToolStripMenuItem tsmiProducts;
        private System.Windows.Forms.ToolStripMenuItem tsmiTechnicians;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogout;
        private System.Windows.Forms.ToolStripMenuItem tsmiDisplayAllCustomers;
        private System.Windows.Forms.ToolStripMenuItem tsmiDisplayAllProducts;
        private System.Windows.Forms.ToolStripMenuItem tsmiDisplayAllRegistrations;
        private System.Windows.Forms.ToolStripMenuItem tsmiDisplayAllTechnicians;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiContactDeveloper;
    }
}

