using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class PriceOption
    {
        public PriceOption()
        {
            Price = new HashSet<Price>();
        }

        public long idProduct { get; set; }
        [StringLength(4)]
        public string typePriceOption { get; set; }
        public long price { get; set; }
        public long cost { get; set; }
        public short? quantityUse { get; set; }
        [StringLength(1000)]
        public string note { get; set; }

        [ForeignKey("idProduct")]
        [InverseProperty("PriceOption")]
        public virtual Product idProductNavigation { get; set; }
        [InverseProperty("PriceOption")]
        public virtual ICollection<Price> Price { get; set; }
    }
}