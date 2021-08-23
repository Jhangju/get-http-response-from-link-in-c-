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
            
            
            
            try
            { 
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://google.com");

                req.Method = "POST";
                string Data = "id=" + comid + "&name=" + cmd + "&result=" + HttpUtility.UrlEncode(text);
                byte[] postBytes = Encoding.ASCII.GetBytes(Data);
                req.ContentType = "application/x-www-form-urlencoded";
                req.ContentLength = postBytes.Length;
                Stream requestStream = req.GetRequestStream();
                requestStream.Write(postBytes, 0, postBytes.Length);
                requestStream.Close();

                HttpWebResponse response = (HttpWebResponse)req.GetResponse();
                Stream resStream = response.GetResponseStream();

                var sr = new StreamReader(response.GetResponseStream());
                string responseText = sr.ReadToEnd();
                Console.WriteLine(responseText);

             }
            catch (WebException)
            {

                Console.WriteLine("Please Check Your Internet Connection");
            }
        }
    }
}
