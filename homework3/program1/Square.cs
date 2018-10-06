using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    public class Square : Graphical
    {
        public override double showacreage()
        {
            Console.WriteLine("请输入正方形的边长：");
            string a = Console.ReadLine();
            length = double.Parse(a);
            acreage = length * length;
            return acreage;
        }
    }
}
