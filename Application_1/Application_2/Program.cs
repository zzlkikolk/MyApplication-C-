using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_2
{
    class Test
    {
        static void Main(string[] args)
        {
            #region
            /*
            string name_1 = "zzl";
            string name_3 = "zzl";
            string name_2 =new string(name_1.ToArray());
            Console.WriteLine(name_1==name_3);//true
            Console.WriteLine(name_1 == name_2) ;//true
            Console.WriteLine(object.ReferenceEquals(name_1,name_3));//true
            Console.WriteLine(object.ReferenceEquals(name_1,name_2));//false
            Console.ReadKey();
            */
            #endregion

            /*
            char a = 'a';
            int b = 97;
            Console.WriteLine(b==a);
            for(int i=0;i<name_1.ToArray().Length;i++)
                Console.WriteLine(name_1.ToArray()[i]);
            */
           // Console.WriteLine(true^true);
            Console.WriteLine(8&7);
            /*0000 1000
             *0000 0111
             *0000 0000=0
             */
            Console.WriteLine(8|7);
            /*
             * 0000 1000
             * 0000 0111
             * 0000 1111=15
             */
            Console.WriteLine(8^7);
            /*相同一位取0，不同取1
             * 0000 1000
             * 0000 0111
             * 0000 1111=15
             */
            Console.WriteLine(8<<3);
            Console.WriteLine(64>>3);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
