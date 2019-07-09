using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money {
   public class Program {
        public static void Main(string[] args) {

            #region
            /*
            Console.WriteLine("\t\t\t\t<----工资计算---->");
            Console.Write("\t\t\t\t请输入工资:");
            try {
                double money = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"\t\t\t\t基本工资为{InputMoney(money)}");
            } catch (Exception e) {
                Console.WriteLine("\t\t\t\t" + e.Message);
                Console.WriteLine("\t\t\t\t输入有误，程序退出");
            }
            */
            #endregion
            Console.WriteLine("*商品名称\t\t\t单价\t\t\t\t数量");
            Console.WriteLine("*网球拍\t\t\t\t50\t\t\t\t1");
            Console.WriteLine("*iPhone7\t\t\t6800\t\t\t\t1");
            Console.WriteLine("*洗发水\t\t\t\t40\t\t\t\t1");
            Double money1 = (50 * 2 + 6800 + 40);
            Double money;
            if (money1 > 5000) {
                money = money1 * 0.7;
            }else if (money1 > 2000) {
                money = money1 * 0.8;
            }else if (money1 > 1000) {
                money = money1 * 0.9;
            } else {
                money = money1;
            }
            Console.WriteLine($"*总价\t\t\t\t{money1}");
            Console.WriteLine($"*实付\t\t\t\t{money}");
        }
        public static double InputMoney(double money) {
            Double x = money * 0.35 + money * 0.4 + money;
            return x;
        }
    }
}
