using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class PickupSpot
    {
        public PickupSpot()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        public long id { get; set; }
        public long idPickup { get; set; }
        public long idSpot { get; set; }
        [Required]
        [StringLength(100)]
        public string name { get; set; }
        public short? minutePrior { get; set; }
        [StringLength(2000)]
        public string addInstruction { get; set; }

        [ForeignKey("idPickup")]
        [InverseProperty("PickupSpot")]
        public virtual Pickup idPickupNavigation { get; set; }
        [ForeignKey("idSpot")]
        [InverseProperty("PickupSpot")]
        public virtual Spot idSpotNavigation { get; set; }
        [InverseProperty("idPickupSpotNavigation")]
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}