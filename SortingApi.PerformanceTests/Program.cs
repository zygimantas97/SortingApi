using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SortingApi.PerformanceTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var countsOfNumbers = new List<int> { 10, 100, 1000, 10000, 100000 };
            var random = new Random();
            var stopwatch = new Stopwatch();

            foreach (var count in countsOfNumbers)
            {
                var sequence = new List<int>();

                for(int i = 0; i < count; i++)
                {
                    sequence.Add(random.Next(1, count + 1));
                }

                Console.WriteLine(new String('-', 30));
                Console.WriteLine(String.Format("{0, -20} {1}", "Count of elements:", count));

                stopwatch.Start();
                Utilities.Sorting.MergeSort(sequence);
                stopwatch.Stop();
                Console.WriteLine(String.Format("{0, -20} {1} ms", "MergeSort:", stopwatch.ElapsedMilliseconds));

                stopwatch.Restart();
                Utilities.Sorting.BubbleSort(sequence);
                stopwatch.Stop();
                Console.WriteLine(String.Format("{0, -20} {1} ms", "BubbleSort:", stopwatch.ElapsedMilliseconds));

                stopwatch.Reset();
            }
            Console.WriteLine(new String('-', 30));
        }
    }
}
