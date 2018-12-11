using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            String startUrl = "http://www.cnblogs.com/dstang2000/";           
            ParallerCrawler crawler2 = new ParallerCrawler();
            crawler2.Start(startUrl,20);
            Console.ReadKey();
        }
    }
}
