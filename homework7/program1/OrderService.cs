using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public  void UpdateCustomer(int orderId,String newCustomer)
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
    }
}
