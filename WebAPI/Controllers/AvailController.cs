using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using WebAPI.Models;

namespace WebAPI.Controllers
{
   
    /// 
    [Route("/[controller]")]
    [ApiController]

    public class AvailController : ControllerBase
    {       
        
       
        /// <summary>
        /// Search Availability.
        /// </summary>
        /// <param name="id"></param> 
        [HttpGet]
        [Produces("application/json", "application/xml")]
        [SwaggerOperation(
            Summary = "Creates a new product",
            Description = "Load availability information for a specific date range.<br>This will return a list of sessions, including their availability and pricing details.<br><p>Pricing in the session can be different than the pricing of the products, in a case when a supplier overrides a price for a specific session or a ticket type.</p><p>Since Rezdy introduced shared availability option for products, the product sessions can contain price overrides for all of the products, which share the sessions. Therefore it is necessary to filer only the price options matching the chosen product code on the client side, when processing /availability service responses.</p>",
            OperationId = "checkAvailability",
            Tags = new[] { "Purchase", "Products" }
        )]
        public ActionResult<ResponseSessionList> Search([FromQuery]string SearchParams)
        {
            return null;
        }

        
    }

    
}