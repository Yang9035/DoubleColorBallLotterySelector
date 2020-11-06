using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    /// <summary>
    /// 数据库访问类
    /// </summary>
    class SQLHelper
    {
        //从配置文件中读取链接字符串，别忘了引入命名空间和引用框架服务
        private static string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        /// <summary>
        /// 执行增删改操作
        /// </summary>
        /// <param name="sql">普通sql语句或带参数的SQL语句</param>
        /// <param name="param">sql参数数组</param>
        /// <returns>受影响的行数</returns>
        public static int Update(string sql,SqlParameter[] param=null)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (param!=null)
            {
                cmd.Parameters.AddRange(param);
            }
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("执行public static int Update(string sql,SqlParameter[] param=null)方法发生错误："+ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 执行单一结果查询
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns></returns>
        public static object GetSingleResult(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {

                throw new Exception("执行public static object GetSingleResult(string sql)方法发生错误：" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 执行结果集查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetReader(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex) 
            {

                throw new Exception("执行public static SqlDataReader GetReader(string sql)方法发生错误：" + ex.Message);
            }
        }
    }
}
