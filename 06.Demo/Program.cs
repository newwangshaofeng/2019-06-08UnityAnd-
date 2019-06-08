using System;
using System.Threading;
using System.Threading.Tasks;

namespace _06.Demo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Task task=new Task(Test);

            //task.Start();

            var task1 = Task.Factory.StartNew(Test);
            var task2 = Task.Factory.StartNew(Test);
            var task3 = Task.Factory.StartNew(Test);
            Task.WaitAll(task1, task2);


            // task1.Wait();

            Console.WriteLine("faaaaa ");

            Console.ReadKey();
        }

        private static void Test()
        {
            Console.WriteLine("happy coding");
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }
    }
}