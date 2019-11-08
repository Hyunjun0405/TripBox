using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class OrderItemField
    {
        public long id { get; set; }
        public long idOrderItem { get; set; }
        public long idField { get; set; }
        [StringLength(1000)]
        public string value { get; set; }

        [ForeignKey("idField")]
        [InverseProperty("OrderItemField")]
        public virtual Field idFieldNavigation { get; set; }
        [ForeignKey("idOrderItem")]
        [InverseProperty("OrderItemField")]
        public virtual OrderItem idOrderItemNavigation { get; set; }
    }
}