using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class OrderItem
    {
        public OrderItem()
        {
            InvoiceItem = new HashSet<InvoiceItem>();
            OrderItemExtra = new HashSet<OrderItemExtra>();
            OrderItemField = new HashSet<OrderItemField>();
            OrderItemProduct = new HashSet<OrderItemProduct>();
        }

        public long id { get; set; }
        public long idOrder { get; set; }
        public long idProduct { get; set; }
        public long idSesstion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? datetimeStart { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? datetimeEnd { get; set; }
        public long amount { get; set; }
        public long subTotal { get; set; }
        public long totalProduct { get; set; }
        public long totalExtra { get; set; }
        public short? totalQuantityUse { get; set; }
        public long idPickupSpot { get; set; }
        public TimeSpan? timePickup { get; set; }
        public bool? isRoundTrip { get; set; }
        public long? idTransferFrom { get; set; }
        public long? idTransferTo { get; set; }
        public bool? isCheckin { get; set; }
        public bool? isConfirm { get; set; }

        [ForeignKey("idOrder")]
        [InverseProperty("OrderItem")]
        public virtual Order idOrderNavigation { get; set; }
        [ForeignKey("idPickupSpot")]
        [InverseProperty("OrderItem")]
        public virtual PickupSpot idPickupSpotNavigation { get; set; }
        [ForeignKey("idProduct")]
        [InverseProperty("OrderItem")]
        public virtual Product idProductNavigation { get; set; }
        [ForeignKey("idSesstion")]
        [InverseProperty("OrderItem")]
        public virtual Session idSesstionNavigation { get; set; }
        [InverseProperty("idOrderItemNavigation")]
        public virtual ICollection<InvoiceItem> InvoiceItem { get; set; }
        [InverseProperty("idOrderItemNavigation")]
        public virtual ICollection<OrderItemExtra> OrderItemExtra { get; set; }
        [InverseProperty("idOrderItemNavigation")]
        public virtual ICollection<OrderItemField> OrderItemField { get; set; }
        [InverseProperty("idOrderItemNavigation")]
        public virtual ICollection<OrderItemProduct> OrderItemProduct { get; set; }
    }
}