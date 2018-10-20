using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
namespace program1
{
    public class OrderService
    {
        private Dictionary<uint, Order> orderDict;

        public  OrderService()
        {
            orderDict = new Dictionary<uint, Order>();//把订单放入字典，订单号作为key值
           
        }


        public int AddOrder(Order order)//添加订单
        {

            orderDict[order.Id] = order;
            return 0;
        }
        public int RemoveOrder(uint orderId)//删除订单
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
        public bool Export(Order order)//将订单序列化为xml文件
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order));
            using (FileStream fs = new FileStream("sk.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs,order );
            }
            Console.WriteLine(File.ReadAllText("sk.xml"));
            return true;
        }
        public bool Import(String xmlname)//从xml文件中载入订单
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order));
            using (FileStream fs = new FileStream("sk.xml", FileMode.Open))
            {
                Order neworder = (Order)xmlSerializer.Deserialize(fs);
                Console.WriteLine(neworder);
            }
            return true;
        }
    }
}
