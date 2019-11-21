using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using WebAPI.Models;
using WebAPI.Models.Response;

namespace WebAPI.Controllers
{
    [Route("/[controller]")]
    [ApiController]
   

    public class CategoryController : ControllerBase
    {
        private readonly TripboxDbContext _context;
        public CategoryController(TripboxDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Produces("application/json", "application/xml")]
        [SwaggerOperation(
            Summary = "Creates a new product",
            Description = "Load availability information for a specific date range.<br>This will return a list of sessions, including their availability and pricing details.<br><p>Pricing in the session can be different than the pricing of the products, in a case when a supplier overrides a price for a specific session or a ticket type.</p><p>Since Rezdy introduced shared availability option for products, the product sessions can contain price overrides for all of the products, which share the sessions. Therefore it is necessary to filer only the price options matching the chosen product code on the client side, when processing /availability service responses.</p>",
            OperationId = "checkAvailability",
            Tags = new[] { "Purchase", "Products" }
        )]
        public ResonseCategoryList Search()
        {
            ResonseCategoryList rs = new ResonseCategoryList();
            try
            {                
                rs.Categories = _context._Category.ToList();
                rs.requestStatus.success = true;
                return rs;
            }
            catch (Exception ex)
            {
                var set = new SetStatus();
                set.Set(rs.requestStatus, ex);                
                return rs;
            }

        }

        //private void SetStatus(RequstStatus requestStatus, Exception ex)
        //{
        //    throw new NotImplementedException();
        //}
    }
}