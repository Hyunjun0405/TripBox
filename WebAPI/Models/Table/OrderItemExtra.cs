using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class OrderItemExtra
    {
        public long id { get; set; }
        public long idOrderItem { get; set; }
        public long idExtra { get; set; }
        public long price { get; set; }
        public short? quantity { get; set; }

        [ForeignKey("idExtra")]
        [InverseProperty("OrderItemExtra")]
        public virtual Extra idExtraNavigation { get; set; }
        [ForeignKey("idOrderItem")]
        [InverseProperty("OrderItemExtra")]
        public virtual OrderItem idOrderItemNavigation { get; set; }
    }
}