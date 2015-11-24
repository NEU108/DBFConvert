using DBFConvert.Src;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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


            checkIsRegister(); 
        } 

        private void checkIsRegister() 
        {
            if (!Program.isRegister) {
                //-1:注册表错误（安装不正确，建议重新安装）0:未注册，1，已注册
                if(Common.CheckIsRegister() ==1)
                {
                     Program .isRegister = true;
                }else if(Common.CheckIsRegister() ==0)
                {
                    //未注册
                }
                else{
                    if (MessageBox.Show("您的软件安装不正确，请尝试卸载后重新安装！") == System.Windows.Forms.DialogResult.OK)
                    {
                        Common.RegItemAddOrigan();
                        //退出程序
                        testcontextMenuStrip.Visible = false;
                        this.Close();
                        this.Dispose();
                        Application.Exit();
                    }
                } 
            }
        }

        private void 基本设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Base b = new F_Base();
            b.settingInfoSaveEvent += new F_Base.SettingInfoSaveEvent(mySettingInfoSaveEvent);
            if(b.ShowDialog() == DialogResult.OK)
            {
                initInfo();
            }
        }

        private void mySettingInfoSaveEvent() 
        {
            if (fileWatchHelper != null && fileWatchHelper.IsWatch) 
            {
                fileWatchHelper.DisableWatch();
            }
            INIHelper.getInstance(Common.settingFilePath).WriteString("服务配置", "自动更新", "否");
            this.lbl_auto.Text = "否";
        }

        private void 服务配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Service f = new F_Service();
            if (f.ShowDialog() == DialogResult.OK)
            {
                initInfo();
            }
            
            if (f.isAutoRunWatch == "yes")
            {
                InitAutoService();//此处添加初始化AutoService的方法 
                if (fileWatchHelper != null )//&& !fileWatchHelper.IsWatch)
                {
                    fileWatchHelper.EnableWatch();
                }
            }
            else if (f.isAutoRunWatch == "no") 
            {
                if (fileWatchHelper != null && fileWatchHelper.IsWatch)
                {
                    fileWatchHelper.DisableWatch();
                }
            }
        }

        private void btn_sdzx_Click(object sender, EventArgs e)
        {
            //F_SM s = new F_SM();
            //s.ShowDialog();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_About a = new F_About();
            a.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitToolStripMenuItem_Click(sender, e);
        }
        
        private void F_Main_Load(object sender, EventArgs e)
        { 
            INIHelper ini = new INIHelper(Common.settingFilePath,"配置信息请勿修改");

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

            initViews();
            //初始化------自动运行
            //
            InitAutoService();
            string isAuto = INIHelper.getInstance(Common.settingFilePath).ReadString("服务配置", "自动更新", "");
            if (isAuto.Contains("是"))
            {
                if (fileWatchHelper != null)
                {
                    fileWatchHelper.EnableWatch();
                }
            }
        }

        private void initViews()
        {
            if (!Program.isRegister)
            {
                if ((new F_RegisterForm()).ShowDialog() == DialogResult.OK)
                {
                    if (!Program.isRegister)
                    {
                        ////----------退出
                        testcontextMenuStrip.Visible = false;
                        this.Close();
                        this.Dispose();
                        Application.Exit();
                    }
                }
            } 
        }

        /// <summary>
        /// 初始化界面信息
        /// </summary>
        private void initInfo()
        {
             
            INIHelper ini = new INIHelper(Common.settingFilePath, "配置信息请勿修改");

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

            //记录信息
            initRecordData();
        } 


        private void initRecordData() 
        { 
            INIHelper iniHelper = new INIHelper(Common.recordFilePath, "####配置信息请勿修改####");

            string recordlaststr = iniHelper.ReadString("DataRecords", "DataRecordsLast", "");
            string[] recordtotal = recordlaststr.Split(',');

            string recordTotalCount = "";//记录总条数
            RecordModel recordLastModel = null;//记录最后一条扫描记录
            string recordErrorStr = "";
            if (recordtotal.Length > 1)
            {
                recordTotalCount = recordtotal[1];
                recordLastModel = new RecordModel(iniHelper.ReadString("DataRecords", recordtotal[0], ""));
            }
            else 
            {
                //无 DataRecords 这个节点
                //添加  并 置数据为空
                iniHelper.WriteString("DataRecords", "DataRecordsLast", "");
            }
              //判断错误信息是否存在
            if (!iniHelper.ValueExists("ErrorRecords", "ErrorRecord"))
            {
                iniHelper.WriteString("ErrorRecords", "ErrorRecord", "");
            }
            else
            {
                recordErrorStr = iniHelper.ReadString("ErrorRecords", "ErrorRecord", "");
            }

            if (recordLastModel != null)//记录信息
            {
                lbl_scsmsj.Text = recordLastModel._RecTime;
                lbl_zjts.Text = recordLastModel._RecCount;
                lbl_zts.Text = recordTotalCount;
            }
            else
            {
                lbl_scsmsj.Text = "无";
                lbl_zjts.Text = "无";
                lbl_zts.Text = "0";
            }

            if (recordErrorStr.Equals(""))//错误信息
            {
                llbl_show_errorlog.Enabled = false;
                btn_cwcl.Enabled = false;
            }
            else 
            {
                llbl_show_errorlog.Enabled = true;
                btn_cwcl.Enabled = true;
            }
        } 

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.tssl_status.Text = "当前时间： " + DateTime.Now.ToString();
        }

        private void 激活ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //add by jyz
            (new F_RegisterForm()).ShowDialog();
        }

        private void llab_show_log_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //add by jyz
            (new F_ShowLog()).ShowDialog();
        }


        #region AutoService
        
       

        private FileWatchHelper fileWatchHelper = null;

        private void InitAutoService() 
        {
            //string fileStr = INIHelper.getInstance(Common.settingFilePath).ReadString("基本配置", "扫描文件目录", "");
            string fileStr = INIHelper.getInstance(Common.settingFilePath).ReadString("SetStatus", "DBFPath", "");
            string oraclepath = INIHelper.getInstance(Common.settingFilePath).ReadString("SetStatus", "OraclePath", "");

            if (fileStr != "" && oraclepath != "")
            {
                //表名
                string tableName = System.IO.Path.GetFileNameWithoutExtension(fileStr);
                //路径
                string filePath = System.IO.Path.GetDirectoryName(fileStr);

                this.fileWatchHelper = FileWatchHelper.getInstance(filePath, tableName);
                fileWatchHelper.InitWatchHelper();
                fileWatchHelper.fileChangedEvent += new FileWatchHelper.FileChangedEvent(DBFileChangedEvent);
            }
            else 
            {
                this.lbl_auto.Text = "请配置参数";
            }
        }

        private void DBFileChangedEvent(object sender,System.IO.FileSystemEventArgs e) 
        {
            AutoConvertClass.getInstance().Run();
        }
        
        private void btn_autoexec_Click(object sender, EventArgs e)
        {
            AutoConvertClass.getInstance().Run();
        }

        #endregion  

        #region AutoExe
       
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要退出终端服务程序吗？", "确认", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                testcontextMenuStrip.Visible = false;
                this.Close();
                this.Dispose();
                Application.Exit();
            }       
        }

        private void testnotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // 左键双击显示
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
        }

        private void F_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //取消关闭逻辑
            e.Cancel = true;
            this.Hide();
        }

        private void 说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("功能未开发！");
        } 
        #endregion 
    }
}
