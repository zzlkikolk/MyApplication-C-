using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_1
{
    class Program
    {

       private const int AGE = 10;
        private string name;

        public string getname()
        {
            return name;
        }
        public void setname(string name)
        {
            this.name = name;
        }
        static void Main(string[] args)
        {
            int a = 128;
            sbyte b = (sbyte)a;
            sbyte x = 1, y = 2;
            int z = x + y;
            char Asciia = '张';
            Program program = new Program();
            program.setname("黎辉");
            Console.WriteLine(program.getname()+AGE);
            Console.WriteLine(b+"\n"+z+"\n");
            Console.WriteLine((char)(Asciia+1));
            Console.ReadKey();
        }
    }
}
