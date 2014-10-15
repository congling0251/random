using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RandomProject
{
    public partial class Form1 : Form
    {
        public namelist name = new namelist();
        public namelist nowName = new namelist();
        public namelist defaultName  =new namelist();
        Random ra = new Random();
        private int nowTime = 0;
        private int num;
        public Form1()
        {
            InitializeComponent();
            string Fpath1 = Application.StartupPath + "\\logo.jpg";
            string Fpath2 = Application.StartupPath + "\\logo.png";
            string Fpath3 = Application.StartupPath + "\\name.txt";
            Image img;
            if (System.IO.File.Exists(Fpath1))
            {
                img = Image.FromFile(Fpath1);
                pictureBox1.Image = img;
            }
            else if (System.IO.File.Exists(Fpath2))
            {
                img = Image.FromFile(Fpath2);
                pictureBox1.Image = img;
            }
            if (System.IO.File.Exists(Fpath3))
            {

                StreamReader sr = new StreamReader(@Fpath3, Encoding.Default);
                string strLine;
                strLine = sr.ReadLine();
                do
                {
                    nowName.name.Add(strLine);
                    name.name.Add(strLine);
                    strLine = sr.ReadLine();
                } while (strLine != null && strLine != "");
            }
        }

        private void 导入名单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.InitialDirectory = Application.StartupPath;
            op.RestoreDirectory = true;
            op.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            DialogResult result = op.ShowDialog();
            if (result == DialogResult.OK) //这里又打开了一遍,点第一个确定后,窗口关闭,然后又显示了出来了,第二遍显示出来的是你在第一遍已经选择好的文件,因为你点第一个确定就已经把路径和文件名保存到你的op对象的属性里了.所以,不是要点2遍确定,是出现了2次对话框.
            {
                string aa = op.FileName;
                StreamReader sr = new StreamReader(@aa, Encoding.Default);
                string strLine;
                strLine = sr.ReadLine();
                this.nowName = new namelist();
                do
                {
                    this.nowName.name.Add(strLine);
                    this.name.name.Add(strLine);
                    strLine = sr.ReadLine();
                } while (strLine != null && strLine != "");
            }
        }

        private void 重新开始ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nowTime = 0;
            this.nowName.name.Clear();
            for (int i = 0; i < this.name.name.Count; i++)
            {
                this.nowName.name.Add(this.name.name[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (nowName.name.Count>0)
            {
                timer1.Enabled = !timer1.Enabled;
                if (timer1.Enabled == false)
                {
                    button1.Text="开始";
                    if ((defaultName.name.Count - nowTime) > 0)
                    {
                        if (defaultName.name[nowTime] != "")
                        {
                            selectName.Text = defaultName.name[nowTime];
                            this.nowName.name.Remove(this.defaultName.name[nowTime++]);
                        }
                        else
                        {
                            nowTime++;
                            this.nowName.name.RemoveAt(num);
                        }
                    }
                    else
                    {
                        this.nowName.name.RemoveAt(num);
                    }
                    Console.WriteLine(this.name.name.Count);
                    Console.WriteLine(this.nowName.name.Count);
                }
                else
                {
                    button1.Text="停止";
                }
            }
            else
            {
                MessageBox.Show("名单为空，请先设置名单", "错误");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            num = ra.Next(0, nowName.name.Count-1);//滚动数字，范围你自己定吧
            selectName.Text = nowName.name[num];

        }

        private void 设置标题ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 setName = new Form3(this);
            setName.ShowDialog();
        }

        private void 查看名单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 setName = new Form2(this);
            setName.ShowDialog();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 help = new Form4();
            help.ShowDialog();
        }
    }
}
