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
            OrderService.CreatLink(h, 2);//第二个参数设置初始订单的个数
            Console.WriteLine("请输入新添加的订单的相关信息:");
            OrderService.AddOrder(h);
            OrderService.ShowOrder(h);
            OrderService.DeleteOrder(h, "001");
            Console.WriteLine("删除后的订单列表为:");
            OrderService.ShowOrder(h);
            OrderService.SearchOrder(h, "002");
        }
    }
}