using System;
using System.Collections.Generic;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace DBFConvert
{
    public class Lincense
    {
        public static Lincense getInstance()
        {
            return new Lincense();
        }

        //步骤一: 获得CUP序列号和硬盘序列号的实现代码如下:
        //获得CPU的序列号  

        /// <summary>
        /// 获得CPU的序列号
        /// </summary>
        /// <returns></returns>
        private string getCpu()
        {
            string strCpu = null;
            ManagementClass myCpu = new ManagementClass("win32_Processor");
            ManagementObjectCollection myCpuConnection = myCpu.GetInstances();
            foreach (ManagementObject myObject in myCpuConnection)
            {
                strCpu = myObject.Properties["Processorid"].Value.ToString();
                break;
            }

            return strCpu;
        }

        /// <summary>
        /// 取得设备硬盘的卷标号
        /// </summary>
        /// <returns></returns>
        private string GetDiskVolumeSerialNumber()
        {
            ManagementClass mc =
                 new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObject disk =
                 new ManagementObject("win32_logicaldisk.deviceid=\"c:\"");
            disk.Get();
            return disk.GetPropertyValue("VolumeSerialNumber").ToString();
        }

        ///// <summary> 
        ///// 获取硬盘ID 
        ///// </summary> 
        ///// <returns>string </returns> 
        //private string getHDid()
        //{
        //    string HDid = "";
        //    ManagementClass cimobject1 = new ManagementClass("Win32_DiskDrive");
        //    ManagementObjectCollection moc1 = cimobject1.GetInstances();
        //    foreach (ManagementObject mo in moc1)
        //    {
        //        HDid = (string)mo.Properties["Model"].Value;
        //    }
        //    return HDid.ToString();
        //}

        /// <summary> 
        /// 获取网卡硬件地址 
        /// </summary> 
        /// <returns>string </returns> 
        private string getMoAddress()
        {
            string MoAddress = "";
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc2 = mc.GetInstances();
            foreach (ManagementObject mo in moc2)
            {
                if ((bool)mo["IPEnabled"] == true)
                    MoAddress = mo["MacAddress"].ToString();
                mo.Dispose();
            }
            return MoAddress.ToString();
        }



        /// <summary> 
        /// 获取网卡硬地址+CPU序列号+硬盘ID字符串 
        /// </summary> 
        /// <returns></returns> 
        private string GetAll()
        {
            string info_cpu = getCpu();
            string info_disk = GetDiskVolumeSerialNumber();
            string info_mac = getMoAddress();
            return getCpu() + GetDiskVolumeSerialNumber() + getMoAddress();
        }




        //步骤二: 收集硬件信息生成机器码, 代码如下: 
        //生成机器码
        /// <summary>
        /// 生成机器码
        /// </summary>
        /// <returns></returns>
        public string CreateCode()
        {
            string temp = getCpu() + GetDiskVolumeSerialNumber() + getMoAddress();//获得24位Cpu和硬盘序列号
            string[] strid = new string[24];//
            for (int i = 0; i < 24; i++)//把字符赋给数组
            {
                strid[i] = temp.Substring(i, 1);
            }
            temp = "";
            //Random rdid = new Random();
            for (int i = 0; i < 24; i++)//从数组随机抽取24个字符组成新的字符生成机器三
            {
                //temp += strid[rdid.Next(0, 24)];
                temp += strid[i + 3 >= 24 ? 0 : i + 3];
            }
            return GetMd5(temp);
        }


        public static string GetMd5(object text)
        {
            string path = text.ToString();

            MD5CryptoServiceProvider MD5Pro = new MD5CryptoServiceProvider();
            Byte[] buffer = Encoding.GetEncoding("utf-8").GetBytes(text.ToString());
            Byte[] byteResult = MD5Pro.ComputeHash(buffer);

            string md5result = BitConverter.ToString(byteResult).Replace("-", "");
            return md5result;
        }


        //步骤三: 使用机器码生成软件注册码, 代码如下:
        //使用机器码生成注册码
        public int[] intCode = new int[127];//用于存密钥

        public void setIntCode()//给数组赋值个小于10的随机数
        {
            //Random ra = new Random();
            //for (int i = 1; i < intCode.Length;i++ )
            //{
            //    intCode[i] = ra.Next(0, 9);
            //}
            for (int i = 1; i < intCode.Length; i++)
            {
                intCode[i] = i + 3 > 9 ? 0 : i + 3;
            }
        }
        public int[] intNumber = new int[25];//用于存机器码的Ascii值
        public char[] Charcode = new char[25];//存储机器码字

        /// <summary>
        /// 生成注册码
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public string GetCode(string code)
        {
            if (code != "")
            {
                //把机器码存入数组中
                setIntCode();//初始化127位数组
                for (int i = 1; i < Charcode.Length; i++)//把机器码存入数组中
                {
                    Charcode[i] = Convert.ToChar(code.Substring(i - 1, 1));
                }//
                for (int j = 1; j < intNumber.Length; j++)//把字符的ASCII值存入一个整数组中。
                {
                    intNumber[j] =
                       intCode[Convert.ToInt32(Charcode[j])] +
                       Convert.ToInt32(Charcode[j]);

                }
                string strAsciiName = null;//用于存储机器码
                for (int j = 1; j < intNumber.Length; j++)
                {
                    //MessageBox.Show((Convert.ToChar(intNumber[j])).ToString());
                    //判断字符ASCII值是否0－9之间

                    if (intNumber[j] >= 48 && intNumber[j] <= 57)
                    {
                        strAsciiName += Convert.ToChar(intNumber[j]).ToString();
                    }
                    //判断字符ASCII值是否A－Z之间

                    else if (intNumber[j] >= 65 && intNumber[j] <= 90)
                    {
                        strAsciiName += Convert.ToChar(intNumber[j]).ToString();
                    }
                    //判断字符ASCII值是否a－z之间


                    else if (intNumber[j] >= 97 && intNumber[j] <= 122)
                    {
                        strAsciiName += Convert.ToChar(intNumber[j]).ToString();
                    }
                    else//判断字符ASCII值不在以上范围内
                    {
                        if (intNumber[j] > 122)//判断字符ASCII值是否大于z
                        {
                            strAsciiName += Convert.ToChar(intNumber[j] - 10).ToString();
                        }
                        else
                        {
                            strAsciiName += Convert.ToChar(intNumber[j] - 9).ToString();
                        }

                    }
                    //label3.Text = strAsciiName;//得到注册码
                }
                return strAsciiName;
            }
            else
            {
                return "";
            }
        }

        public string GetCode2(string code)
        {

            string strAsciiName = null;//用于存储机器码

            strAsciiName = GetMd5(code + "Person" + ",byg,");
            if (strAsciiName.Length >= 24)
            {

                strAsciiName = strAsciiName.Substring(0, 24);
            }
            return strAsciiName;
        }
    }
}
