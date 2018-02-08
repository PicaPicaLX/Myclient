using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCodeLibrary;

namespace Myclient
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();
            string value = myScrape.ScrapeWebpage("http://www.2345.com", @"C:\Users\lx389\Documents\reply.txt");
            //string value1 = myScrape.ScrapeWebpage("http://www.2345.com"); // 由于ScrapeWebpage方法有两个重载，所以可以以两种方式发挥作用
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
