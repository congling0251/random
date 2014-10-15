using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RandomProject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = "背景图片路径："+
                           "在程序同目录下的logo.png或者logo.jpg文件\n"+
                           "名单路径："+
                           "程序同目录下的name.text，或者直接从设置中导入";
        }
    }
}
