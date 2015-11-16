using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Text;

namespace DBFConvert
{
    /// <summary>
    /// DBF的操作帮助类
    /// </summary>
    public class DBFHelper
    {
        private static string _path;
        private static string _connstring;
        private OdbcConnection conn;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="path">数据库文件完整路径</param>
        public DBFHelper(string path)
        {
            _path = path;
            _connstring = @"Driver={Microsoft Visual FoxPro Driver};SourceType=DBF;SourceDB=" + _path
                + ";Exclusive=No;NULL=NO;Collate=Machine;BACKGROUNDFETCH=NO;DELETED=NO;";
            conn = new OdbcConnection(_connstring);
        }

        /// <summary>
        /// Open Connection.
        /// </summary>
        /// <returns>状态标志： 0,成功,-1,失败.</returns>
        public int Open()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Close();
            }
            return -1;
        }

        /// <summary>
        /// Close Connection.
        /// </summary>
        public void Close()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 根据SQL命令执行SQl语句，得到结果集.
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// <returns>DataTable</returns>
        public DataTable GetResults(string sqlCommand)
        {
            OdbcCommand command = null;
            OdbcDataAdapter oda = null;
            try
            {
                this.Open();
                command = new OdbcCommand(sqlCommand, conn);
                oda = new OdbcDataAdapter(command);
                DataTable dataResult = new DataTable();
                oda.Fill(dataResult);

                return dataResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Close();
                conn.Dispose();
                command.Dispose();
                oda.Dispose();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sqlCommand"></param>
        /// <returns></returns>
        public List<T> GetResults<T>(string sqlCommand) 
        {
            List<T> list = new List<T>();

            try
            {
                this.Open();
                OdbcCommand command = new OdbcCommand(sqlCommand, this.conn);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read()) 
                {
                    String a=  reader["value"].ToString();
                }
            }
            catch (Exception e)
            {
                
                throw e;
            }
            
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dt"></param>
        /// <returns></returns>
        public IList<T> DataTableToList<T>(DataTable dt)
        {
            if (dt == null)  
                return null; 

            List<T> list = new List<T>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                T t =Activator.CreateInstance<T>();
                System.Reflection.PropertyInfo[] pros = t.GetType().GetProperties();

                for (int j = 0; j < pros.Length; j++)
                {
                    if ((dt.Columns[i].ColumnName.ToUpper()).Equals(
                        pros[j].Name.ToUpper()
                        )) 
                    {
                        if (dt.Rows[i][j] != DBNull.Value)
                        {
                            pros[j].SetValue(t, dt.Rows[i][j], null);
                        }
                        else
                        {
                            pros[j].SetValue(t, null, null);
                        }
                    }
                }

                list.Add(t);
            }

            return list;
        }
    }
}

