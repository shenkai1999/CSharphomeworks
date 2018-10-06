using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public delegate void ClockEventHandler(object sender, ClockEventArgs e); //定义一个委托，申明事件处理函数的格式 
    public class Clock
    {
        public event ClockEventHandler timing; //定义事件，相当于申明一个委托实例，初值为null
        public void DoClock (string mytime)//触发DoClock事件
        {
            ClockEventArgs args = new ClockEventArgs();
            args.ding = mytime;
            timing(this, args);
            if (mytime == DateTime.Now.ToShortTimeString().ToString())
            {
                Console.WriteLine("闹钟响了，起床啦！");
            }
            else
                Console.WriteLine("时间还没到，再睡一会吧！");
        }
    }
}
