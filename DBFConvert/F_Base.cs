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
            initInfo();
        }

        private void initInfo()
        {
            string settingFilePath = System.IO.Directory.GetCurrentDirectory() + "//setting.ini";
            INIHelper ini = new INIHelper(settingFilePath, "配置信息请勿修改");

            //基本信息
            this.tbx_file.Text = ini.ReadString("基本配置", "扫描文件目录", "");
            this.tbx_ip.Text = ini.ReadString("基本配置", "数据库IP", "");
            this.tbx_port.Text = ini.ReadString("基本配置", "数据库端口", "");
            this.tbx_dbs.Text = ini.ReadString("基本配置", "数据库", "");
            this.tbx_table.Text = ini.ReadString("基本配置", "表名", "");
            this.tbx_uid.Text = ini.ReadString("基本配置", "用户名", "");
            this.tbx_pwd.Text = ini.ReadString("基本配置", "密码", "");
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string settingFilePath = System.IO.Directory.GetCurrentDirectory() + "//setting.ini";
            INIHelper ini = new INIHelper(settingFilePath, "配置信息请勿修改");

            try
            {
                //基本信息
                ini.WriteString("基本配置", "扫描文件目录", this.tbx_file.Text);
                ini.WriteString("基本配置", "数据库IP", this.tbx_ip.Text);
                ini.WriteString("基本配置", "数据库端口", this.tbx_port.Text);
                ini.WriteString("基本配置", "数据库", this.tbx_dbs.Text);
                ini.WriteString("基本配置", "表名", this.tbx_table.Text);
                ini.WriteString("基本配置", "用户名", this.tbx_uid.Text);
                ini.WriteString("基本配置", "密码", this.tbx_pwd.Text);

                MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK);

                this.DialogResult = DialogResult.OK;
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
            }
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            //"C:\\Users\\jerrychia\\Desktop\\Data\\RESULTS.DBF"  
            tbx_file.Text = tbx_file.Text.Substring(tbx_file.Text.LastIndexOf('\\')+1, tbx_file.Text.Length - tbx_file.Text.LastIndexOf('\\') -1);
        }
    }
}
