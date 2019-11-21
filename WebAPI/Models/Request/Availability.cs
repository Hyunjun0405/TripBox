using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.Request
{
    
    public class Availability
    {
        [Required]
        public string[] codeProduct { get; set; }
        public DateTime datetimeStart { get; set; }
        public DateTime datetimeEnd { get; set; }
        public int quantity { get; set; }
        public int offset { get; set; }
    }

   
}
