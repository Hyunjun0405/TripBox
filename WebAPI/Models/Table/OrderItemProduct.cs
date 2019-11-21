using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class OrderItemProduct
    {
        public long id { get; set; }
        public long idOrderItem { get; set; }
        public long idPrice { get; set; }
        public long price { get; set; }
        public long cost { get; set; }
        public short? quantity { get; set; }
        public short? quantityUse { get; set; }

        [ForeignKey("idOrderItem")]
        [InverseProperty("OrderItemProduct")]
        public virtual OrderItem idOrderItemNavigation { get; set; }
        [ForeignKey("idPrice")]
        [InverseProperty("OrderItemProduct")]
        public virtual ProductPrice idPriceNavigation { get; set; }
    }
}