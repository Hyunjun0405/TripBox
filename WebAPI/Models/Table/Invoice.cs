using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class Invoice
    {
        public Invoice()
        {
            InvoiceItem = new HashSet<InvoiceItem>();
        }

        public long id { get; set; }
        public long? idSupplier { get; set; }
        [Column(TypeName = "date")]
        public DateTime? dateFrom { get; set; }
        [Column(TypeName = "date")]
        public DateTime? dateTo { get; set; }
        public long totalInvoice { get; set; }

        [InverseProperty("idInvoiceNavigation")]
        public virtual ICollection<InvoiceItem> InvoiceItem { get; set; }
    }
}