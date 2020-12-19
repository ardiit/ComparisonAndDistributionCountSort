using System;
using System.Diagnostics;
using System.Linq;

namespace ComparisonAndDistributionCountSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] randomArray = Enumerable.Range(1, 1000000).OrderBy(b => random.Next()).ToArray();

            Stopwatch stopwatch1 = new Stopwatch();

            stopwatch1.Start();
            Comparison.BubbleSort(randomArray, randomArray.Length);
            stopwatch1.Stop();


            Stopwatch stopwatch2 = new Stopwatch();

            stopwatch2.Start();
            Distribution.CountingSort(randomArray, randomArray.Length);
            stopwatch2.Stop();

            Console.WriteLine($"Comparison Algorithm time:{stopwatch1.Elapsed}");
            Console.WriteLine($"Distribution Algorithm time:{stopwatch2.Elapsed}");

        }
    }
}
