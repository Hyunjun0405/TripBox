using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class Expense
    {
        public Expense()
        {
            ExpenseItem = new HashSet<ExpenseItem>();
        }

        public long id { get; set; }
        public long? idSupplier { get; set; }
        [Column(TypeName = "date")]
        public DateTime? dateExpense { get; set; }
        public long? idPartyTo { get; set; }
        public long totalExpense { get; set; }
        [StringLength(1000)]
        public string note { get; set; }

        [InverseProperty("idExpenseNavigation")]
        public virtual ICollection<ExpenseItem> ExpenseItem { get; set; }
    }
}