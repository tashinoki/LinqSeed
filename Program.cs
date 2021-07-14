using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Diagnostics;
using System.Threading;

namespace LinqSpeed
{
    class Program
    {
        private static Stopwatch sw = new Stopwatch();

        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 1000000);
            Console.WriteLine($"{GC.GetTotalMemory(false)}");
            numbers.ToList();
            Console.WriteLine($"{GC.GetTotalMemory(false)}");
            //EvaluateEnumerbleCost();
        }

        private static void EvaluateEnumerbleCost()
        {
            sw.Start();
            var nums = GetNums().ToList();
            for (var i = 0; i < nums.Count(); i++)
            {
                Console.WriteLine(i);
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }

        private static IEnumerable<int> GetNums()
        {
            Thread.Sleep(1000);
            yield return 0;

            Thread.Sleep(1000);
            yield return 1;

            Thread.Sleep(1000);
            yield return 2;

            Thread.Sleep(1000);
            yield return 3;
        }
    }
}
