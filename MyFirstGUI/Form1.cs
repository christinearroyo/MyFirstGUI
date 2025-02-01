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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Text1 = textBox1.Text;
            MessageBox.Show("Your Email is: " + Text1);

            String Text2 = textBox2.Text;
            MessageBox.Show("Your Password is: " + Text2);

            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Yoo";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Christine";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Magcode kana Arroyo";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateandTimeForm dateandTime = new DateandTimeForm();
            dateandTime.Show();

            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string input;

            if (radioButton1.Checked == true)
            {
                input = radioButton1.Text;

                MessageBox.Show(input + " is the Creator");
            }
            if (radioButton2.Checked == true)
            {
                input = radioButton2.Text;

                MessageBox.Show(input + " is the Creator's 2nd Brother");
            }
            if (radioButton3.Checked == true)
            {
                input = radioButton3.Text;

                MessageBox.Show(input + " is the Creator's 1st Brother");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("1. To Purchase Press Yes " +
                "\n 2. Press No if Not Interested " +
                "\n 3. Click Cancel to Cancel Order",
            "Purchase Software", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                lblSubscription.Text = "Your Subscription has been purchased!";
            }
            if (dr == DialogResult.No)
            {
                lblCanceled.Text = "User Not Interested";
            }
            if (dr == DialogResult.Cancel)
            {
                lblCanceled.Text = "Your Payment has been Canceled";
            }


        }
    }
}
