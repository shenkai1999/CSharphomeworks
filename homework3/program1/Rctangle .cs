using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    public class Rctangle : Graphical
    {
        private double width;
        
        public override double showacreage()
        {
            Console.WriteLine("请输入长方形的长：");
            string b = Console.ReadLine();
            length = Double.Parse(b);
            Console.WriteLine("请输入长方形的宽：");
            string c = Console.ReadLine();
            width = Double.Parse(c);
            acreage = length * width;
            return acreage;
        }
    }
}
