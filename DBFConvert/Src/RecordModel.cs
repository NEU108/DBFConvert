using System;
using System.Collections.Generic;
using System.Text;

namespace DBFConvert
{
    public  class RecordModel
    {
        public string _RecName { get; set; }
        public string _RecTime { get; set; }
        public string _RecStartTime { get; set; }
        public string _RecEndTime { get; set; }
        public string _RecCount { get; set; }
        public string _RecFlag { get; set; }


        public RecordModel() { }

        public RecordModel(string str) 
        {
            String[] tmpStr = str.Split(',');

            //this._RecName = tmpStr[0];
            if (tmpStr.Length >= 5)
            {
                this._RecTime = tmpStr[0];
                this._RecStartTime = tmpStr[1];
                this._RecEndTime = tmpStr[2];
                this._RecCount = tmpStr[3];
                this._RecFlag = tmpStr[4];
            }
        }

        public string ToString() 
        {
            return _RecTime + "," + _RecStartTime + "," + _RecEndTime + "," + _RecCount + "," + _RecFlag;
        }
    }
}
