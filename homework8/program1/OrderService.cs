using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Xml;

namespace program1
{
     public class OrderService
    {
        private Dictionary<int, Order> orderDict;

        public OrderService()
        {
            orderDict = new Dictionary<int, Order>();//把订单放入字典，订单号作为key值
            
        }


        public int AddOrder(Order order)//添加订单
        {

            orderDict[order.Id] = order;
            return 0;
        }
        public int RemoveOrder(int orderId)//删除订单
        {
            orderDict.Remove(orderId);
            return 0;
        }

        public List<Order> QueryAllOrders() //查询所有订单
        {
            return orderDict.Values.ToList();
        }

        public List<Order> QueryByCustomerName(string customerName)//根据客户名字查询订单，使用linq语句
        {
            var query = orderDict.Values
                .Where(order => order.customername == customerName);
            return query.ToList();
        }
        public List<Order> QueryByGoodsName(string goodsName)//根据商品名字查询订单，使用linq语句
        {
            var query = orderDict.Values.Where(order => order.Details.Where(d => d.goodsname == goodsName).Count() > 0);
            return query.ToList();


        }
        public List<Order> Query(double a)//根据金额查询订单
        {
            var query = orderDict.Values
                .Where(order => order.sum > a);
            return query.ToList();
        }
        public void UpdateCustomer(int orderId, String newCustomer)//修改订单的客户名称
        {
            if (orderDict.ContainsKey(orderId))
            {
                orderDict[orderId].customername = newCustomer;
            }
            else
            {
                throw new Exception($"order-{orderId} is not existed!");
            }
        }
        public bool Export(Order order)//将订单序列化为xml文件
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order));
            using (FileStream fs = new FileStream("order.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, order);
            }
            Console.WriteLine(File.ReadAllText("order.xml"));
            return true;
        }
        public bool Import(String xmlname)//从xml文件中载入订单
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order));
            using (FileStream fs = new FileStream("order.xml", FileMode.Open))
            {
                Order neworder = (Order)xmlSerializer.Deserialize(fs);
                Console.WriteLine(neworder);
            }
            return true;
        }
        public bool datacheck(Order checkorder)//数据验证
        {
            string pattern = @"^[0-9]{4}\s1?[0-9]\s[1-3]?[0-9]\s[0-9]{3}$";
            Regex rx = new Regex(pattern);
            if (rx.IsMatch(checkorder.ordernumber))
            {
                Console.WriteLine("数据验证成功");
                return true;
            }
            else
            {
                Console.WriteLine("数据验证失败");
                return false;
            }
        }
        public void ExportHtml(Order order)//将订单导出为HTML文件
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order));
            using (FileStream fs = new FileStream("order.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, order);
            }
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@".\order.xml");

                XPathNavigator nav = doc.CreateNavigator();
                nav.MoveToRoot();

                XslCompiledTransform xt = new XslCompiledTransform();
                xt.Load(@".\order.xslt");

                FileStream outFileStream = File.OpenWrite(@".\order.html");
                XmlTextWriter writer =
                    new XmlTextWriter(outFileStream, System.Text.Encoding.UTF8);
                xt.Transform(nav, null, writer);


            }
            catch (XmlException e)
            {
                Console.WriteLine("XML Exception:" + e.ToString());
            }
            catch (XsltException e)
            {
                Console.WriteLine("XSLT Exception:" + e.ToString());
            }
        }
    }
}
