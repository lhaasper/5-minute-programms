//written in 2 Minutes and 52 seconds.
//made by lhaasper+

using System;
using System.IO;
using System.Net;
using System.Threading;

namespace proxychecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Website URL viewer";
            Console.Write("Put in URL to see HTML: ");
            string website = Console.ReadLine();
            WebRequest request = WebRequest.Create(website);
            request.Credentials = CredentialCache.DefaultCredentials;

            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                Console.WriteLine(responseFromServer);
            }

            response.Close();
            Thread.Sleep(300000);
        }
    }
}
