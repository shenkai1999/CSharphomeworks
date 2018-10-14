using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class OrderService
    {
        private Dictionary<uint, Order> orderDict;//把订单放入字典，订单号作为key值

        public OrderService()
        {
            orderDict = new Dictionary<uint, Order>();
        }


        public void AddOrder(Order order)
        {

            orderDict[order.Id] = order;
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

            List<Order> result = new List<Order>();
            foreach (Order order in orderDict.Values)
            {
               var query = from detail in order.Details
                             where detail.goodsname == goodsName
                             select order;
                result.Add(order);
                break;
            }
            return result;

            }
        public List<Order> Query(double a)//根据金额查询订单
        {
            var query = orderDict.Values
                .Where(order => order.sum > a);
            return query.ToList();
        }
    }
}
