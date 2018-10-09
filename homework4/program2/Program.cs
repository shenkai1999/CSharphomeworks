using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Order h = new Order();
            bool a = true;
            
            while (a)
            {
                Console.WriteLine("请选择你需要执行的功能:");
                Console.WriteLine("1.建立订单链表");
                Console.WriteLine("2.添加订单");
                Console.WriteLine("3.显示订单");
                Console.WriteLine("4.根据订单号查询订单");
                Console.WriteLine("5.删除订单");
                Console.WriteLine("6.退出");
                string b = Console.ReadLine();
                int c = Convert.ToInt32(b);
                switch (c)
                {
                    case 1: OrderService.CreatLink(h, 1); break;//第二个参数设置初始订单的个数
                    case 2: OrderService.AddOrder(h); break;
                    case 3: OrderService.ShowOrder(h); break;
                    case 4: OrderService.SearchOrder(h, "002"); break;
                    case 5: OrderService.DeleteOrder1(h, "001"); break;
                    case 6: a = false;break;
                }
            }
            
            
            
           
            
           
            
        }
    }
}