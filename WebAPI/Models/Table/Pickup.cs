using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class Pickup
    {
        public Pickup()
        {
            PickupSpot = new HashSet<PickupSpot>();
            Product = new HashSet<Product>();
        }

        public long id { get; set; }
        public long idSupplier { get; set; }
        [StringLength(100)]
        public string name { get; set; }
        [StringLength(2000)]
        public string instruction { get; set; }

        [InverseProperty("idPickupNavigation")]
        public virtual ICollection<PickupSpot> PickupSpot { get; set; }
        [InverseProperty("idPickupNavigation")]
        public virtual ICollection<Product> Product { get; set; }
    }
}