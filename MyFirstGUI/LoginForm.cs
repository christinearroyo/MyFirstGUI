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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            string id = txtUserID.Text;
            string pass = txtPassword.Text;

            if (id == "tin" && pass == "12345678")
            {
                this.Hide();

                Form1 f = new Form1();
                f.Show();
            }
            else
            {
                MessageBox.Show("Password or Email is incorrect!");
            }
        }

        private void ResetMyForm()
        {
            txtUserID.Text = "";
            txtPassword.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ResetMyForm();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
            if (e.KeyChar == (char)Keys.Escape) 
            {
                ResetMyForm();
            }
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
