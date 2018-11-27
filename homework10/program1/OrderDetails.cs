using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace program1
{
    public class OrderDetails
    {
        [Key]
        public int DetailID { get; set; }
        public string goodsname { get; set; }
        public int goodsnumber { get; set; }
        public double goodsprice { get; set; }
        public OrderDetails()
        {

        }
        public OrderDetails(int d,string a, int b, double c)
        {
            DetailID = d;
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
