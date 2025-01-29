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
    public partial class SignUpForm : Form
    {
        private object fname;
        private object lname;
        private string emailAddress;
        private object txtLasttName;

        Confirmation c = new Confirmation();
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
        }



        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkSMS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSMS.Checked)
            {
                chkSMS.Checked = true;
            }
            else
            {
                chkSMS.Checked = false;
            }
        }

        private void chkReport_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReport.Checked)
            {
                chkReport.Checked = true;
            }
            else
            {
                chkReport.Checked = false;
            }
        }

        private void chkTransaction_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTransaction.Checked)
            {
                chkTransaction.Checked = true;
            }
            else
            {
                chkTransaction.Checked = false;
            }
        }
    }
}
