using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
  public  class Order
    {
        public List<OrderDetails> details = new List<OrderDetails>();
                        
        public double sum;
        public void jisuan()
        {
            foreach (OrderDetails b in details)
                sum += b.goodsnumber * b.goodsprice;
        }
        public Order()
        {

        }
        public Order(int orderId, string a)
        {
            customername = a;
            Id = orderId;
            
        }
        public string customername { get; set; }
        public int Id { get; set; }
       

        public List<OrderDetails> Details
        {
            get => this.details;
            
        }


        public void AddDetails(OrderDetails orderDetail)
        {
           
            details.Add(orderDetail);

        }
        public override string ToString()
        {
            string result = "================================================================================\n";
            result += $"orderId:{Id} ";
            details.ForEach(od => result += "\n\t" + od);
            result += "\n================================================================================";
            return result;
        }
    }
}
