using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal
{
    class Are
    {
        internal double width;
        internal double height;

        public Are()
        {

        }
        public Are(double height,double width)
        {
            this.width = width;
            this.height = height;
        }
        double getAre()
        {
            return width * height;
        }
        public void WriteAre()
        {
            Console.WriteLine($"矩形的长为{height}");
            Console.WriteLine($"矩形的宽为{width}");
            Console.WriteLine($"矩形面积为{getAre()}");
        }
        public void WriteAre(double x,double y)
        {
            Console.WriteLine($"矩形的长为{x}");
            Console.WriteLine($"矩形的宽为{y}");
            Console.WriteLine($"矩形面积为{x*y}");
        }
        static void Main(string[] args)
        {
            Are are = new Are();
            are.WriteAre(30,10);
        }
    }
}
