using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RandomProject
{
    public partial class Form3 : Form
    {
        Form1 form1;
        public Form3(Form1 f1)
        {
        InitializeComponent();
        form1 = f1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.label1.Text = textBox1.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
