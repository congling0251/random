using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RandomProject
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 f1)
        {
        InitializeComponent();
        form1 = f1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (form1.name != null)
            {
                int length = form1.name.name.Count;
                for (int i = 1; i <= length; i++)
                {
                    listBox1.Items.Add(i+":"+form1.name.name[i-1]); 
                }

            }
            else
            {
                label2.Text = "您还没有添加名单";
            }
            label4.Text = listBox2.Items.Count + "个";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string[] strArr = listBox1.SelectedItem.ToString().Split(':');
                if (strArr[1] != "")
                {
                    listBox2.Items.Add((listBox2.Items.Count+1) +":"+ strArr[1]);
                }
                listBox1.Items.Remove(listBox1.SelectedItem);
                label4.Text = listBox2.Items.Count + "个";
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                string[] strArr = listBox2.SelectedItem.ToString().Split(':');
                if (strArr[1] != "")
                {
                    listBox1.Items.Add((listBox1.Items.Count+1) + ":" + strArr[1]);
                }
                listBox2.Items.Remove(listBox2.SelectedItem);
                label4.Text = listBox2.Items.Count + "个";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length = listBox2.Items.Count;
            for (int i = 1; i <= length; i++)
            {
                string[] strArr = listBox2.Items[i-1].ToString().Split(':');
                if (strArr.Length > 1)
                {
                    form1.defaultName.name.Add(strArr[1]);
                }
                else
                {
                    form1.defaultName.name.Add("");
                }
            }
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add((listBox2.Items.Count+1)+":");
        }
    }
}
