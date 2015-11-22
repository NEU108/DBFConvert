using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBFConvert.Src
{
    public static class Common
    {
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
    }
}
