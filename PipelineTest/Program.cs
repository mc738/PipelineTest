using System;
using System.Threading;
using System.Threading.Tasks;

namespace PipelineTest
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello World!");

            Wait(2000);

            Console.WriteLine("Hello again");

        }

        static void Wait(int time)
        {
            Thread.Sleep(time);
        }
    }
}
