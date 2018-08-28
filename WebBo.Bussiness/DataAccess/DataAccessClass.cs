using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace WebBo.Bussiness.DataAccess
{
    public class DataAccessClass
    {
        protected string _connectionString;

        internal DataAccessClass(string connectionString)
        {
            _connectionString = connectionString;
        }


        protected IDbDataParameter[] BuildParameters(Hashtable htParams)
        {
            var resultList = new List<MySqlParameter>();
            foreach (DictionaryEntry de in htParams)
            {
                resultList.Add(new MySqlParameter(de.Key.ToString().StartsWith("?") ? de.Key.ToString() : ("?" + de.Key.ToString()), de.Value));
            }
            return resultList.ToArray();
        }




        protected DataTable GetDataTable(string sql, IDbDataParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(_connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con))
                {
                    //添加参数
                    adapter.SelectCommand.Parameters.AddRange(parameters);
                    //1.打开链接，如果连接没有打开，则它给你打开；如果打开，就算了
                    //2.去执行sql语句，读取数据库
                    //3.sqlDataReader,把读取到的数据填充到内存表中
                    adapter.Fill(dt);
                }
            }
            return dt;
        }


        /// <summary>
        /// 执行增删改，返回受影响的行数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        protected int ExecuteNonQuery(string sql, params IDbDataParameter[] param)
        {
            int n = -1;
            using (MySqlConnection con = new MySqlConnection(_connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    try
                    {
                        cmd.Parameters.AddRange(param);
                        con.Open();
                        n = cmd.ExecuteNonQuery();
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            return n;
        }


    }
}
