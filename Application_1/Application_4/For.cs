using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_4
{
    class For
    {
        static void Main(string[] args)
        {
            for (int i =0; i<=5; i++) { 
               for(int j=5;j-(2*i)>0;j--)
                    Console.Write(" "+"* ");
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
