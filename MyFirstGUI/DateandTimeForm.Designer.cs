namespace MyFirstGUI
{
    partial class DateandTimeForm
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
            this.dtshow = new System.Windows.Forms.Button();
            this.lblDT5 = new System.Windows.Forms.Label();
            this.lblDT4 = new System.Windows.Forms.Label();
            this.lblDT3 = new System.Windows.Forms.Label();
            this.lblDT2 = new System.Windows.Forms.Label();
            this.lblDT1 = new System.Windows.Forms.Label();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dtshow
            // 
            this.dtshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtshow.Location = new System.Drawing.Point(577, 350);
            this.dtshow.Name = "dtshow";
            this.dtshow.Size = new System.Drawing.Size(105, 38);
            this.dtshow.TabIndex = 13;
            this.dtshow.Text = "Show";
            this.dtshow.UseVisualStyleBackColor = true;
            this.dtshow.Click += new System.EventHandler(this.dtshow_Click);
            // 
            // lblDT5
            // 
            this.lblDT5.AutoSize = true;
            this.lblDT5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDT5.Location = new System.Drawing.Point(119, 281);
            this.lblDT5.Name = "lblDT5";
            this.lblDT5.Size = new System.Drawing.Size(254, 25);
            this.lblDT5.TabIndex = 12;
            this.lblDT5.Text = "Hours, Minutes, Seconds";
            // 
            // lblDT4
            // 
            this.lblDT4.AutoSize = true;
            this.lblDT4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDT4.Location = new System.Drawing.Point(119, 247);
            this.lblDT4.Name = "lblDT4";
            this.lblDT4.Size = new System.Drawing.Size(193, 25);
            this.lblDT4.TabIndex = 11;
            this.lblDT4.Text = "Hours and Minutes";
            // 
            // lblDT3
            // 
            this.lblDT3.AutoSize = true;
            this.lblDT3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDT3.Location = new System.Drawing.Point(119, 199);
            this.lblDT3.Name = "lblDT3";
            this.lblDT3.Size = new System.Drawing.Size(265, 25);
            this.lblDT3.TabIndex = 10;
            this.lblDT3.Text = "Day of the Week and Date";
            // 
            // lblDT2
            // 
            this.lblDT2.AutoSize = true;
            this.lblDT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDT2.Location = new System.Drawing.Point(119, 163);
            this.lblDT2.Name = "lblDT2";
            this.lblDT2.Size = new System.Drawing.Size(57, 25);
            this.lblDT2.TabIndex = 9;
            this.lblDT2.Text = "Date";
            // 
            // lblDT1
            // 
            this.lblDT1.AutoSize = true;
            this.lblDT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDT1.Location = new System.Drawing.Point(119, 127);
            this.lblDT1.Name = "lblDT1";
            this.lblDT1.Size = new System.Drawing.Size(194, 25);
            this.lblDT1.TabIndex = 8;
            this.lblDT1.Text = "Full Date and Time";
            this.lblDT1.Click += new System.EventHandler(this.lblDT1_Click);
            // 
            // dtpicker
            // 
            this.dtpicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker.Location = new System.Drawing.Point(189, 63);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(396, 30);
            this.dtpicker.TabIndex = 7;
            this.dtpicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // DateandTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtshow);
            this.Controls.Add(this.lblDT5);
            this.Controls.Add(this.lblDT4);
            this.Controls.Add(this.lblDT3);
            this.Controls.Add(this.lblDT2);
            this.Controls.Add(this.lblDT1);
            this.Controls.Add(this.dtpicker);
            this.Name = "DateandTimeForm";
            this.Text = "DateandTimeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dtshow;
        private System.Windows.Forms.Label lblDT5;
        private System.Windows.Forms.Label lblDT4;
        private System.Windows.Forms.Label lblDT3;
        private System.Windows.Forms.Label lblDT2;
        private System.Windows.Forms.Label lblDT1;
        private System.Windows.Forms.DateTimePicker dtpicker;
    }
}