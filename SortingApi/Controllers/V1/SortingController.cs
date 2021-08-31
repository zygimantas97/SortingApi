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
        /// Sorts given sequence of numbers
        /// </summary>
        /// <response code="200">Returns sorted sequence of numbers</response>
        [HttpPost]
        [ProducesResponseType(typeof(SortingResponse), 200)]
        public async Task<IActionResult> GetGames(SortingRequest request)
        {
            return Ok("success");
        }
    }
}
