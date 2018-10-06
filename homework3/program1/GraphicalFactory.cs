using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    
    public class GraphicalFactory
    {
        public  double x=0, y=0, z=0;
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

