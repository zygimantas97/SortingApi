using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortingApi.Contracts.V1.Requests
{
    public class SortingRequest
    {
        public string Sequence { get; set; }
        public AlgorithmType Algorithm { get; set; }
    }

    public enum AlgorithmType
    {
        BubbleSort,
        MergeSort
    }
}
