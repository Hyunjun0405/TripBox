using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class Extra
    {
        public Extra()
        {
            OrderItemExtra = new HashSet<OrderItemExtra>();
            ProductExtra = new HashSet<ProductExtra>();
        }

        public long id { get; set; }
        public long? idSupplier { get; set; }
        [StringLength(100)]
        public string name { get; set; }
        public long idImage { get; set; }
        [StringLength(1000)]
        public string description { get; set; }
        [StringLength(4)]
        public string typePriceExtra { get; set; }
        public long price { get; set; }
        public bool? isLimit { get; set; }
        public short? limitMax { get; set; }

        [ForeignKey("idImage")]
        [InverseProperty("Extra")]
        public virtual Image idImageNavigation { get; set; }
        [InverseProperty("idExtraNavigation")]
        public virtual ICollection<OrderItemExtra> OrderItemExtra { get; set; }
        [InverseProperty("idExtraNavigation")]
        public virtual ICollection<ProductExtra> ProductExtra { get; set; }
    }
}