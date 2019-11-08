using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.Parameter
{
    [SwaggerSchemaFilter(typeof(SearchParamsSchemaFilter))]
    public class SearchParams
    {

        
        [Required]
        public string[] productCode { get; set; }
        //public DateTime SearchParamsSchemaFilter { get; set; }
    }

    public class SearchParamsSchemaFilter : ISchemaFilter
    {
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            var type = context.ApiModel.Type;
            if (type.IsEnum)
            {
                schema.Extensions.Add(
                    "x-ms-enum",
                    new OpenApiObject
                    {
                        ["name"] = new OpenApiString(type.Name),
                        ["modelAsString"] = new OpenApiBoolean(true)
                    }
                );
            };
        }
    }
}
