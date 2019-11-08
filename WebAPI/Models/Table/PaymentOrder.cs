using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class PaymentOrder
    {
        public long id { get; set; }
        public long idPayment { get; set; }
        public long idOrder { get; set; }
        public long amount { get; set; }

        [ForeignKey("idOrder")]
        [InverseProperty("PaymentOrder")]
        public virtual Order idOrderNavigation { get; set; }
        [ForeignKey("idPayment")]
        [InverseProperty("PaymentOrder")]
        public virtual Payment idPaymentNavigation { get; set; }
    }
}