using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortingApi.Contracts.V1.Responses
{
    public class ErrorResponse
    {
        public List<Error> Errors { get; set; } = new List<Error>();
    }

    public class Error
    {
        public string Message { get; set; }
    }
}
