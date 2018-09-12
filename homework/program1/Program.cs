using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            string a = "";
            int n = 0;
            int d = 0;

            Console.Write("Please input the first int:");
            s = Console.ReadLine();
            n = Int32.Parse(s);
            Console.Write("Please input the second int:");
            a = Console.ReadLine();
            d = Int32.Parse(a);
            Console.WriteLine("product=" + n + "*" + d + "=" + n * d);
        }
    }
}
