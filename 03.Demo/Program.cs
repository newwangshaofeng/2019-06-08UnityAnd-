using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var func = new Func<string>(Test);
            func.BeginInvoke(CallBack, func);
            Console.WriteLine("end");

            Console.ReadKey();

        }

        private static void CallBack(IAsyncResult async)
        {
            var result = async.AsyncState as Func<string>;
            Console.WriteLine(result.EndInvoke(async));
           
        }

        private static string Test()
        {
            return DateTime.Now.ToString();
        }
    }
}
