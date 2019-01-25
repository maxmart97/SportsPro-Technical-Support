using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;

namespace SportsProUserInterfaceLayer.Forms
{
    public partial class FrmContactDeveloper : Form
    {
        public FrmContactDeveloper()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbName.Text) && !string.IsNullOrWhiteSpace(tbEmail.Text) && !string.IsNullOrWhiteSpace(rtbQuestion.Text))
            {
                string formData = "Name: " + tbName.Text + "\n\nEmail: " + tbEmail.Text + "\n\nQuestion: " + rtbQuestion.Text;

                try
                {
                    MailMessage myMailMessage = new MailMessage("sportsprodeveloper@gmail.com", "sportsprodeveloper@gmail.com",
                    "Form Submission by " + tbName.Text, formData);
                    SmtpClient mySmtpClient = new SmtpClient("smtp.gmail.com");
                    mySmtpClient.Port = 587;
                    mySmtpClient.Credentials = new System.Net.NetworkCredential("sportsprodeveloper@gmail.com", "$8u#Y6fRcA#cAb47Pjvu#5kQJ!pQIF");
                    mySmtpClient.EnableSsl = true;
                    mySmtpClient.Send(myMailMessage);

                    MessageBox.Show("Form submitted. The developer will contact you ASAP.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ClearAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "\n\nError sending form. You're out of luck at this point. Sorry :)");
                }
            }
            else
            {
                MessageBox.Show("Please make sure the form is completed filled out before submitting.");
            }
        }

        private void BtnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void ClearAll()
        {
            tbName.ResetText();
            tbEmail.ResetText();
            rtbQuestion.ResetText();
        }
    }
}
