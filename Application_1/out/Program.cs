using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @out
{
    class Program
    {
        /**
         * 使用out关键字，必须给参数赋值
         */
        #region
            /*
        public void getNum(out int a)
        {
            a = 10;           
        }

        static void Main(string[] args)
        {
           int x = 0;
            int? a=null;
            //int b = null; 
            Console.WriteLine("a的值->>"+a);
            Console.WriteLine("before->>>"+x);
            new Program().getNum(out x);
            Console.WriteLine("after->>>"+x);
        }
        */
        #endregion
        static void Main(string[] arg)
        {
            int? a = null;
            int b = a ?? 4;
            Console.WriteLine("b = a ?? 4->>"+b);
            int? x = 2;
            b = x ?? 4;
            Console.WriteLine("b = x ?? 4.12->>"+b);

            string[] arr = { "1", "2", "3" };
            string str = string.Join("-",arr);
            Console.WriteLine(str);
        }
    }
}
