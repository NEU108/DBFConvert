using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OracleClient;

namespace DBFConvert
{
    /// <summary>
    /// 导入数据到Oracle数据库
    /// </summary>
    public class ImportOrcacle
    {
        private OracleConnection conn;
        private OracleCommand com;
        private OracleDataAdapter da;
        private OracleCommandBuilder ocb;
        private string strconn = "";
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public ImportOrcacle(string str)
        {
            strconn = str;
        }

        public string ConnStr
        {
            get { return this.strconn; }
            set{ this.strconn = value;} 
        }

        public bool TestConn(string tableName)
        {
            bool checkdt = true;
            OracleDataAdapter adapter = null ;
            try
            {
                conn = new OracleConnection(strconn);
                conn.Open();

                //获取表结构，构造new_dt
                com = conn.CreateCommand();
                com.CommandText = "select  count(*) from "+tableName ;
                com.CommandType = CommandType.Text;
                //partnum	runnum	operator	date	time	lotnumber	quantity	pumppress	pumptime	runtime	finaltemp	rundescrip	archived	datafile	runaverage	voltlog	errors	customdata	gastypes

                /*
                 * lotnumber:
                 * 
                 */
                DataTable dt = new DataTable();
                adapter = new OracleDataAdapter(com);
                adapter.Fill(dt); 
                 
                //if (dt.Columns.Count  == 6)
                if (dt.Columns.Count == 1)
                {
                    /*
                    string colnames = "V_LOT,V_STIME,V_ETIME,V_ETIME,V_EQU,V_VAR";
                    for (int i = 0; i < 6; i++)
                    {
                        if (!colnames.Contains(dt.Columns[i].ColumnName.Trim()))
                        {
                            checkdt = false;
                            break;
                        }
                    }
                    */
                } 
                else
                {
                    checkdt = false;
                }
            }
            catch (Exception ex)
            {
                //暂不处理，抛给上层做处理 
                checkdt = false;
                throw (ex);  
            }
            finally
            {
                conn.Close();
                adapter.Dispose(); 
                com.Dispose();
                conn.Dispose();
            } 

            return checkdt;
        }


        public void InsertDataToOracle(DataTable dt,int start,string tableName)
        {  
            try
            {
                conn = new OracleConnection(strconn);
                conn.Open();

                //获取表结构，构造new_dt
                com = conn.CreateCommand();
                //com.CommandText = "select  count(*) from " + tableName;
                com.CommandType = CommandType.Text;
                //partnum	runnum	operator	date	time	lotnumber	quantity	pumppress	pumptime	runtime	finaltemp	rundescrip	archived	datafile	runaverage	voltlog	errors	customdata	gastypes

                /* 
                 * V_LOT    :lotnumber
                 * ,V_STIME :date	time
                 * ,V_ETIME :
                 * ,V_EQU   :  
                 * ,V_QTY   :
                 *  V_VAR   :
                 * "
                 * 
                 */
                string sql = "";
                int rowCount = dt.Rows.Count;
                for (int i = start; i < rowCount; i++)
                {
                    string str_date = dt.Rows[i]["date"].ToString() + " " + dt.Rows[i]["time"].ToString();
                    sql = "insert into " + tableName + " (V_LOT,V_STIME,V_ETIME,V_EQU,V_QTY,V_VAR) values ('"
                        + dt.Rows[i]["lotnumber"] + "','" + DateTime.Parse(str_date).ToString() + "','" + DateTime.Parse(str_date).ToString() +
                        "','" + dt.Rows[i]["partnum"]+ "','" + dt.Rows[i]["pumppress"] + "','" + dt.Rows[i]["gastypes"] + "' )";
                    com.CommandText = sql;
                    int result= com.ExecuteNonQuery();
                } 
            }
            catch (Exception ex)
            {
                //暂不处理，抛给上层做处理  
                throw (ex);
            }
            finally
            {
                conn.Close(); 
                com.Dispose();
                conn.Dispose();
            }
        }


        /// <summary>
        /// 功能：把dt表中的数据全部追加到Oracle数据中指定的表
        /// 注意：要保证dt表的列与数据库中指定表默认检索的列的次序相同
        /// </summary>
        /// <param name="strconn">链接字符串</param>
        /// <param name="dt">要追加的数据</param>
        /// <param name="tb_name">数据库中的表名</param>
        public void insertDB(DataTable dt, string tb_name)
        {
            try
            {
                conn = new OracleConnection(strconn);
                conn.Open();

                //获取表结构，构造new_dt
                com = conn.CreateCommand();
                com.CommandText = "select * from " + tb_name + " where 0=1"; ;
                com.CommandType = CommandType.Text;

                da = new OracleDataAdapter(com);
                DataTable new_dt = new DataTable();
                da.Fill(new_dt);

                //复制dt的数据到new_dt中
                DataRow new_dr = new_dt.NewRow();
                foreach (DataRow dr in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; ++i)
                    {
                        new_dr[i] = dr[i];
                    }
                    new_dt.Rows.Add(new_dr);
                }

                //自动构造InsertCommand命令
                ocb = new OracleCommandBuilder(da);
                da.InsertCommand = ocb.GetInsertCommand();

                da.UpdateBatchSize = 5000;
                da.Update(new_dt);
            }
            catch (Exception ex)
            {
                //暂不处理，抛给上层做处理
                throw (ex);
            }
            finally
            {
                conn.Close();
                ocb.Dispose();
                da.Dispose();
                com.Dispose();
                conn.Dispose();
            }
        }
    }
}

