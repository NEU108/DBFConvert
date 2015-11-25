using DBFConvert.Src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;

namespace DBFConvert
{
    public partial class F_RegisterForm : Form
    {
        public F_RegisterForm()
        {
            InitializeComponent();
        }

        private void F_RegisterForm_Load(object sender, EventArgs e)
        {
            RegModel regModel = GetRegisterInfo();

            if ( CheckIsRegister(regModel))//未注册
            {
                //注册成功
                ShowRegisteredInfo(regModel);
            }
            else
            {
                ShowUnRegisteredInfo(regModel);
            }
        } 


        private void btn_register_Click(object sender, EventArgs e)
        {
            RegisterSoft();
        } 

        private void btn_close1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }


        #region 获取注册信息

        private void ShowRegisteredInfo(RegModel reg) 
        { 
            lab_status.Text = "已注册";

            gb_noregister.Visible = false;
            gb_registersuccess.Visible = true;
            gb_registersuccess.Location = new Point(28,62); 
            
            gb_registersuccess.Text = "已注册";
            lab_machinecode2.Text = reg._code;
            lab_installtime2.Text = reg._installTime;
            lab_registertime.Text = reg._activeTime;
        
        }
        private void ShowUnRegisteredInfo(RegModel reg)
        {
            lab_status.Text = "未注册";
            
            gb_registersuccess.Visible = false;
            gb_noregister.Visible = true; 
            
            gb_noregister.Text = "未注册";
            lab_machinecode.Text = reg._code;
            lab_installtime.Text = reg._installTime;
            txt_requeststr.Text = reg._code;

        }



     
         
        private string regPath="software\\DBFConvert\\DBFConvertSet\\";

        //[RegistryPermissionAttribute(SecurityAction.PermitOnly, Write = @"HKEY_CURRENT_USER\SOFTWARE\DBFConvert")]
        //[RegistryPermissionAttribute(SecurityAction.PermitOnly, Write = @"HKEY_LOCAL_MACHINE\SOFTWARE\DBFConvert")]
        private RegModel GetRegisterInfo() 
        { 
            RegModel regModel = new RegModel(); 
            Microsoft.Win32.RegistryKey localRegKey = Microsoft.Win32.Registry.LocalMachine;
            Microsoft.Win32.RegistryKey userRegKey = Microsoft.Win32.Registry.CurrentUser; 
            try
            {
                regModel._installTime = localRegKey.OpenSubKey(regPath).GetValue("InstallTime").ToString();

                string[] subkeys1 = (localRegKey.OpenSubKey(regPath).GetSubKeyNames());
                string[] subkeys2 = (userRegKey.OpenSubKey(regPath).GetSubKeyNames());
                if (subkeys1.Length == 1 && subkeys2.Length == 1)
                {
                    if (subkeys1[0].Equals(subkeys2[0]))
                    {
                        regModel._code = subkeys1[0];
                        Microsoft.Win32.RegistryKey userRegSetCodeKey = userRegKey.OpenSubKey(regPath).OpenSubKey(subkeys1[0]);
                        string[] subkeys_codes = userRegSetCodeKey.GetValueNames();

                        foreach (string item in subkeys_codes)
                        {
                            if (item.Equals("ActivityTime"))
                            {
                                regModel._activeTime = userRegSetCodeKey.GetValue("ActivityTime").ToString();
                            }
                            else if (item.Equals("Type")) //Person,Inc
                            {
                                regModel._type = userRegSetCodeKey.GetValue("Type").ToString();
                            }
                            else if (item.Equals(Lincense.GetMd5("Person")))
                            {
                                regModel._IncName = "Person";
                                
                                regModel._key = userRegSetCodeKey.GetValue(item).ToString();
                            }
                            else
                            {
                                regModel._IncName = "Person";
                                regModel._key = userRegSetCodeKey.GetValue(item).ToString();
                            }
                        }
                        return regModel;
                    }
                }
                //////把机器码加进去 
                ClearReg(localRegKey, userRegKey);
                string jiqicode = Lincense.getInstance().CreateCode();
                regModel._code = jiqicode;
                localRegKey.OpenSubKey(regPath, true).CreateSubKey(jiqicode);
                userRegKey.OpenSubKey(regPath, true).CreateSubKey(jiqicode);
            }
            catch (Exception e)
            {

                throw;
            }
            finally 
            {
                localRegKey.Close();
                userRegKey.Close();
            }
             
           return regModel;
        }

