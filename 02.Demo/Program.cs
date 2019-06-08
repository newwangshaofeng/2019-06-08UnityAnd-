using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02.Demo
{
    class Program
    {
        private static int counter = 20;
        private static object CouterLockerHelper=new object();
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
            ThreadPool.QueueUserWorkItem(Get);
            ThreadPool.QueueUserWorkItem(Get);
            }

            Console.ReadKey();

        }

        static void Get(object state)
        {
            lock (CouterLockerHelper)
            {
                if (counter > 1)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    counter--;

                }

            }

            Console.WriteLine(counter);
        }
    }
}
