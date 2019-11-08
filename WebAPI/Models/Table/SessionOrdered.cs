using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class SessionOrdered
    {
        public SessionOrdered()
        {
            ExpenseItem = new HashSet<ExpenseItem>();
            InvoiceItem = new HashSet<InvoiceItem>();
            SessionRole = new HashSet<SessionRole>();
        }

        [Key]
        public long idSession { get; set; }
        public long? idProduct { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? datetimeStart { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? datetimeEnd { get; set; }
        public long totalProfit { get; set; }
        public long totalInvoice { get; set; }
        public long totalExpense { get; set; }
        public short? totalQuantityUse { get; set; }

        [InverseProperty("idSessionNavigation")]
        public virtual ICollection<ExpenseItem> ExpenseItem { get; set; }
        [InverseProperty("idSessionNavigation")]
        public virtual ICollection<InvoiceItem> InvoiceItem { get; set; }
        [InverseProperty("idSessionNavigation")]
        public virtual ICollection<SessionRole> SessionRole { get; set; }
    }
}