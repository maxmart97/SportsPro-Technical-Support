using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportsProBLLClassLibrary;
using SportsProUserInterfaceLayer.Forms;

namespace SportsProUserInterfaceLayer
{
    public partial class FrmMain : Form
    {
        //Instances of the currently available forms.

        //Customers Forms
        static FrmAddCustomer addCustomerFrm = new FrmAddCustomer();
        static FrmUpdateCustomer updateCustomerFrm = new FrmUpdateCustomer();
        static FrmDeleteCustomer deleteCustomerFrm = new FrmDeleteCustomer();
        static FrmViewAllCustomers allCustomersFrm = new FrmViewAllCustomers();

        //Incidents Forms
        static FrmAddIncident addIncidentFrm = new FrmAddIncident();
        static FrmUpdateIncident updateIncidentFrm = new FrmUpdateIncident();
        static FrmDeleteIncident deleteIncidentFrm = new FrmDeleteIncident();
        static FrmViewAllIncidents allIncidentsFrm = new FrmViewAllIncidents();
        static FrmViewIncidentsByTechnician allIncidentsByTechnicianFrm = new FrmViewIncidentsByTechnician();
        static FrmOpenIncidentsByTechnician allOpenIncidentsByTechnicianFrm = new FrmOpenIncidentsByTechnician();
        static FrmIncidentsByCustomerByState incidentByCustomerByStateFrm = new FrmIncidentsByCustomerByState();

        //Products Forms
        static FrmAddProduct addProductFrm = new FrmAddProduct();
        static FrmUpdateProduct updateProductFrm = new FrmUpdateProduct();
        static FrmDeleteProduct deleteProductFrm = new FrmDeleteProduct();

        //Registrations Forms
        static FrmAddRegistration addRegistrationFrm = new FrmAddRegistration();
        static FrmUpdateRegistration updateRegistrationFrm = new FrmUpdateRegistration();
        static FrmDeleteRegistration deleteRegistrationFrm = new FrmDeleteRegistration();
        static FrmRegistrationsByProduct registrationsByProductFrm = new FrmRegistrationsByProduct();

        //Technicians Forms
        static FrmAddTechnician addTechnicianFrm = new FrmAddTechnician();
        static FrmUpdateTechnician updateTechnicianFrm = new FrmUpdateTechnician();
        static FrmDeleteTechnician deleteTechnicianFrm = new FrmDeleteTechnician();

        public FrmMain()
        {
            InitializeComponent();

            //Properly formats all instances of child forms when main form is constructed.
            FormatAllForms();
        }

        /// <summary>
        /// Method to hold and execute all calls to the FormatMdiChild method.
        /// </summary>
        private void FormatAllForms()
        {
            GenericMethods.FormatMdiChild(allIncidentsFrm, this);
            GenericMethods.FormatMdiChild(allIncidentsByTechnicianFrm, this);
            GenericMethods.FormatMdiChild(allOpenIncidentsByTechnicianFrm, this);
            GenericMethods.FormatMdiChild(addRegistrationFrm, this);
            GenericMethods.FormatMdiChild(incidentByCustomerByStateFrm, this);
            GenericMethods.FormatMdiChild(registrationsByProductFrm, this);
            GenericMethods.FormatMdiChild(addCustomerFrm, this);
            GenericMethods.FormatMdiChild(updateCustomerFrm, this);
            GenericMethods.FormatMdiChild(deleteCustomerFrm, this);
            GenericMethods.FormatMdiChild(addIncidentFrm, this);
            GenericMethods.FormatMdiChild(updateIncidentFrm, this);
            GenericMethods.FormatMdiChild(deleteIncidentFrm, this);
            GenericMethods.FormatMdiChild(addProductFrm, this);
            GenericMethods.FormatMdiChild(updateProductFrm, this);
            GenericMethods.FormatMdiChild(deleteProductFrm, this);
            GenericMethods.FormatMdiChild(updateRegistrationFrm, this);
            GenericMethods.FormatMdiChild(deleteRegistrationFrm, this);
            GenericMethods.FormatMdiChild(addTechnicianFrm, this);
            GenericMethods.FormatMdiChild(updateTechnicianFrm, this);
            GenericMethods.FormatMdiChild(deleteTechnicianFrm, this);
            GenericMethods.FormatMdiChild(allCustomersFrm, this);
        }

