using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _05.Demo_TPL_
{
    /// <summary>
    /// 编写异步方法
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //调用异步测试方法
            Test1();

            Console.ReadKey();
        }

        static async void Test1()
        {
            string str = await F1Async();
            Console.WriteLine(str);
        }


        static Task<string> F1Async()
        {
            return Task.Run(() =>
            {
                Thread.Sleep(TimeSpan.FromSeconds(2));
                return "F2";
            });
        }
    }
}
