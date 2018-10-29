using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    public class OrderService
    {
        Order head = new Order();


        public static void CreatLink(Order head, int n)//创建订单链表
        {
            head.length = n;
            head.next = null;
            for (int i = 0; i < n; i++)//订单的个数为n
            {
                Order temp = new Order();
                Console.Write("请输入订单号:");
                temp.OrderNumber = Console.ReadLine();
                Console.Write("请输入客户名:");
                temp.Customer = Console.ReadLine();
                for (int j = 0; j < 3; j++)
                {
                    temp.a[j] = new OrderDetails();
                    Console.Write("请输入商品" + (j + 1) + "的名称:");
                    temp.a[j].Goodsname = Console.ReadLine();
                    Console.Write("请输入商品" + (j + 1) + "的数量:");
                    string x = Console.ReadLine();
                    temp.a[j].Goodsnumber = Convert.ToInt32(x);
                    Console.Write("请输入商品" + (j + 1) + "的价格:");
                    string y = Console.ReadLine();
                    temp.a[j].Goodsprice = Convert.ToDouble(y);
                }
                temp.next = head.next;
                head.next = temp;

            }

        }


        public static void AddOrder(Order head)//添加订单
        {
            Order neworder = new Order();
            Console.Write("请输入订单号:");
            neworder.OrderNumber = Console.ReadLine();
            Console.Write("请输入客户名:");
            neworder.Customer = Console.ReadLine();
            for (int j = 0; j < 3; j++)
            {
                neworder.a[j] = new OrderDetails();
                Console.Write("请输入商品" + (j + 1) + "的名称:");
                neworder.a[j].Goodsname = Console.ReadLine();
                Console.Write("请输入商品" + (j + 1) + "的数量:");
                string x = Console.ReadLine();
                neworder.a[j].Goodsnumber = Convert.ToInt32(x);
                Console.Write("请输入商品" + (j + 1) + "的价格:");
                string y = Console.ReadLine();
                neworder.a[j].Goodsprice = Convert.ToDouble(y);
            }
            neworder.next = head.next;
            head.next = neworder;

            head.length++;
        }


        public static void ShowOrder(Order head)//显示订单
        {
            Order t = head.next;
            for (int i = 0; i < head.length; i++)
            {
                Console.WriteLine("订单" + t.OrderNumber + ":");
                Console.WriteLine("商品  数量  价格");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(t.a[j].Goodsname + "   ");
                    Console.Write(t.a[j].Goodsnumber + "   ");
                    Console.WriteLine(t.a[j].Goodsprice);
                }
                t = t.next;
            }
        }


        public static void DeleteOrder1(Order head, string OrderNumber)//根据订单号删除订单
        {


            Order t = head;
           
            try
            {
                for (int i = 0; i < head.length; i++)
                {
                   
                        
                    
                    if (t.next.OrderNumber == OrderNumber)
                    {
                        Order p = t.next;
                        t.next = p.next;
                        p.next = null;
                        head.length--;
                        break;
                    }
                    t = t.next;
                    if(t.next==null)
                    throw new ExceptionMy("不存在该订单。", 1);
                }
                
               
            }
            catch (ExceptionMy e)
            {
                Console.WriteLine("删除失败，出错种类"+e.getId());
            }

        }
        public static void DeleteOrder2(Order head, string customer)//根据客户名删除订单
        {
            Order t = head.next;
           
            try
            {
                for (int i = 0; i < head.length; i++)
                {
                    if (t.next.OrderNumber == customer)
                    {
                        Order p = t.next;
                        t.next = p.next;
                        p.next = null;
                        head.length--;
                        break;
                    }
                    t = t.next;
                    if (t.next == null)
                        throw new ExceptionMy("不存在该订单。", 1);

                }
               
                
            }
            catch (ExceptionMy e)
            {
                Console.WriteLine("删除失败，出错种类" + e.getId());
            }

        }

        public static void SearchOrder(Order head, string OrderNumber)//根据订单号查询订单并显示该订单的相关信息
        {
            Order t = head.next;
            for (int i = 0; i < head.length; i++)
            {
                if (t.OrderNumber == OrderNumber)
                {
                    Console.WriteLine("您要查询的订单是订单" + t.OrderNumber + ":");
                    Console.WriteLine("商品  数量  价格");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(t.a[j].Goodsname + "   ");
                        Console.Write(t.a[j].Goodsnumber + "   ");
                        Console.WriteLine(t.a[j].Goodsprice);
                    }
                    break;
                }
                t = t.next;
            }
        }


        public static void ModifyOrder(Order head, string OrderNumber)//根据订单号修改订单
        {
            Order t = head.next;
            for (int i = 0; i < head.length; i++)
            {
                if (t.OrderNumber == OrderNumber)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        t.a[j] = new OrderDetails();
                        Console.Write("请输入修改后商品" + (j + 1) + "的名称:");
                        t.a[j].Goodsname = Console.ReadLine();
                        Console.Write("请输入修改后商品" + (j + 1) + "的数量:");
                        string x = Console.ReadLine();
                        t.a[j].Goodsnumber = Convert.ToInt32(x);
                        Console.Write("请输入修改后商品" + (j + 1) + "的价格:");
                        string y = Console.ReadLine();
                        t.a[j].Goodsprice = Convert.ToDouble(y);
                    }
                    break;
                }
                t = t.next;

            }

        }
    }
}
