using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using WebAPI.Models.Request;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvailabilityController : ControllerBase
    {

        /// <summary>
        /// Load availability information for a specific date range
        /// </summary>
        /// <param name="codeProduct">Product code in format P12345. You can request multiple products: \"productCode=P11111&productCode=P22222&productCode=P33333\", which belong to a single supplier.</param>
        /// <param name="datetimeStart">Start time in ISO 8601 format, e.g. 2014-03-01T00:00:00Z</param>
        /// <param name="datetimeEnd">End time in ISO 8601 format, e.g. 2014-03-01T00:00:00Z</param>
        /// <param name="quantity">limit How many results are returned per request. Maximum is 1000, and the default is 100 when not specified.</param>
        /// <param name="offset">offset Offset of the first result to return. Default to 0.</param>
        /// 

        [HttpGet]
        [SwaggerOperation(Summary = "Gets two values", Description = "Gets two hardcoded values")]        
        public ResponseSessionList checkAvailability(string codeProduct, DateTime datetimeStart, DateTime datetimeEnd,int? quantity, int? offset)
        {
            return null;
        }
    }
}