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
            OrderDetails orderDetails1 = new OrderDetails(1,"可乐", 1, 3.0);
            OrderDetails orderDetails2 = new OrderDetails(2,"手机", 1, 2999.0);
            OrderDetails orderDetails3 = new OrderDetails(3," 薯片", 2, 10.0);

            Order order1 = new Order(1, "李米", "2017 11 11 001");
            Order order2 = new Order(2, "天恩", "2017 11 11 002");
            Order order3 = new Order(3, "小莫", "2017 11 11 003");
            order1.AddDetails(orderDetails1);//将商品加入到订单中
            order1.AddDetails(orderDetails2);
            order1.AddDetails(orderDetails3);
            order2.AddDetails(orderDetails1);
            order2.AddDetails(orderDetails2);
            order3.AddDetails(orderDetails1);
            order1.jisuan();//计算订单总金额
            order2.jisuan();
            order3.jisuan();
            OrderService os = new OrderService();
            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);
            //os.RemoveOrder(1);

            List<Order> orders = os.QueryAllOrders();
            foreach (Order od in orders)
                Console.WriteLine(od.ToString());//输出所有订单


            orders = os.QueryByCustomerName("李米");
            foreach (Order od in orders)
                Console.WriteLine(od.ToString());//输出客户名为李米的订单
           /* orders = os.QueryByGoodsName("手机");
            foreach (Order od in orders)
                Console.WriteLine(od.ToString());//输出商品中包含手机的订单
            orders = os.Query(1000.0);
            foreach (Order od in orders)
                Console.WriteLine(od.ToString());//输出订单金额大于1000的订单*/
            // os.datacheck(order1);
            // os.Export(order1);
            
        }
    }
}