        //[RegistryPermissionAttribute(SecurityAction.PermitOnly, Write = @"HKEY_CURRENT_USER\SOFTWARE\DBFConvert")]
        //[RegistryPermissionAttribute(SecurityAction.PermitOnly, Write = @"HKEY_LOCAL_MACHINE\SOFTWARE\DBFConvert")]
        private void ClearReg(Microsoft.Win32.RegistryKey localRegKey, Microsoft.Win32.RegistryKey userRegKey) 
        {
            string[] subkeys = localRegKey.OpenSubKey(regPath,true).GetSubKeyNames();
            foreach (string key in subkeys)
            {
                localRegKey.DeleteSubKeyTree(key);
            }
            subkeys = userRegKey.OpenSubKey(regPath,true).GetSubKeyNames();
            foreach (string key in subkeys)
            {
                localRegKey.DeleteSubKeyTree(key);
            } 
        }

        private bool CheckIsRegister(RegModel reg) {

            /*
             * 检测方式：
             * 机器码+type+秘钥
             * 
             */
            bool flag = false;  
            if (reg._type.Equals("Person"))
            {
                string code = reg._code;
                string user = reg._IncName;
                string key = reg._key;

                if (Lincense.getInstance().GetCode2(code).Contains(key)) 
                {
                    flag = true;
                    return flag;
                }

            }
            else//这个是 批量注册码
            { 

            }

            return flag;
        }


        //[RegistryPermissionAttribute(SecurityAction.PermitOnly, Write = @"HKEY_CURRENT_USER\SOFTWARE\DBFConvert")]
        //[RegistryPermissionAttribute(SecurityAction.PermitOnly, Write = @"HKEY_LOCAL_MACHINE\SOFTWARE\DBFConvert")]
        private void RegisterSoft() 
        {
            if(txt_key.Text.Contains( Lincense.getInstance().GetCode2(lab_machinecode.Text) ))
            {
                Microsoft.Win32.RegistryKey localRegKey = Microsoft.Win32.Registry.LocalMachine;
                Microsoft.Win32.RegistryKey userRegKey = Microsoft.Win32.Registry.CurrentUser;
                bool flag = false;
                try
                {
                    //DBFConvert\\DBFConvertSet\\
                    localRegKey = localRegKey.OpenSubKey(regPath).OpenSubKey(lab_machinecode.Text,true);
                    localRegKey.SetValue("ActivityTime", DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss"));
                    localRegKey.SetValue("Type" ,"Person");
                    localRegKey.SetValue(Lincense.GetMd5("Person"), txt_key.Text);

                    userRegKey = userRegKey.OpenSubKey(regPath, true).OpenSubKey(lab_machinecode.Text,true); 
                    userRegKey.SetValue("ActivityTime", DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss"));
                    userRegKey.SetValue("Type", "Person");
                    userRegKey.SetValue(Lincense.GetMd5("Person"), txt_key.Text);
                    flag = true;
                    
                }
                catch (Exception e)
                {
                    MessageBox.Show("请用管理员权限执行本程序！");
                    throw;
                }
                finally 
                {
                    localRegKey.Close();
                    userRegKey.Close();
                }
                if (flag) 
                {
                    MessageBox.Show("注册成功，请重启应用程序！");
                    this.Close();

                }
            } 
            else
            {
                MessageBox.Show("注册码输入不正确，请重试！");
            }
        }
         

        #endregion

        private void F_RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
