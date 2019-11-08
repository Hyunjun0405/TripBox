using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class InvoiceItem
    {
        public long id { get; set; }
        public long idInvoice { get; set; }
        public long idOrderItem { get; set; }
        public long idSession { get; set; }
        public long cost { get; set; }
        public short? quantity { get; set; }

        [ForeignKey("idInvoice")]
        [InverseProperty("InvoiceItem")]
        public virtual Invoice idInvoiceNavigation { get; set; }
        [ForeignKey("idOrderItem")]
        [InverseProperty("InvoiceItem")]
        public virtual OrderItem idOrderItemNavigation { get; set; }
        [ForeignKey("idSession")]
        [InverseProperty("InvoiceItem")]
        public virtual SessionOrdered idSessionNavigation { get; set; }
    }
}