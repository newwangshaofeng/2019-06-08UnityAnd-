using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> dates=new List<int>();

             Random rd=new Random();

            for (int i = 0; i < 1000000; i++)
            {
                dates.Add(rd.Next());
            }

            //计时器
            Stopwatch watch=new Stopwatch();
            Stopwatch watch2=new Stopwatch();
            watch.Start();

            var c = dates.Where(d => d % 3 == 0);
            Console.WriteLine(c.Count());


            watch.Stop();

            //PLinq
            watch2.Start();
            var c2 = dates.AsParallel().Where(d => d % 3 == 0);
            Console.WriteLine(c2.Count());


            watch2.Stop();
           

            //打印出运行花了多长时间(ms)
            Console.WriteLine("Linq"+watch.ElapsedMilliseconds+"ms");
            Console.WriteLine("PLinq"+watch2.ElapsedMilliseconds+"ms");

            Console.ReadKey();
        }
    }
}
