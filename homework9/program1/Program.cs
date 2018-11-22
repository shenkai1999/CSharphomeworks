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
            Crawler myCrawler = new Crawler();
            string startUrl = "http://www.cnblogs.com/dstang2000/";
            if (args.Length >= 1) startUrl = args[0];
            myCrawler.urls.Add(startUrl, false); //加入初始页面
            Thread thread1 = new Thread(new ThreadStart(myCrawler.Crawl));
            Thread thread2 = new Thread(new ThreadStart(myCrawler.Crawl));
            thread1.Start();
            thread2.Start();
           // new Thread(myCrawler.Crawl).Start();//开始爬行
        }
    }
}
