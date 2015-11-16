using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DBFConvert
{
    public partial class F_Service : Form
    {
        public F_Service()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string settingFilePath = System.IO.Directory.GetCurrentDirectory() + "//setting.ini";
            INIHelper ini = new INIHelper(settingFilePath, "配置信息请勿修改");
            try
            {
                string kjqd = string.Empty;
                if (this.cbox_kjqd.CheckState == CheckState.Checked)
                {
                    kjqd = "是";
                }
                else
                {
                    kjqd = "否";
                }

                string zdgx = string.Empty;
                if (this.cbox_zdzx.CheckState == CheckState.Checked)
                {
                    zdgx = "是";
                }
                else
                {
                    zdgx = "否";
                }

                string jg = string.Empty;

                if (this.cbox_jg.SelectedIndex == 0)
                {
                    jg = "高";
                }
                else if (this.cbox_jg.SelectedIndex == 1)
                {
                    jg = "中";
                }
                else if (this.cbox_jg.SelectedIndex == 2)
                {
                    jg = "低";
                }

                ini.WriteString("服务配置", "开机启动", kjqd);
                ini.WriteString("服务配置", "自动更新", zdgx);
                ini.WriteString("服务配置", "更新间隔", jg);

                MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void F_Service_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.Insert(0, "高");
            list.Insert(1, "中");
            list.Insert(2, "低");
            this.cbox_jg.DataSource = list;
            iniInfo();
        }

        private void iniInfo()
        {
            string settingFilePath = System.IO.Directory.GetCurrentDirectory() + "//setting.ini";
            INIHelper ini = new INIHelper(settingFilePath, "配置信息请勿修改");

            //服务信息
            string kjqd = ini.ReadString("服务配置", "开机启动", "");
            if(kjqd == "是\0")
            {
                this.cbox_kjqd.CheckState = CheckState.Checked;
            }
            else
            {
                this.cbox_kjqd.CheckState = CheckState.Unchecked;
            }

            string zdgx = ini.ReadString("服务配置", "自动更新", "");
            if (zdgx == "是\0")
            {
                this.cbox_zdzx.CheckState = CheckState.Checked;
            }
            else
            {
                this.cbox_zdzx.CheckState = CheckState.Unchecked;
            }

            string gxjg = ini.ReadString("服务配置", "更新间隔", "");
            if (gxjg == "高\0")
            {
                this.cbox_jg.SelectedIndex = 0;
            }
            else if (gxjg == "中\0")
            {
                this.cbox_jg.SelectedIndex = 1;
            }
            else if (gxjg == "低\0")
            {
                this.cbox_jg.SelectedIndex = 2;
            }

        }
    }
}
