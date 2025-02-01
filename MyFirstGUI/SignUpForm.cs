using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstGUI
{
    public partial class SignUpForm : Form
    {
        public static string fname;
        public static string lname;
        public static string emailAddress;
        public static string txtLasttName;
        public static Boolean sms;
        public static Boolean report;
        public static Boolean transaction;

        ConfirmationForm c = new ConfirmationForm();
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fname = txtFirstName.Text;
            lname = txtLastName.Text;
            emailAddress = txtEmailAddress.Text;

            c.Show();

            this.Hide();
        }



        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkSMS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSMS.Checked)
            {
                sms = true;

                lblSMS.Text = "Services SMS Notification Applied";
            }
            else
            {
                sms= false;

                lblSMS.Text = "...";
            }
        }

        private void chkReport_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReport.Checked)
            {
                report = true;
            }
            else
            {
                report = false;
            }
        }

        private void chkTransaction_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTransaction.Checked)
            {
                transaction = true;

                lblTransaction.Text = "Services SMS Notification Applied";
            }
            else
            {
                transaction= false;

                lblTransaction.Text = "...";
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
