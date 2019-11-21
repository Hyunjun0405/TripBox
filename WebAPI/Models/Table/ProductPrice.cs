using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class ProductPrice
    {
        public ProductPrice()
        {
            //OrderItemProduct = new HashSet<OrderItemProduct>();
        }

        public long id { get; set; }
        public long idProduct { get; set; }
        [Required]
        [StringLength(4)]
        public string typePriceOption { get; set; }
        public long? idSession { get; set; }
        [Column("price")]
        public long price1 { get; set; }
        public long cost { get; set; }
        public short? seatMax { get; set; }

        [ForeignKey("idProduct,typePriceOption")]
        [InverseProperty("PriceOption")]
        public virtual PriceOption PriceOption { get; set; }
        //[ForeignKey("idSession")]
        //[InverseProperty("ProductPrice")]
        //public virtual Session idSessionNavigation { get; set; }
        //[InverseProperty("idPriceNavigation")]
        //public virtual ICollection<OrderItemProduct> OrderItemProduct { get; set; }
    }
}