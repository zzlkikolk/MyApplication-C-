using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read
{
    class Program
    {
        public static int checkNum(string a)
        {
            try
            {
                int a_1= Convert.ToInt32(a);
                return a_1;
            }catch(Exception e)
            {
                return 'a';
            }
        }
        static void Main(string[] args)
        {
            #region
            //int x = 5;
            //string mz = $"蛮王{x}秒真男人";
            // string a = @"a\nmsl";
            // Console.WriteLine(a);
            // Console.WriteLine(mz);
            // Console.ReadKey();
            #endregion

            #region
            //从控制台读取一个字符串
            // Console.Write("请输入一个字符");
            //int result = Console.Read();
            // Console.WriteLine(result);
            //请用户输入任何内容
            // ConsoleKeyInfo info =Console.ReadKey();

            // string a = Console.ReadLine();
            // Console.WriteLine(a);
            #endregion

            #region
            bool check = true;
            int a_1 ;
            int a_2 ;
            string a;
            while (check) {
                try
                {
                    Console.Write("请输入第一个需要运算的数字");
                     a = Console.ReadLine();
                    a_1 = checkNum(a);
                    while(a_1=='a')
                    {                        
                            Console.Write("输入的不是有效数字,请重新输入");
                            a= Console.ReadLine();
                            a_1 = checkNum(a);
                    }
                    
                        

                    Console.Write("请输入运算符");
                    string x = Console.ReadLine();
                    switch (x)
                    {
                        case "+":
                            {
                                Console.Write("请输入第二个需要运算的数字");
                                string b = Console.ReadLine();
                                a_2 = checkNum(b);
                                int c = a_1 + a_2;
                                Console.WriteLine("结果" + c);
                            }
                            break;
                        case "-":
                            {
                                Console.Write("请输入第二个需要运算的数字");
                                string b = Console.ReadLine();
                                 a_2 = checkNum(b);
                                int c = a_1 - a_2;
                                Console.WriteLine("结果" + c);
                            }
                            break;
                        case "*":
                            {
                                Console.Write("请输入第二个需要运算的数字");
                                string b = Console.ReadLine();
                                 a_2 = checkNum(b);
                                int c = a_1 * a_2;
                                Console.WriteLine("结果" + c);
                            }
                            break;
                        case "/":
                            {
                                Console.Write("请输入第二个需要运算的数字");
                                string b = Console.ReadLine();
                                a_2 = checkNum(b);
                                int c = a_1 / a_2;
                                Console.WriteLine("结果" + c);
                            }
                            break;
                        default:
                                Console.WriteLine("运算符输入错误");
                                break;
                            
                    }
                } catch (Exception e)
                {
                    Console.WriteLine("程序出现异常");
                        check = false;
                   
                }
            }
            #endregion
        }
    }
}
