using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class Session
    {
        public Session()
        {
            OrderItem = new HashSet<OrderItem>();
            Price = new HashSet<Price>();
        }

        public long id { get; set; }
        public long idTemplate { get; set; }
        public long idProduct { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? datetimeStart { get; set; }
        public bool? isAllday { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? datetimeEnd { get; set; }
        public short? seatMax { get; set; }
        public short? seatOrdered { get; set; }

        [ForeignKey("idProduct")]
        [InverseProperty("Session")]
        public virtual Product idProductNavigation { get; set; }
        [ForeignKey("idTemplate")]
        [InverseProperty("Session")]
        public virtual SessionTemplate idTemplateNavigation { get; set; }
        [InverseProperty("idSesstionNavigation")]
        public virtual ICollection<OrderItem> OrderItem { get; set; }
        [InverseProperty("idSessionNavigation")]
        public virtual ICollection<Price> Price { get; set; }
    }
}