using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DBFConvert
{
    public partial class F_ShowLog : Form
    {
        public F_ShowLog()
        {
            InitializeComponent();
        }

        private void F_ShowLog_Load(object sender, EventArgs e)
        {
            initRecordInfo();
        }


        private void initRecordInfo()
        {
            string settingFilePath = System.IO.Directory.GetCurrentDirectory() + "//record.ini";
            INIHelper iniHelper = new INIHelper(settingFilePath, "配置信息请勿修改");

            List<RecordModel> recordList = new List<RecordModel>();
           
            //读取INI信息  
            NameValueCollection data_records = new NameValueCollection();
            iniHelper.ReadSectionValues("DataRecords", data_records);

            int recordCount = data_records.Count;
            if (data_records != null && recordCount > 0)
            { 
                //不为空，有数据
                for (int i = 1; i < 20; i++)
                {
                    if (recordCount > 20)
                    {
                        recordList.Add(new RecordModel(data_records[recordCount - 20 + i].ToString()));
                    }
                    else if (i < recordCount)
                        recordList.Add(new RecordModel(data_records[i].ToString()));
                }
            }

            //加载recordList 数据
            this.dataGridView1.DataSource = new List<RecordModel>();
            this.dataGridView1.DataSource = recordList; 
        }

    }
}
