using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class TagSpot
    {
        public long idSpot { get; set; }
        [StringLength(4)]
        public string typeTag { get; set; }
        [StringLength(20)]
        public string tag { get; set; }

        [ForeignKey("idSpot")]
        [InverseProperty("TagSpot")]
        public virtual Spot idSpotNavigation { get; set; }
    }
}