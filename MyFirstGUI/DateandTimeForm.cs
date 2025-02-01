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
    public partial class DateandTimeForm : Form
    {
        public DateandTimeForm()
        {
            InitializeComponent();
        }

        private void lblDT1_Click(object sender, EventArgs e)
        {

        }

        private void dtshow_Click(object sender, EventArgs e)
        {
            lblDT1.Text = dtpicker.Value.ToString();
            lblDT2.Text = dtpicker.Value.ToString("MMM, dd, yyyy");
            lblDT3.Text = dtpicker.Value.ToLongDateString();

            lblDT4.Text = dtpicker.Value.ToShortTimeString();
            lblDT5.Text = dtpicker.Value.ToLongTimeString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
