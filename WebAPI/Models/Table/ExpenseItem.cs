using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class ExpenseItem
    {
        public long id { get; set; }
        public long idExpense { get; set; }
        public long idSession { get; set; }
        [StringLength(4)]
        public string typeExpense { get; set; }
        public long cost { get; set; }
        public short? quantity { get; set; }

        [ForeignKey("idExpense")]
        [InverseProperty("ExpenseItem")]
        public virtual Expense idExpenseNavigation { get; set; }
        [ForeignKey("idSession")]
        [InverseProperty("ExpenseItem")]
        public virtual SessionOrdered idSessionNavigation { get; set; }
    }
}