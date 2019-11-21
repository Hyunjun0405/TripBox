using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ResponseSessionList
    {

        public RequstStatus status { get; set; }
        public virtual List<ProductSession> sessions { get; set; }

    }
}