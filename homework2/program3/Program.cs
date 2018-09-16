using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            Console.Write("2-100以内的素数有：");
            for(int i = 2; i <= 100; i++)
            {
                for(int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        a = false;
                        break;
                    }
                    else
                        a = true;
                }
                if (a)
                {
                    Console.Write(i + "\t");
                }
            }     
            
        }
    }
}
