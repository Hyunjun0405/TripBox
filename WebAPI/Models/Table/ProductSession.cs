using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class ProductSession
    {
        public ProductSession()
        {
            //OrderItem = new HashSet<OrderItem>();
            //ProductPrice = new HashSet<ProductPrice>();
        }

        public long id { get; set; }
        public long idTemplate { get; set; }
        public long idProduct { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? datetimeStart { get; set; }
        public bool? isAllday { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? datetimeEnd { get; set; }
        public short? seatMax { get; set; }
        public short? seatOrdered { get; set; }

        //[ForeignKey("idProduct")]
        //[InverseProperty("ProductSession")]
        //public virtual Product idProductNavigation { get; set; }
        //[ForeignKey("idTemplate")]
        ////[InverseProperty("ProductSession")]
        ////public virtual SessionTemplate idTemplateNavigation { get; set; }
        ////[InverseProperty("idSesstionNavigation")]
        ////public virtual ICollection<OrderItem> OrderItem { get; set; }
        //[InverseProperty("idSessionNavigation")]
        //public virtual ICollection<ProductPrice> Price { get; set; }
    }
}