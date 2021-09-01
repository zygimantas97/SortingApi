using SortingApi.Contracts.V1.Requests;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortingApi.Examples.Requests
{
    public class SortingRequestExample : IExamplesProvider<SortingRequest>
    {
        public SortingRequest GetExamples()
        {
            return new SortingRequest
            {
                Sequence = "7 3 6 2 10 8 1 4 9 5",
                Algorithm = AlgorithmType.MergeSort
            };
        }
    }
}
