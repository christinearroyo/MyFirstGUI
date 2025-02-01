using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstGUI
{
    public partial class ConfirmationForm : Form
    {
        public ConfirmationForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginForm l = new LoginForm();
            l.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmationForm_Load(object sender, EventArgs e)
        {
            lblFirstName.Text = SignUpForm.fname;
            lblLastName.Text = SignUpForm.lname;
            lblEmailAddress.Text = SignUpForm.emailAddress;

            if (SignUpForm.sms)
            {
                lblSMS.Text = "✔";
            }
            if (SignUpForm.report)
            {
                lblReport.Text = "✔";
            }
            if (SignUpForm.transaction)
            {
                lblTransaction.Text = "✔";
            }
        }
    }
}
