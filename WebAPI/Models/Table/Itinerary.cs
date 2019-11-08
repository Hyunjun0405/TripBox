using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class Itinerary
    {
        public long idProduct { get; set; }
        [StringLength(4)]
        public string typePart { get; set; }
        [StringLength(100)]
        public string time { get; set; }
        public string listCity { get; set; }
        public string listSpot { get; set; }
        [StringLength(1000)]
        public string note { get; set; }

        [ForeignKey("idProduct")]
        [InverseProperty("Itinerary")]
        public virtual Product idProductNavigation { get; set; }
    }
}