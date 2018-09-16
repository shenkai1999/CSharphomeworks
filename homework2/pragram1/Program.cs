using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pragram1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数:");
            int num = 0;
            bool t = true;
            bool valid = int.TryParse(Console.ReadLine(), out num);
            Console.Write("你输入的数据的素数因子为：");
            if (valid)
            {
                for(int i = 2; i < num + 1; i++)
                {
                    if (0 == num % i)
                    {
                        for (int j = 2; j <=Math.Sqrt(i) ; j++)
                        {
                            if (i % j == 0)
                            {
                                t = false;
                                break;
                            }
                            else
                                t = true;
                                                                                            
                    }
                       if(t)
                            Console.Write(i+"\t");
                    }
                    
                }
            }
            else
            {
                Console.WriteLine("输入数据不合规范! ");
            }
        }
    }
}
