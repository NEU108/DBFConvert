using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DBFConvert
{
    public partial class F_SM : Form
    { 
        private static string  settingFilePath = System.IO.Directory.GetCurrentDirectory()+ "//setting.ini";
        string DBFPath = INIHelper.getInstance(settingFilePath).ReadString("基本配置", "扫描文件目录", "");

        public F_SM()
        {
            InitializeComponent();
        }

        private void btn_scan_Click(object sender, EventArgs e)
        {

        }

        private void btn_addtodata_Click(object sender, EventArgs e)
        {

        }
    }
}
