using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
namespace CRUD {
    public class Program {
        private static string constr = "Dsn=MySQL;uid=root";
        OdbcConnection con= new OdbcConnection(constr);//数据库连接源
        OdbcCommand cmd= new OdbcCommand();//对数据库执行操作
        public List<Book> GetBookList() {
                try {
                    con.Open();
                    string sql = "select *  from book";
                    cmd.CommandText = sql;//设置执行的SQL语句 必须
                    cmd.Connection = con;//设置数据库连接实例 必须
                    int a = cmd.ExecuteNonQuery();
                    Console.WriteLine("受影响的行数"+a);
                    OdbcDataReader reader = cmd.ExecuteReader();
                    List<Book> list = new List<Book>();
                    while (reader.Read()) {
                        Book book = new Book();
                        book.BookName = reader.GetString(1);
                        book.AutHor = reader.GetString(2);
                        book.Pirce = reader.GetInt32(3);
                        list.Add(book);
                    }                   
                    return list;
                }catch(Exception e) {
                    Console.WriteLine(e.Message);
                    return null;
            } finally {
                con.Close();
            }
        }
        static void Main(string[] args) {
            
            List<Book> list=new Program().GetBookList();
            foreach(Book book in list){
                Console.WriteLine(book+"\n");
            }
            
        }
    }
    public class Book {
        private string bookname;
        private string author;
        private int price;
        public string BookName {
            get {
                return this.bookname;
            }
            set {
                this.bookname = value;
            }
        }
        public string AutHor {
            get {
                return this.author;
            }
            set {
                this.author = value;
            }
        }
        public int Pirce {
            get {
                return price;
            }
            set {
                this.price = value;
            }
        }
        public override string ToString() {
            return $"[书名={BookName},作者={AutHor},价格={price}]";
        }
    }
}
