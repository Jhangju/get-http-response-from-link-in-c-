using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace http_responce
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = new WebClient().DownloadString("https://google.com");
            Console.WriteLine(json);
            Console.ReadLine();
        }
    }
}
