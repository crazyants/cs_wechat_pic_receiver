namespace 微信收图
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_check_install = new System.Windows.Forms.Label();
            this.label_check_running = new System.Windows.Forms.Label();
            this.label_check_homedir = new System.Windows.Forms.Label();
            this.label_run = new System.Windows.Forms.Label();
            this.linkLabel_wechat = new System.Windows.Forms.LinkLabel();
            this.timer_work = new System.Windows.Forms.Timer(this.components);
            this.button_quit = new System.Windows.Forms.Button();
            this.linkLabel_runwechat = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "第一步:检查是否安装微信";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "第二步:检查微信是否运行";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "第三步:检查微信缓存目录";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "第四步:开始程序";
            // 
            // label_check_install
            // 
            this.label_check_install.AutoSize = true;
            this.label_check_install.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_check_install.ForeColor = System.Drawing.Color.Red;
            this.label_check_install.Location = new System.Drawing.Point(210, 27);
            this.label_check_install.Name = "label_check_install";
            this.label_check_install.Size = new System.Drawing.Size(40, 12);
            this.label_check_install.TabIndex = 6;
            this.label_check_install.Text = "faild";
            // 
            // label_check_running
            // 
            this.label_check_running.AutoSize = true;
            this.label_check_running.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_check_running.ForeColor = System.Drawing.Color.Red;
            this.label_check_running.Location = new System.Drawing.Point(210, 63);
            this.label_check_running.Name = "label_check_running";
            this.label_check_running.Size = new System.Drawing.Size(40, 12);
            this.label_check_running.TabIndex = 7;
            this.label_check_running.Text = "faild";
            // 
            // label_check_homedir
            // 
            this.label_check_homedir.AutoSize = true;
            this.label_check_homedir.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_check_homedir.ForeColor = System.Drawing.Color.Red;
            this.label_check_homedir.Location = new System.Drawing.Point(210, 101);
            this.label_check_homedir.Name = "label_check_homedir";
            this.label_check_homedir.Size = new System.Drawing.Size(40, 12);
            this.label_check_homedir.TabIndex = 8;
            this.label_check_homedir.Text = "faild";
            // 
            // label_run
            // 
            this.label_run.AutoSize = true;
            this.label_run.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_run.ForeColor = System.Drawing.Color.Red;
            this.label_run.Location = new System.Drawing.Point(210, 137);
            this.label_run.Name = "label_run";
            this.label_run.Size = new System.Drawing.Size(40, 12);
            this.label_run.TabIndex = 9;
            this.label_run.Text = "faild";
            // 
            // linkLabel_wechat
            // 
            this.linkLabel_wechat.AutoSize = true;
            this.linkLabel_wechat.Location = new System.Drawing.Point(277, 27);
            this.linkLabel_wechat.Name = "linkLabel_wechat";
            this.linkLabel_wechat.Size = new System.Drawing.Size(77, 12);
            this.linkLabel_wechat.TabIndex = 10;
            this.linkLabel_wechat.TabStop = true;
            this.linkLabel_wechat.Text = "下载微信PC版";
            this.linkLabel_wechat.Visible = false;
            this.linkLabel_wechat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_wechat_LinkClicked);
            // 
            // timer_work
            // 
            this.timer_work.Interval = 1000;
            this.timer_work.Tick += new System.EventHandler(this.timer_work_Tick);
            // 
            // button_quit
            // 
            this.button_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_quit.Location = new System.Drawing.Point(88, 172);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(204, 31);
            this.button_quit.TabIndex = 11;
            this.button_quit.Text = "关闭";
            this.button_quit.UseVisualStyleBackColor = true;
            this.button_quit.Click += new System.EventHandler(this.button_quit_Click);
            // 
            // linkLabel_runwechat
            // 
            this.linkLabel_runwechat.AutoSize = true;
            this.linkLabel_runwechat.Location = new System.Drawing.Point(277, 63);
            this.linkLabel_runwechat.Name = "linkLabel_runwechat";
            this.linkLabel_runwechat.Size = new System.Drawing.Size(53, 12);
            this.linkLabel_runwechat.TabIndex = 12;
            this.linkLabel_runwechat.TabStop = true;
            this.linkLabel_runwechat.Text = "启动微信";
            this.linkLabel_runwechat.Visible = false;
            this.linkLabel_runwechat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 216);
            this.Controls.Add(this.linkLabel_runwechat);
            this.Controls.Add(this.button_quit);
            this.Controls.Add(this.linkLabel_wechat);
            this.Controls.Add(this.label_run);
            this.Controls.Add(this.label_check_homedir);
            this.Controls.Add(this.label_check_running);
            this.Controls.Add(this.label_check_install);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_check_install;
        private System.Windows.Forms.Label label_check_running;
        private System.Windows.Forms.Label label_check_homedir;
        private System.Windows.Forms.Label label_run;
        private System.Windows.Forms.LinkLabel linkLabel_wechat;
        private System.Windows.Forms.Timer timer_work;
        private System.Windows.Forms.Button button_quit;
        private System.Windows.Forms.LinkLabel linkLabel_runwechat;
    }
}

