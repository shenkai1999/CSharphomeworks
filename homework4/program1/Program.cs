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
                Clock a = new Clock();
                a.timing += new ClockEventHandler(follow);//添加一个委托实例
                Console.WriteLine("请输入设置的闹钟时间:");
            string clocktime = Console.ReadLine();

                a.DoClock(clocktime);//设置闹钟时间

            }
            static void follow(object sender, ClockEventArgs args)
            {

                Console.WriteLine("现在时间是:" + DateTime.Now.ToShortTimeString().ToString());
            }
        }
    }

