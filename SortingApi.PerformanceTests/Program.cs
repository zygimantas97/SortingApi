using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingApi.PerformanceTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = new List<int> {3,5,1,4,2};
            var sortedSequence = Utilities.Sorting.MergeSort(sequence);
            foreach(var item in sortedSequence)
            {
                Console.WriteLine(item);
            }
        }
    }
}
