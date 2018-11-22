using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace program1
{
    public class Crawler
    {
        public Hashtable urls = new Hashtable();
        public int count;
       
        public void Crawl()
        {
            Console.WriteLine("开始爬行了。。。");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)//找到一个还没有下载过的链接
                {
                    if ((bool)urls[url]) continue;//已经下载过的不再下载
                    current = url;
                }
                if (current == null || count > 100) break;
                Console.WriteLine("爬行" + current + "页面!");
               
                string html =Download(current);//下载              
                urls[current] = true;
                count++;
                Parse(html);//解析，并加入新的链接
              
               
            }
            Console.WriteLine("爬行结束");
        }
        public string Download(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }
        public void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matchs = new Regex(strRef).Matches(html);
            foreach (Match match in matchs)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', ' ', '>');
                if (strRef.Length == 0) continue;
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }
    }
}
