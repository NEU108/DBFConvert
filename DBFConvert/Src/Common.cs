using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Text;

namespace DBFConvert.Src
{
    public static class Common
    {


        public static string settingFilePath = System.IO.Directory.GetCurrentDirectory() + "//setting.ini";
        public static string recordFilePath = System.IO.Directory.GetCurrentDirectory() + "//record.ini";


        /// <summary>
        /// 字符串连接函数.
        /// </summary>
        /// <param name="IpAddress">数据库地址.</param>
        /// <param name="DBName">数据库名称.</param>
        /// <param name="UserName">用户名.</param>
        /// <param name="UserPwd">密码.</param>
        /// <returns>返回连接字符串.</returns>
        public static string ConnectionStr(string aIpAddress, string aDBName, string aUserName, string aUserPwd)
        {
            string lConnectStr = "";
            lConnectStr = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=" + aIpAddress
                + " ) (PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=" + aDBName
                + ")));Persist Security Info=True;User Id=" + aUserName
                + "; Password=" + aUserPwd;
            return lConnectStr;
        }


        // SetAutoRun(Application.ExecutablePath, true);  //设置自动启动当前程序
        // SetAutoRun(Application.ExecutablePath, false);  //取消自动启动 

        /// <summary>
        /// 设置开机自动启动
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="isAutoRun"></param>
        public static void SetAutoRun(string fileName, bool isAutoRun)
        {
            RegistryKey reg = null;
            try
            {
                if (!System.IO.File.Exists(fileName))
                    throw new Exception("该文件不存在!");
                String name = fileName.Substring(fileName.LastIndexOf(@"\") + 1);
                reg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                if (reg == null)
                    reg = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                if (isAutoRun)
                    reg.SetValue(name, fileName);
                else
                    reg.SetValue(name, false);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                if (reg != null)
                    reg.Close();
            }
        }


        //[RegistryPermissionAttribute(SecurityAction.PermitOnly, Read = @"HKEY_CURRENT_USER\SOFTWARE\DBFConvert")]
        //[RegistryPermissionAttribute(SecurityAction.PermitOnly, Read = @"HKEY_LOCAL_MACHINE\SOFTWARE\DBFConvert")]
        private static RegModel CheckIsRegister1() 
        {          
             RegModel regModel = new RegModel();
          
            Microsoft.Win32.RegistryKey localRegKey = Microsoft.Win32.Registry.LocalMachine;
            Microsoft.Win32.RegistryKey userRegKey = Microsoft.Win32.Registry.CurrentUser; 
            try
            { 
                string regPath = "software\\DBFConvert\\DBFConvertSet\\";


                
                    //安装时间问题
                    if (localRegKey.OpenSubKey(regPath).GetValue("InstallTime").ToString().Trim() == "")
                    {
                        localRegKey.OpenSubKey(regPath, true).SetValue("InstallTime", DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss"));
                        userRegKey.OpenSubKey(regPath, true).SetValue("InstallTime", DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss"));
                    }
                    regModel._installTime = localRegKey.OpenSubKey(regPath).GetValue("InstallTime").ToString();
                 
                

                string[] subkeys1 = (localRegKey.OpenSubKey(regPath).GetSubKeyNames()); 

                if (subkeys1.Length == 1)
                {
                        regModel._code = subkeys1[0];
                        Microsoft.Win32.RegistryKey userRegSetCodeKey = localRegKey.OpenSubKey(regPath).OpenSubKey(subkeys1[0]);
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
                }
                return regModel;
            }
            catch (Exception e)
            {
                //throw;
                //edit by sjl
                //throw e;
            }
            finally
            {
                localRegKey.Close(); 
            }
            return null;
        }

         
        //[RegistryPermissionAttribute(SecurityAction.PermitOnly, Write = @"HKEY_CURRENT_USER\SOFTWARE\DBFConvert")]
        //[RegistryPermissionAttribute(SecurityAction.PermitOnly, Write = @"HKEY_LOCAL_MACHINE\SOFTWARE\DBFConvert")]
        public static bool RegItemAddOrigan() 
        {
            bool flag = false;
            Microsoft.Win32.RegistryKey localRegKey = Microsoft.Win32.Registry.LocalMachine;
            Microsoft.Win32.RegistryKey userRegKey = Microsoft.Win32.Registry.CurrentUser;
            try
            {
                //"software\\DBFConvert\\DBFConvertSet\\";
                localRegKey= localRegKey.CreateSubKey("DBFConvert").CreateSubKey("DBFConvertSet");
                userRegKey = userRegKey.CreateSubKey("DBFConvert").CreateSubKey("DBFConvertSet");
                localRegKey.SetValue("InstallTime",DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss"));
                userRegKey.SetValue("InstallTime", DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss"));
                flag = true;
            }
            catch (Exception e)
            { 
            }
            finally 
            {
                localRegKey.Close();
                userRegKey.Close();
            }
            return flag;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>-1:注册表错误（安装不正确，建议重新安装）0:未注册，1，已注册</returns>
        public static int CheckIsRegister()
        { 
            /*
             * 检测方式：
             * 机器码+type+秘钥
             * 
             */ 
            RegModel reg = CheckIsRegister1();
            if (reg == null) 
            {
                return -1;
            }
            if (reg._code != null && reg._type !=null) 
            {
                if (reg._type.Equals("Person"))
                {
                    string code = reg._code;
                    string user = reg._IncName;
                    string key = reg._key;

                    if (Lincense.getInstance().GetCode2(code).Contains(key))
                    { 
                        return 1;
                    }

                }
                else//这个是 批量注册码
                {

                }
            }
            return 0;
        } 
    }
}
