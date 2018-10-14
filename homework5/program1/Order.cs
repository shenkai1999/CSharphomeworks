using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Order
    {
        private List<OrderDetails> details = new List<OrderDetails>();
        public string customername;
        public double sum;
        public void jisuan()
        {
            foreach (OrderDetails b in details)
                sum += b.goodsnumber * b.goodsprice;
        }
        public Order(uint orderId, string a)
        {
            
            Id = orderId;
            customername = a;
        }
        public uint Id { get; set; }   
      
                
        public List<OrderDetails> Details
        {
            get => this.details;
        }

        
        public void AddDetails(OrderDetails orderDetail)
        {
            if (this.Details.Contains(orderDetail))
            {
                throw new Exception($"orderDetails-{orderDetail.Id} is already existed!");
            }
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
