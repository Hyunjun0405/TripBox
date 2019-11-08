using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class Payment
    {
        public Payment()
        {
            PaymentOrder = new HashSet<PaymentOrder>();
        }

        public long id { get; set; }
        [StringLength(4)]
        public string typePayment { get; set; }
        [StringLength(4)]
        public string typeReceipt { get; set; }
        [Column(TypeName = "date")]
        public DateTime? datePayment { get; set; }
        public long amount { get; set; }
        [StringLength(200)]
        public string note { get; set; }

        [InverseProperty("idPaymentNavigation")]
        public virtual ICollection<PaymentOrder> PaymentOrder { get; set; }
    }
}