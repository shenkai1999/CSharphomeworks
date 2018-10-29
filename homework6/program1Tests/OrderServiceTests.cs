using Microsoft.VisualStudio.TestTools.UnitTesting;
using program1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
       
        OrderDetails orderDetails1 = new OrderDetails("可乐", 1, 3.0);
        OrderDetails orderDetails2 = new OrderDetails("手机", 1, 2999.0);
        OrderDetails orderDetails3 = new OrderDetails(" 薯片", 2, 10.0);
        Order order1 = new Order(1, "李米");
        Order order2 = new Order(2, "天恩");
        Order order3 = new Order(3, "小莫");

        OrderService os = new OrderService();       
        [TestMethod()]
        public void AddOrderTest()
        {
            order1.AddDetails(orderDetails1);
            order1.AddDetails(orderDetails2);
            order1.AddDetails(orderDetails3);

            Assert.AreEqual(0, os.AddOrder(order1));
            
        }

        [TestMethod()]
        public void RemoveOrderTest()
        {
            order1.AddDetails(orderDetails1);
            order1.AddDetails(orderDetails2);
            order1.AddDetails(orderDetails3);
            order2.AddDetails(orderDetails1);
            order2.AddDetails(orderDetails2);
            order3.AddDetails(orderDetails1);
            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);

            Assert.AreEqual(0, os.RemoveOrder(1));
        }

        [TestMethod()]
        public void QueryAllOrdersTest()
        {
            order1.AddDetails(orderDetails1);
            order1.AddDetails(orderDetails2);
            order1.AddDetails(orderDetails3);
            os.AddOrder(order1);
            List<Order> orders = os.QueryAllOrders();
            List<Order> result = new List<Order>();
            result.Add(order1);
            CollectionAssert.AreEqual(result, orders);

        }

        [TestMethod()]
        public void QueryByCustomerNameTest()
        {
            order1.AddDetails(orderDetails1);
            order1.AddDetails(orderDetails2);
            order1.AddDetails(orderDetails3);
            order2.AddDetails(orderDetails1);
            order2.AddDetails(orderDetails2);
            order3.AddDetails(orderDetails1);
            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);
            List<Order> orders = os.QueryByCustomerName("李米");
            List<Order> result = new List<Order>();
            result.Add(order1);
            CollectionAssert.AreEqual(result, orders);
        }

        [TestMethod()]
        public void QueryByGoodsNameTest()
        {
            order1.AddDetails(orderDetails1);
            order1.AddDetails(orderDetails2);
            order1.AddDetails(orderDetails3);
            order2.AddDetails(orderDetails1);
            order2.AddDetails(orderDetails2);
            order3.AddDetails(orderDetails1);
            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);
            List<Order> orders = os.QueryByGoodsName("可乐");
            List<Order> result = new List<Order>();
            result.Add(order1);
            result.Add(order2);
            result.Add(order3);
            CollectionAssert.AreEqual(result, orders);
        }

        [TestMethod()]
        public void QueryTest()
        {
            order1.AddDetails(orderDetails1);
            order1.AddDetails(orderDetails2);
            order1.AddDetails(orderDetails3);
            order2.AddDetails(orderDetails1);
            order2.AddDetails(orderDetails2);
            order3.AddDetails(orderDetails1);
            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);
            order1.jisuan();//计算订单总金额
            order2.jisuan();
            order3.jisuan();
            List<Order> orders = os.Query(1000);
            List<Order> result = new List<Order>();
            result.Add(order1);
            result.Add(order2);
            CollectionAssert.AreEqual(result, orders);
        }

        [TestMethod()]
        public void ExportTest()
        {
            order1.AddDetails(orderDetails1);
            order1.AddDetails(orderDetails2);
            order1.AddDetails(orderDetails3);
            os.AddOrder(order1);
            order1.jisuan();
            Assert.IsTrue(os.Export(order1));
        }

        [TestMethod()]
        public void ImportTest()
        {
            order1.AddDetails(orderDetails1);
            order1.AddDetails(orderDetails2);
            order1.AddDetails(orderDetails3);
            os.AddOrder(order1);
            order1.jisuan();
            os.Export(order1);
            Assert.IsTrue(os.Import("sk.xml"));//从sk.xml文件中载入订单
        }
    }
}