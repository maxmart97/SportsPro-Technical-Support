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
        static FrmViewAllIncidents allIncidentsFrm = new FrmViewAllIncidents();
        static FrmViewIncidentsByTechnician allIncidentsByTechnicianFrm = new FrmViewIncidentsByTechnician();
        static FrmOpenIncidentsByTechnician allOpenIncidentsByTechnicianFrm = new FrmOpenIncidentsByTechnician();
        static FrmAddRegistration addRegistrationFrm = new FrmAddRegistration();
        static FrmIncidentsByCustomerByState incidentByCustomerByStateFrm = new FrmIncidentsByCustomerByState();
        static FrmRegistrationsByProduct registrationsByProductFrm = new FrmRegistrationsByProduct();
        static FrmAddCustomer addCustomerFrm = new FrmAddCustomer();
        static FrmUpdateCustomer updateCustomerFrm = new FrmUpdateCustomer();
        static FrmDeleteCustomer deleteCustomerFrm = new FrmDeleteCustomer();
        static FrmAddIncident addIncidentFrm = new FrmAddIncident();
        static FrmUpdateIncident updateIncidentFrm = new FrmUpdateIncident();
        static FrmDeleteIncident deleteIncidentFrm = new FrmDeleteIncident();

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
                        case "FrmAddRegistration":
                            frm.Hide();
                            addRegistrationFrm.cboCustomer.SelectedIndex = -1;
                            addRegistrationFrm.cboProduct.SelectedIndex = -1;
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
            //Disposes and closes all child forms.
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            //Disposes and closes the main form.
            this.Close();

            //Exits the application.
            Application.Exit();
        }
    }
}
