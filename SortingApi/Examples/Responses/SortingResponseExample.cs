using SortingApi.Contracts.V1.Responses;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortingApi.Examples.Responses
{
    public class SortingResponseExample : IExamplesProvider<SortingResponse>
    {
        public SortingResponse GetExamples()
        {
            return new SortingResponse
            {
                SortedSequenceę = "1 2 3 4 5 6 7 8 9 10"
            };
        }
    }
}
