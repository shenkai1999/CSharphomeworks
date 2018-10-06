using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Graphical zhengfangxing = GraphicalFactory.CreatGraphical("正方形");
                Console.WriteLine("正方形的面积为：" + zhengfangxing.showacreage());
                Graphical changfangxing = GraphicalFactory.CreatGraphical("长方形");
                
                
                Console.WriteLine("长方形的面积为：" + changfangxing.showacreage());
                Graphical yuanxing = GraphicalFactory.CreatGraphical("圆形");
                Console.WriteLine("圆形的面积为：" + yuanxing.showacreage());
                Graphical sanjiaoxing = GraphicalFactory.CreatGraphical("三角形");
                Console.WriteLine("三角形的面积为：" + sanjiaoxing.showacreage());
            }
            catch (Exception ex)
            {
                Console.WriteLine("您输入有错：" + ex.Message);
            }
        }
    }
}
    
   
    
    
    