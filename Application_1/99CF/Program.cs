using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99CF
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
        //    for (int i = 1; i <= 9; i++)
       //     {
         //       for (int j = 1; j <= i; j++)
             //       Console.Write($"{j}*{i}={i*j}\t");
              //      Console.WriteLine();
           //}
            #endregion

            for(int i = 0; i <= 5; i++)
            {
                for(int j=1;j<=5-i;j++)
                    Console.Write("  ");
                for(int j=1;j<=2*i-1;j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }
    }
}
