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
    public abstract class Graphical
    {
        public double length;      
        public double acreage;
        public abstract double showacreage();
    }
    public class Rctangle : Graphical
    {
         private double width;   
        public override double showacreage()
        {
            Console.WriteLine("请输入长方形的长：");
            string b = Console.ReadLine();
            length = double.Parse(b);
            Console.WriteLine("请输入长方形的宽：");
            string c = Console.ReadLine();
            width = double.Parse(c);
            acreage = length * width;
            return acreage;
        }
    }
    public class Square : Graphical
    {
        public override double showacreage()
        {
            Console.WriteLine("请输入正方形的边长：");
            string a = Console.ReadLine();
            length = double.Parse(a);
            acreage = length * length;
            return acreage;
        }
    }
    public class Circular : Graphical
    {
        private double radii;
        public override double showacreage()
        {
            Console.WriteLine("请输入圆形的半径：");
            string a = Console.ReadLine();
            radii = double.Parse(a);
            acreage = 3.14 * radii * radii;
            return acreage;
        }
    }
    public class Triangle : Graphical
    {
        private double a;
        private double b;
        private double c;
        public override double showacreage()
        {
            Console.WriteLine("请输入三角形的第一条边长：");
            string x = Console.ReadLine();
            a = double.Parse(x);
            Console.WriteLine("请输入三角形的第二条边长：");
            string y = Console.ReadLine();
            b = double.Parse(y);
            Console.WriteLine("请输入三角形的第三条边长：");
            string z = Console.ReadLine();
            c = double.Parse(z);
            double p= (a+b+c)/2;
            acreage=Math.Sqrt( p*(p-a)*(p-b)*(p-c));
            return acreage;
        }
    }
    public class GraphicalFactory
    {
        public static Graphical CreatGraphical(string type)
        {
            Graphical n = null;
            switch (type)
            {
                case "长方形":
                    n = new Rctangle();
                    break;
                case "正方形":
                    n = new Square();
                    break;
                case "圆形":
                    n = new Circular();
                    break;
                case "三角形":
                    n = new Triangle();
                    break;
            }
            return n;
        }
    }
}