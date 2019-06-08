using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _04.Demo_EAP_
{
    class Program
    {
        /// <summary>
        /// 事件异步模型(EAP)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            WebClient wc=new WebClient();

            wc.DownloadStringCompleted += Wc_DownloadStringCompleted;
            wc.DownloadStringAsync(new Uri("http://www.baidu.com"));

            //此时可以在下载的时候干点其它的事情
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            
            Console.ReadKey();
        }

        private static void Wc_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            Console.WriteLine(e.Result);
        }
    }
}
