using Microsoft.Win32;
using System;
using System.Collections.Generic;
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



        private static RegModel CheckIsRegister1() 
        {          
             RegModel regModel = new RegModel();
          
            Microsoft.Win32.RegistryKey localRegKey = Microsoft.Win32.Registry.LocalMachine;
              
            try
            { 
                string regPath = "software\\DBFConvert\\DBFConvertSet\\";

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
                        return regModel;
                    } 
            }
            catch (Exception e)
            { 
                throw;
            }
            finally
            {
                localRegKey.Close(); 
            }
            return null;
        }

        public static bool CheckIsRegister()
        { 
            /*
             * 检测方式：
             * 机器码+type+秘钥
             * 
             */ 
            RegModel reg = CheckIsRegister1();

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
    }
}
