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
            return Ok("success");
        }

        /// <summary>
        /// Sorts given sequence of numbers
        /// </summary>
        /// <response code="200">Returns sorted sequence</response>
        /// <response code="400">Wrong format of sequence</response>
        [HttpPost]
        [ProducesResponseType(typeof(SortingResponse), 200)]
        [ProducesResponseType(typeof(ErrorResponse), 400)]
        public IActionResult SortSequence(SortingRequest request)
        {
            return Ok("success");
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
            return Ok("success");
        }
    }
}
