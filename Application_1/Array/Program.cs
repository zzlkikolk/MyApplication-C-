using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array {
    class Program {
        public static void Main(string[] args) {
            int[] a = new int[5];
            for(int i = 0; i < a.Length; i++) {
                Console.Write("请输入数字");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int Max=0;
            for (int i = 0; i < a.Length; i++)
                if (a[i] > Max)
                    Max = a[i];
            Console.WriteLine(Max);
        }
    }
}
