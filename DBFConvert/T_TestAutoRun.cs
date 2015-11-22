using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DBFConvert
{
    public partial class T_TestAutoRun : Form
    {
        public T_TestAutoRun()
        {
            InitializeComponent();
        }

        private void T_TestAutoRun_Load(object sender, EventArgs e)
        {
            testnotifyIcon.Icon = new Icon("C:\\Users\\jerrychia\\Source\\Repos\\NEU108\\DBFConvert\\DBFConvert\\Src\\icon.ico");
            //取得程序路径
            string startup = Application.ExecutablePath;

            //class Micosoft.Win32.RegistryKey. 表示Window注册表中项级节点,此类是注册表装
            //对应于HKEY_LOCAL_MACHINE主键
            RegistryKey rKey = Registry.LocalMachine;
            //开机自动运行
            RegistryKey autoRun = rKey.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
            try
            {
                autoRun.SetValue("BookServer", startup);
                rKey.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
     

        private void T_TestAutoRun_FormClosing(object sender, FormClosingEventArgs e)
        {
            //取消关闭逻辑
            e.Cancel = true;
            this.Hide();
        }

        private void T_TestAutoRun_SizeChanged(object sender, EventArgs e)
        {
            this.Hide();
        }

    

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();        
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
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

    }
}
