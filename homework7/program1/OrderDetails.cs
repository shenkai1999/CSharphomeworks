using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    public class OrderDetails
    {
        public string goodsname { get; set; }
        public int goodsnumber{ get; set; }
        public double goodsprice{ get; set; }
        public OrderDetails()
        {

        }
        public OrderDetails(string a, int b, double c)
        {
            goodsname = a;
            goodsnumber = b;
            goodsprice = c;
        }

        


        public override string ToString()
        {
            string result = "";
            result += $"goodsname:{goodsname}, goodsnumber:{goodsnumber},goodsprice:{goodsprice}";
            return result;
        }
    }
}