        private void DisplayForm(object sender, EventArgs e)
        {
            //Determines which ToolStripMenuItem the user clicked.
            switch (((ToolStripMenuItem)sender).Text)
            {
                /* If ToolStripMenuItem's text equals the case, all other forms
                 * are hidden and reset, the corresponding form is displayed,
                 * and specific controls on the selected form are focused (if needed). */
                case "Display All Incidents":
                    HideAndResetOtherForms(allIncidentsFrm.Name);
                    allIncidentsFrm.Show();
                    break;
                case "Display Incidents By Technician":
                    HideAndResetOtherForms(allIncidentsByTechnicianFrm.Name);
                    allIncidentsByTechnicianFrm.Show();
                    allIncidentsByTechnicianFrm.txtInputTechID.Focus();
                    break;
                case "Display Open Incidents By Technician":
                    HideAndResetOtherForms(allOpenIncidentsByTechnicianFrm.Name);
                    allOpenIncidentsByTechnicianFrm.Show();
                    allOpenIncidentsByTechnicianFrm.cboTechnicians.Focus();
                    allOpenIncidentsByTechnicianFrm.lblTechnicianEmail.Text = string.Empty;
                    allOpenIncidentsByTechnicianFrm.lblTechnicianPhone.Text = string.Empty;
                    break;
                case "Add Registration":
                    HideAndResetOtherForms(addRegistrationFrm.Name);
                    addRegistrationFrm.Show();
                    addRegistrationFrm.cboCustomer.Focus();
                    break;
                case "Display Incidents by Customer by State":
                    HideAndResetOtherForms(incidentByCustomerByStateFrm.Name);
                    incidentByCustomerByStateFrm.Show();
                    break;
                case "Display Registrations by Product":
                    HideAndResetOtherForms(registrationsByProductFrm.Name);
                    registrationsByProductFrm.Show();
                    break;
                case "Add Customer":
                    HideAndResetOtherForms(addCustomerFrm.Name);
                    addCustomerFrm.Show();
                    break;
                case "Update Customer":
                    HideAndResetOtherForms(updateCustomerFrm.Name);
                    updateCustomerFrm.Show();
                    break;
                case "Delete Customer":
                    HideAndResetOtherForms(deleteCustomerFrm.Name);
                    deleteCustomerFrm.ClearAll();
                    deleteCustomerFrm.Show();
                    break;
                case "Add Incident":
                    HideAndResetOtherForms(addIncidentFrm.Name);
                    addIncidentFrm.Show();
                    break;
                case "Update Incident":
                    HideAndResetOtherForms(updateIncidentFrm.Name);
                    updateIncidentFrm.Show();
                    updateIncidentFrm.LoadIncidents();
                    updateIncidentFrm.ClearAll();
                    break;
                case "Delete Incident":
                    HideAndResetOtherForms(deleteIncidentFrm.Name);
                    deleteIncidentFrm.Show();
                    deleteIncidentFrm.LoadIncidents();
                    deleteIncidentFrm.ClearAll();
                    break;
                case "Add Product":
                    HideAndResetOtherForms(addProductFrm.Name);
                    addProductFrm.Show();
                    addProductFrm.ClearAll();
                    break;
                case "Update Product":
                    HideAndResetOtherForms(updateProductFrm.Name);
                    updateProductFrm.Show();
                    break;
                case "Delete Product":
                    HideAndResetOtherForms(deleteProductFrm.Name);
                    deleteProductFrm.Show();
                    deleteProductFrm.LoadIncidents();
                    deleteProductFrm.ClearAll();
                    break;
                case "Update Registration":
                    HideAndResetOtherForms(updateRegistrationFrm.Name);
                    updateRegistrationFrm.Show();
                    updateRegistrationFrm.ClearAll();
                    break;
                case "Delete Registration":
                    HideAndResetOtherForms(deleteRegistrationFrm.Name);
                    deleteRegistrationFrm.Show();
                    deleteRegistrationFrm.ClearAll();
                    break;
                case "Add Technician":
                    HideAndResetOtherForms(addTechnicianFrm.Name);
                    addTechnicianFrm.Show();
                    addTechnicianFrm.ClearAll();
                    break;
                case "Update Technician":
                    HideAndResetOtherForms(updateTechnicianFrm.Name);
                    updateTechnicianFrm.Show();
                    updateTechnicianFrm.LoadTechnicians();
                    updateTechnicianFrm.ClearAll();
                    break;
                case "Delete Technician":
                    HideAndResetOtherForms(deleteTechnicianFrm.Name);
                    deleteTechnicianFrm.Show();
                    deleteTechnicianFrm.LoadTechnicians();
                    deleteTechnicianFrm.ClearAll();
                    break;
                case "Display All Customers":
                    HideAndResetOtherForms(allCustomersFrm.Name);
                    allCustomersFrm.LoadCustomers();
                    allCustomersFrm.Show();
                    break;
                default: //Do nothing.
                    break;
            }
        }

