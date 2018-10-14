using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class OrderDetails
    {
        public string goodsname;
        public int goodsnumber;
        public double goodsprice;
        public OrderDetails(string a, int b ,double c)
        {
            goodsname = a;
            goodsnumber = b;
            goodsprice = c;
        }
        
        public uint Id { get; set; }
             
        
        public override string ToString()
        {
            string result = "";
            result +=  $"goodsname:{goodsname}, goodsnumber:{goodsnumber},goodsprice:{goodsprice}";
            return result;
        }
    }
}
