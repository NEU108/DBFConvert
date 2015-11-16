using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DBFConvert
{
    public partial class F_Main : Form
    {

        public F_Main()
        {
            InitializeComponent();
        }

        private void 基本设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Base b = new F_Base();
            if(b.ShowDialog() == DialogResult.OK)
            {
                initInfo();
            }
        }

        private void 服务配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Service f = new F_Service();
            if (f.ShowDialog() == DialogResult.OK)
            {
                initInfo();
            }
        }

        private void btn_sdzx_Click(object sender, EventArgs e)
        {
            F_SM s = new F_SM();
            s.ShowDialog();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_About a = new F_About();
            a.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();      
        }
        
        private void F_Main_Load(object sender, EventArgs e)
        {
            string settingFilePath = System.IO.Directory.GetCurrentDirectory()+ "//setting.ini";
            INIHelper ini = new INIHelper(settingFilePath,"配置信息请勿修改");

            ////基本信息
            //ini.WriteString("基本配置", "扫描文件目录", "D://file/123.dbf");
            //ini.WriteString("基本配置", "数据库IP", "127.0.0.1");
            //ini.WriteString("基本配置", "数据库端口", "2100");
            //ini.WriteString("基本配置", "数据库", "DBF");
            //ini.WriteString("基本配置", "表名", "RESULT");
            //ini.WriteString("基本配置", "用户名", "root");
            //ini.WriteString("基本配置", "密码", "123");

            ////服务信息
            //ini.WriteString("服务配置", "开机启动", "否");
            //ini.WriteString("服务配置", "自动更新", "是");
            //ini.WriteString("服务配置", "更新间隔", "中");

            this.timer1.Interval = 1000;
            this.timer1.Start();

            initInfo();
        }

        /// <summary>
        /// 初始化界面信息
        /// </summary>
        private void initInfo()
        {
            string settingFilePath = System.IO.Directory.GetCurrentDirectory() + "//setting.ini";
            INIHelper ini = new INIHelper(settingFilePath, "配置信息请勿修改");

            //基本信息
            this.lbl_smwj.Text = ini.ReadString("基本配置", "扫描文件目录", "");
            this.lbl_dbs.Text = ini.ReadString("基本配置", "数据库IP", "");
            this.lbl_port.Text = ini.ReadString("基本配置", "数据库端口", "");
            this.lbl_dbsname.Text = ini.ReadString("基本配置", "数据库", "");
            this.lbl_tablename.Text = ini.ReadString("基本配置", "表名", "");

            //服务信息
            this.lbl_kjqd.Text = ini.ReadString("服务配置", "开机启动", "");
            this.lbl_auto.Text = ini.ReadString("服务配置", "自动更新", "");
            this.lbl_smjgsj.Text = ini.ReadString("服务配置", "更新间隔", "");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.tssl_status.Text = "当前时间： " + DateTime.Now.ToString();
        }
    }
}
