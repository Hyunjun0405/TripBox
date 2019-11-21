using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class Spot
    {
        public Spot()
        {
            //PickupSpot = new HashSet<PickupSpot>();
            //TagSpot = new HashSet<TagSpot>();
        }

        public long id { get; set; }
        [StringLength(100)]
        public string name { get; set; }
        [StringLength(4)]
        public string typeSpot { get; set; }
        public long idCity { get; set; }
        [StringLength(10)]
        public string postcode { get; set; }
        [StringLength(100)]
        public string address1 { get; set; }
        [StringLength(100)]
        public string address2 { get; set; }
        [StringLength(20)]
        public string latitude { get; set; }
        [StringLength(20)]
        public string longitude { get; set; }

        [ForeignKey("idCity")]
        [InverseProperty("Spot")]
        public virtual City idCityNavigation { get; set; }
        //[InverseProperty("idSpotNavigation")]
        //public virtual ICollection<PickupSpot> PickupSpot { get; set; }
        //[InverseProperty("idSpotNavigation")]
        //public virtual ICollection<TagSpot> TagSpot { get; set; }
    }
}