        /// <summary>
        /// Hides and resets all forms that are visible.
        /// </summary>
        /// <param name="selectedFrmName">A string containing the Form object's name of the form that should open.</param>
        private void HideAndResetOtherForms(string selectedFrmName)
        {
            foreach (Form frm in this.MdiChildren)
            {
                //Checks if child form is visible and is NOT the selected form.
                if (frm.Visible is true && frm.Name != selectedFrmName)
                {
                    switch (frm.Name)
                    {
                        /* If frm.Name equals the case, the form is hidden, and if needed,
                         * specific controls on the form are reset to original state.
                         * 
                         * Resets of specific controls on each form are necessary here because
                         * the user can navigate to a different form by clicking the corresponding
                         * ToolStripMenuItem without first clicking BtnReturnToMainMenu. */
                        case "FrmViewAllIncidents":
                            frm.Hide();
                            break;
                        case "FrmViewIncidentsByTechnician":
                            frm.Hide();
                            allIncidentsByTechnicianFrm.txtInputTechID.Clear();
                            allIncidentsByTechnicianFrm.dgvIncidentsByTechnician.DataSource = null;
                            break;
                        case "FrmOpenIncidentsByTechnician":
                            frm.Hide();
                            allOpenIncidentsByTechnicianFrm.cboTechnicians.SelectedIndex = -1;
                            allOpenIncidentsByTechnicianFrm.lblTechnicianEmail.Text = string.Empty;
                            allOpenIncidentsByTechnicianFrm.lblTechnicianPhone.Text = string.Empty;
                            allOpenIncidentsByTechnicianFrm.dgvOpenIncidentsByTechnician.DataSource = null;
                            break;
                        case "FrmIncidentsByCustomerByState":
                            frm.Hide();
                            break;
                        case "FrmRegistrationsByProduct":
                            frm.Hide();
                            break;
                        case "FrmAddCustomer":
                            frm.Hide();
                            break;
                        case "FrmUpdateCustomer":
                            frm.Hide();
                            break;
                        case "FrmDeleteCustomer":
                            frm.Hide();
                            break;
                        case "FrmAddIncident":
                            frm.Hide();
                            break;
                        case "FrmUpdateIncident":
                            frm.Hide();
                            break;
                        case "FrmDeleteIncident":
                            frm.Hide();
                            break;
                        case "FrmAddProduct":
                            frm.Hide();
                            break;
                        case "FrmUpdateProduct":
                            frm.Hide();
                            break;
                        case "FrmDeleteProduct":
                            frm.Hide();
                            break;
                        case "FrmAddRegistration":
                            frm.Hide();
                            addRegistrationFrm.cboCustomer.SelectedIndex = -1;
                            addRegistrationFrm.cboProduct.SelectedIndex = -1;
                            break;
                        case "FrmUpdateRegistration":
                            frm.Hide();
                            break;
                        case "FrmDeleteRegistration":
                            frm.Hide();
                            break;
                        case "FrmAddTechnician":
                            frm.Hide();
                            break;
                        case "FrmUpdateTechnician":
                            frm.Hide();
                            break;
                        case "FrmDeleteTechnician":
                            frm.Hide();
                            break;
                        case "FrmViewAllCustomers":
                            frm.Hide();
                            break;
                        default: //Do nothing.
                            break;
                    }
                }

                //Puts child form back in original "filled" state if the form is minimized.
                if (frm.WindowState == FormWindowState.Minimized)
                    frm.WindowState = FormWindowState.Normal;
            }
        }
        
        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();

            /*
             * Old way of doing things.
             * 
                //Disposes and closes all child forms.
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Close();
                }

                //Disposes and closes the main form.
                this.Close();

                //Exits the application.
                Application.Exit();
            */
        }

        private void LogoutUser(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
