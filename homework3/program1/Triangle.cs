using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    public class Triangle : Graphical
    {
        private double a;
        private double b;
        private double c;
        public override double showacreage()
        {
            Console.WriteLine("请输入三角形的第一条边长：");
            string x = Console.ReadLine();
            a = double.Parse(x);
            Console.WriteLine("请输入三角形的第二条边长：");
            string y = Console.ReadLine();
            b = double.Parse(y);
            Console.WriteLine("请输入三角形的第三条边长：");
            string z = Console.ReadLine();
            c = double.Parse(z);
            double p = (a + b + c) / 2;
            acreage = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return acreage;
        }
    }
}
