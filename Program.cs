using Stopwatch;
using System;
using System.Threading;

namespace Stopwatch
{


    internal class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new StopWatch();

            for (var i = 0; i < 2; i++)
            {
                stopwatch.Start(DateTime.Now);

                Thread.Sleep(1000);

                stopwatch.Stop(DateTime.Now);

                Console.WriteLine("Duration:" + stopwatch.GetInterval());

                Console.WriteLine("Press Enter to run the stopwatch one more time.");

                Console.ReadLine();


            }
        }
    }
}