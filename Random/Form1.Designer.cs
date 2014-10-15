namespace RandomProject
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.selectName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sezhiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入名单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置标题ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看名单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectName
            // 
            this.selectName.AutoSize = true;
            this.selectName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectName.Font = new System.Drawing.Font("微软雅黑", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectName.Location = new System.Drawing.Point(762, 313);
            this.selectName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.selectName.Name = "selectName";
            this.selectName.Size = new System.Drawing.Size(0, 128);
            this.selectName.TabIndex = 0;
            this.selectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(813, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sezhiToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(973, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sezhiToolStripMenuItem
            // 
            this.sezhiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入名单ToolStripMenuItem,
            this.重新开始ToolStripMenuItem,
            this.设置标题ToolStripMenuItem,
            this.查看名单ToolStripMenuItem});
            this.sezhiToolStripMenuItem.Name = "sezhiToolStripMenuItem";
            this.sezhiToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.sezhiToolStripMenuItem.Text = "设置";
            // 
            // 导入名单ToolStripMenuItem
            // 
            this.导入名单ToolStripMenuItem.Name = "导入名单ToolStripMenuItem";
            this.导入名单ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.导入名单ToolStripMenuItem.Text = "导入名单";
            this.导入名单ToolStripMenuItem.Click += new System.EventHandler(this.导入名单ToolStripMenuItem_Click);
            // 
            // 重新开始ToolStripMenuItem
            // 
            this.重新开始ToolStripMenuItem.Name = "重新开始ToolStripMenuItem";
            this.重新开始ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.重新开始ToolStripMenuItem.Text = "重新开始";
            this.重新开始ToolStripMenuItem.Click += new System.EventHandler(this.重新开始ToolStripMenuItem_Click);
            // 
            // 设置标题ToolStripMenuItem
            // 
            this.设置标题ToolStripMenuItem.Name = "设置标题ToolStripMenuItem";
            this.设置标题ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.设置标题ToolStripMenuItem.Text = "设置显示";
            this.设置标题ToolStripMenuItem.Click += new System.EventHandler(this.设置标题ToolStripMenuItem_Click);
            // 
            // 查看名单ToolStripMenuItem
            // 
            this.查看名单ToolStripMenuItem.Name = "查看名单ToolStripMenuItem";
            this.查看名单ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.查看名单ToolStripMenuItem.Text = "查看名单";
            this.查看名单ToolStripMenuItem.Click += new System.EventHandler(this.查看名单ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(418, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 75);
            this.label1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RandomProject.Properties.Resources.VALUE26logo;
            this.pictureBox1.Location = new System.Drawing.Point(25, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 438);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(973, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectName);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sezhiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入名单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新开始ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 设置标题ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看名单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
    }
}

