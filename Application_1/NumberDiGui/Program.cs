using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberDiGui
{
    class Program
    {
        public int add(int i)
        {
            int j;
            if (i == 1)
                return i;
            else
            {
                j = i * add(i - 1);
                return j;
            }
        }
        public static void Testref(ref int a,ref int b)
        {
            Console.WriteLine($"{a}+{b}={a+b}");
            a = a + b;
        }

        public static void Test(int a,int b)
        {
            Console.WriteLine($"{a}+{b}={a + b}");
            a +=b;
        }
        static void Main(string[] args)
        {
            int a = 10;
            int b = 15;
            Console.WriteLine("引用传递前a的值" + a);
            Testref(ref a, ref b);
            Console.WriteLine("引用传递后a的值"+a);
            Console.WriteLine();
            Console.WriteLine("参数传递前a的值" + a);
            Test(a, b);
            Console.WriteLine("参数传递后a的值" + a);
            //Program program = new Program();
            //Console.WriteLine(program.add(6));
        }
    }
}
