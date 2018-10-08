using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    public class Order
    {

        public OrderDetails[] a = new OrderDetails[3];
        public string Customer;
        public string OrderNumber;
        public Order next;
        public int length;


    }
}

