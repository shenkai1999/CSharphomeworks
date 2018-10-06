using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    public class Circular : Graphical
    {
        private double radii;
        public override double showacreage()
        {
            Console.WriteLine("请输入圆形的半径：");
            string a = Console.ReadLine();
            radii = double.Parse(a);
            acreage = 3.14 * radii * radii;
            return acreage;
        }
    }
}
