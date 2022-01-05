using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Tset
{
    
         
    class Cdb
    {
        public static string adminName;//登录管理员用户
        public static string userName;//登录普通用户名
        SqlConnection sc;
        public SqlConnection connect()//数据库连接
        {
            string str = "Data Source=LLDRIFT\SQLEXPRESS;Initial Catalog=ttt;Integrated Security=True;User ID=sa;Password=322325QWA";
            sc = new SqlConnection(str);
            sc.Open();
            return sc;  
        }
        public SqlCommand command(string sql)//命令
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd;
        }
        public int Execute(string sql)//执行并返回结果column
        {
            return command(sql).ExecuteNonQuery();
        }
        public int Executes(string sql)
        {
            return Convert.ToInt32(command(sql).ExecuteScalar());
        }
        public SqlDataReader read(string sql)//读取所有数据
        {
            return command(sql).ExecuteReader();
        }
        public void CdbClose()//关闭数据库
        {
            sc.Close();
        }
    }
}
