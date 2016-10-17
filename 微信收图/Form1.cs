using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace 微信收图
{
    public partial class Form1 : Form
    {

        private string app_name = "微信传图助手";
        private string app_version = "1.0";
        private string app_author = "Majesty";


        private string wechat_homedir = "";

        private DateTime the_time;
        private Process pic_pro = null;


        public Form1()
        {
            InitializeComponent();
        }



        //启动事件
        private void Form1_Load(object sender, EventArgs e)
        {
            //启动初始化
            this.the_time = DateTime.Now;
            this.Text = this.app_name + " v" + this.app_version + " by " + this.app_author;
            //linkLabel_wechat.Visible = false;


            //开始检查1
            if (Util.isWechatInstall() == true)
            {
                label_check_install.Text = "Pass";
                label_check_install.ForeColor = Color.Green;
            }
            else {
                linkLabel_wechat.Visible = true;
                return;
            }

            //开始检查2
            if (Util.isWechatRunning() == true)
            {
                label_check_running.Text = "Pass";
                label_check_running.ForeColor = Color.Green;
            }
            else {
                linkLabel_runwechat.Visible = true;
                return;
            }

            //检查3
            this.wechat_homedir = Util.getWechatHome();
            if (this.wechat_homedir != null)
            {
                label_check_homedir.Text = "Pass";
                label_check_homedir.ForeColor = Color.Green;
            }
            else {
                return;
            }
            //开始跑了

            timer_work.Start();
            label_run.Text = "Running";
            label_run.ForeColor = Color.Green;

        }
        //点击下载事件
        private void linkLabel_wechat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://weixin.qq.com/cgi-bin/readtemplate?t=win_weixin&lang=zh_CN"); 
        }


        //循环
        private void timer_work_Tick(object sender, EventArgs e)
        {
            label_run.Text += ".";
            if (label_run.Text.Length >= 11) {
                label_run.Text = label_run.Text.Substring(0, 7);
            }
            //
            //搜索符合条件的dat文件
            string dat_file = Util.findDataFile(this.wechat_homedir, the_time);
            if (dat_file != null) {
                this.the_time = DateTime.Now;
                string pic_file = Util.getRealPic(dat_file, System.Environment.CurrentDirectory);
                if (pic_file != null) {
                    Util.killProcess();
                    Util.openPic(pic_file);
                    
                }
            }
            

        }

        //退出
        private void button_quit_Click(object sender, EventArgs e)
        {
            timer_work.Stop();
            this.Close();
        }


        //点击启动微信
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Util.runWechat();
        }
    }
}
