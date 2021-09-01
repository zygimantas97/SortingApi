using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortingApi.Utilities
{
    public class Sorting
    {
        public static List<int> MergeSort(List<int> sequence)
        {
            if (sequence.Count <= 1)
                return new List<int>(sequence);

            int middlePoint = sequence.Count / 2;
            var left = MergeSort(sequence.Take(middlePoint).ToList());
            var right = MergeSort(sequence.Skip(middlePoint).ToList());
            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            var sortedSequence = new List<int>();
            int indexLeft = 0;
            int indexRight = 0;

            while(indexLeft < left.Count || indexRight < right.Count)
            {
                if(indexLeft < left.Count && indexRight < right.Count)
                {
                    if(left[indexLeft] <= right[indexRight])
                    {
                        sortedSequence.Add(left[indexLeft]);
                        indexLeft++;
                    }
                    else
                    {
                        sortedSequence.Add(right[indexRight]);
                        indexRight++;
                    }
                }
                else if(indexLeft < left.Count)
                {
                    sortedSequence.Add(left[indexLeft]);
                    indexLeft++;
                }
                else
                {
                    sortedSequence.Add(right[indexRight]);
                    indexRight++;
                }
            }

            return sortedSequence;
        }

        public static List<int> BubbleSort(List<int> sequence)
        {
            var sortedSequence = new List<int>(sequence);
            for(int i = 0; i < sortedSequence.Count - 1; i++)
            {
                for(int j = 0; j < sortedSequence.Count-i-1; j++)
                {
                    if(sortedSequence[j] > sortedSequence[j + 1])
                    {
                        int temp = sortedSequence[j];
                        sortedSequence[j] = sortedSequence[j + 1];
                        sortedSequence[j + 1] = temp;
                    }
                }
            }
            return sortedSequence;
        }
    }
}
