using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database {
    class Program {

        #region
        
     static void Main(string[] args) {

             string constr = "Dsn=MySQL;uid=root";
         using (OdbcConnection con = new OdbcConnection(constr)) {
             try {
                 Console.WriteLine("打开数据源的字符串" + con.ConnectionString);
                 Console.WriteLine("-->" + con.ToString());

                 //con.Open();打开数据源连接
                 con.OpenAsync();//Open的异步版本

                 string sql = "select * from book";
                 OdbcCommand cmd = new OdbcCommand();
                 cmd.CommandText = sql;//设置需要执行的SQL语句
                 cmd.Connection = con;//设置Connection（连接）实例

                 int a = cmd.ExecuteNonQuery();//返回的是受影响的行数
                 Console.WriteLine("受影响的行数" + a);
                 OdbcDataReader reader = cmd.ExecuteReader();
                 while (reader.Read()) {
                     Console.WriteLine("书名->>" + reader.GetString(1));
                     Console.WriteLine("作者->>" + reader.GetString(2) + "\n");
                 }
                reader.Close();
                    Console.Read();//不让程序一闪而退
             } catch (Exception e) {
                 Console.WriteLine(e.Message);
             }
         }
     }
     
        #endregion
           

    }
}
