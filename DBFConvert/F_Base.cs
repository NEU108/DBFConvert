using DBFConvert.Src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DBFConvert
{
    public partial class F_Base : Form
    {
        public F_Base()
        {
            InitializeComponent();
        }

        private void F_Base_Load(object sender, EventArgs e)
        {

            btn_save.Enabled = false;
            btn_checkdbf.Enabled = false;
            btn_checkoracle.Enabled = true;

            initInfo();
        }

        private void initInfo()
        { 
            INIHelper ini = new INIHelper(Common. settingFilePath, "配置信息请勿修改");

            //基本信息
            this.tbx_file.Text = ini.ReadString("基本配置", "扫描文件目录", "");
            this.tbx_ip.Text = ini.ReadString("基本配置", "数据库IP", "");
            this.tbx_port.Text = ini.ReadString("基本配置", "数据库端口", "");
            this.tbx_dbs.Text = ini.ReadString("基本配置", "数据库", "");
            this.tbx_table.Text = ini.ReadString("基本配置", "表名", "");
            this.tbx_uid.Text = ini.ReadString("基本配置", "用户名", "");
            this.tbx_pwd.Text = ini.ReadString("基本配置", "密码", "");
        }

        public delegate void SettingInfoSaveEvent();
        public SettingInfoSaveEvent settingInfoSaveEvent;


        private void btn_save_Click(object sender, EventArgs e)
        { 
            INIHelper ini = new INIHelper(Common.settingFilePath, "配置信息请勿修改");

            try
            {
                //基本信息

                if (isDBFCheck) 
                {
                    ini.WriteString("SetStatus", "DBFPath", this.tbx_file.Text); 
                    ini.WriteString("基本配置", "扫描文件目录", this.tbx_file.Text);
                }
                if (isOracleCheck) 
                {
                    ini.WriteString("SetStatus", "OraclePath", str);
                    ini.WriteString("基本配置", "数据库IP", this.tbx_ip.Text);
                    ini.WriteString("基本配置", "数据库端口", this.tbx_port.Text);
                    ini.WriteString("基本配置", "数据库", this.tbx_dbs.Text);
                    ini.WriteString("基本配置", "表名", this.tbx_table.Text);
                    ini.WriteString("基本配置", "用户名", this.tbx_uid.Text);
                    ini.WriteString("基本配置", "密码", this.tbx_pwd.Text);
                }
                if (isDBFCheck || isOracleCheck)
                {
                    this.settingInfoSaveEvent(); 
                    MessageBox.Show("系统参数保存成功,请重新在服务里打开【自动执行】！", "提示", MessageBoxButtons.OK);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("没有数据保存！");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void tbx_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "DBF(*DBF)|*DBF";
            if (open.ShowDialog() == DialogResult.OK)
            {
                this.tbx_file.Text = open.FileName;

                this.btn_checkdbf.Enabled = true;
            }  
        }

        private bool isDBFCheck = false;
        private bool isOracleCheck = false;
        private void btn_check_Click(object sender, EventArgs e)
        {
            this.btn_checkdbf.Enabled = false; 
            isDBFCheck = true;
            try 
	        {
                //表名
                string tableName = System.IO.Path.GetFileNameWithoutExtension(this.tbx_file.Text);
                //路径
                string filePath = System.IO.Path.GetDirectoryName(this.tbx_file.Text); 
                DBFHelper dbfHelper = new DBFHelper(filePath); 
                dbfHelper.Open();
                DataTable dt = dbfHelper.GetResults(" select * from "+tableName + " where  1=0");

                //partnum	runnum	operator	date	time	lotnumber	quantity	pumppress	pumptime	runtime	finaltemp	rundescrip	archived	datafile	runaverage	voltlog	errors	customdata	gastypes
                string colnames = "partnum,runnum,operator,date,time,lotnumber,quantity,pumppress,pumptime,runtime,finaltemp,rundescrip,archived,datafile,runaverage,voltlog,errors,customdata,gastypes";

                int colCount = dt.Columns.Count;
                if (colCount == 19)
                {
                    for (int i = 0; i < colCount; i++)
                    {
                        if (!colnames.Contains(dt.Columns[i].ColumnName.Trim()))
                        {
                            isDBFCheck = false;
                            break;
                        }
                    }
                }
                else 
                { 
                    isDBFCheck = false; 
                }
            }
	        catch (Exception ex)
	        {
                isDBFCheck = false;
	        }
            if (!isDBFCheck)
            {
                MessageBox.Show("DBF文件校验失败，请重新选择！");
            }
            else 
            {
                btn_save.Enabled = true; 
            }
        }

        string str = ""; 
        private void btn_checkoracle_Click(object sender, EventArgs e)
        {
            /*
            ini.WriteString("基本配置", "数据库IP", this.tbx_ip.Text);
            ini.WriteString("基本配置", "数据库端口", this.tbx_port.Text);
            ini.WriteString("基本配置", "数据库", this.tbx_dbs.Text);
            ini.WriteString("基本配置", "表名", this.tbx_table.Text);
            ini.WriteString("基本配置", "用户名", this.tbx_uid.Text);
            ini.WriteString("基本配置", "密码", this.tbx_pwd.Text);*/

            string str = Common.ConnectionStr(this.tbx_ip.Text.Trim(), this.tbx_dbs.Text.Trim(), this.tbx_uid.Text.Trim(), this.tbx_pwd.Text.Trim());
            ImportOrcacle importOracle = new ImportOrcacle(str);
            if (importOracle.TestConn(this.tbx_table.Text.Trim()))
            {
                btn_save.Enabled = true;
                isOracleCheck = true;
            }
            else 
            {
                isOracleCheck = false;
                MessageBox.Show("Oracle参数校验失败，请重试！");
            }
        }
    }
}
