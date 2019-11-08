using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderField = new HashSet<OrderField>();
            OrderItem = new HashSet<OrderItem>();
            OrderRole = new HashSet<OrderRole>();
            PaymentOrder = new HashSet<PaymentOrder>();
        }

        public long id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? datetimeCreated { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? datetimeConfirmed { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? datetimePaid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? datetimeUpdated { get; set; }
        public long idCampaign { get; set; }
        public long totalAmount { get; set; }
        public long amountDue { get; set; }
        public long amountPaid { get; set; }
        public long surcharge { get; set; }
        [StringLength(4)]
        public string currency { get; set; }
        public bool? isSendNofication { get; set; }
        public string listTypePayment { get; set; }
        [StringLength(4)]
        public string typeSource { get; set; }
        [StringLength(4)]
        public string channelSource { get; set; }
        [StringLength(4)]
        public string refererSource { get; set; }
        [StringLength(2000)]
        public string commentCustomer { get; set; }
        [StringLength(2000)]
        public string commentReseller { get; set; }
        [StringLength(2000)]
        public string commentSupplier { get; set; }

        [ForeignKey("idCampaign")]
        [InverseProperty("Order")]
        public virtual Campaign idCampaignNavigation { get; set; }
        [InverseProperty("idOrderNavigation")]
        public virtual ICollection<OrderField> OrderField { get; set; }
        [InverseProperty("idOrderNavigation")]
        public virtual ICollection<OrderItem> OrderItem { get; set; }
        [InverseProperty("idOrderNavigation")]
        public virtual ICollection<OrderRole> OrderRole { get; set; }
        [InverseProperty("idOrderNavigation")]
        public virtual ICollection<PaymentOrder> PaymentOrder { get; set; }
    }
}