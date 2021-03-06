using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SortingApi.Contracts.V1.Requests;
using SortingApi.Contracts.V1.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortingApi.Controllers.V1
{
    [Produces("application/json")]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SortingController : ControllerBase
    {
        /// <summary>
        /// Returns last sorted sequence of numbers
        /// </summary>
        /// <response code="200">Returns sorted sequence</response>
        /// <response code="404">There is not sorted sequence</response>
        [HttpGet]
        [ProducesResponseType(typeof(SortingResponse), 200)]
        [ProducesResponseType(typeof(ErrorResponse), 404)]
        public IActionResult GetLastSortedSequence()
        {
            if(!System.IO.File.Exists("./SortedSequence.txt"))
            {
                return NotFound(new ErrorResponse
                {
                    Errors = new List<Error>
                    {
                        new Error
                        {
                            Message = "There is not sorted sequence"
                        }
                    }
                });
            }

            return Ok(new SortingResponse
            {
                SortedSequence = System.IO.File.ReadAllText("./SortedSequence.txt")
            });
        }

        /// <summary>
        /// Sorts given sequence of numbers
        /// </summary>
        /// <response code="201">Returns sorted sequence</response>
        /// <response code="400">Wrong format of sequence</response>
        [HttpPost]
        [ProducesResponseType(typeof(SortingResponse), 201)]
        [ProducesResponseType(typeof(ErrorResponse), 400)]
        public IActionResult SortSequence(SortingRequest request)
        {
            try
            {
                var sequence = request.Sequence.Split(" ").Select(s => int.Parse(s)).ToList();
                List<int> sortedSequence;

                switch (request.Algorithm)
                {
                    case AlgorithmType.BubbleSort:
                        sortedSequence = Utilities.Sorting.BubbleSort(sequence);
                        break;
                    case AlgorithmType.MergeSort:
                        sortedSequence = Utilities.Sorting.MergeSort(sequence);
                        break;
                    default:
                        sortedSequence = Utilities.Sorting.BubbleSort(sequence);
                        break;
                }

                var sortedSequenceString = string.Join(" ", sortedSequence.Select(x => x.ToString()));

                System.IO.File.WriteAllText("./SortedSequence.txt", sortedSequenceString);

                return CreatedAtAction("GetLastSortedSequence", new SortingResponse
                {
                    SortedSequence = sortedSequenceString
                });
            }
            catch (Exception)
            {
                return BadRequest(new ErrorResponse
                {
                    Errors = new List<Error>
                    {
                        new Error
                        {
                            Message = "Wrong format of sequence"
                        }
                    }
                });
            }
        }

        /// <summary>
        /// Deletes last sorted sequence of numbers
        /// </summary>
        /// <response code="200">Returns sorted sequence</response>
        /// <response code="404">There is not sorted sequence</response>
        [HttpDelete]
        [ProducesResponseType(typeof(SortingResponse), 200)]
        [ProducesResponseType(typeof(ErrorResponse), 404)]
        public IActionResult DeleteLastSortedSequence()
        {
            if (!System.IO.File.Exists("./SortedSequence.txt"))
            {
                return NotFound(new ErrorResponse
                {
                    Errors = new List<Error>
                    {
                        new Error
                        {
                            Message = "There is not sorted sequence"
                        }
                    }
                });
            }

            var sortedSequenceString = System.IO.File.ReadAllText("./SortedSequence.txt");
            System.IO.File.Delete("./SortedSequence.txt");

            return Ok(new SortingResponse
            {
                SortedSequence = sortedSequenceString
            });
        }
    }
}
