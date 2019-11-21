using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Controllers;
using WebAPI.Models;

namespace WebAPI.Models.Response
{
    public class ResonseCategoryList
    {
       
        public RequstStatus requestStatus { get; set; }
        public virtual List<Category> Categories { get; set; }

    }
}
