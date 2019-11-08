using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class Field
    {
        public Field()
        {
            BookingField = new HashSet<BookingField>();
            OrderField = new HashSet<OrderField>();
            OrderItemField = new HashSet<OrderItemField>();
            ProductField = new HashSet<ProductField>();
        }

        public long id { get; set; }
        [Required]
        [StringLength(4)]
        public string fieldType { get; set; }
        public long? idSupplier { get; set; }
        [Required]
        [StringLength(1)]
        public string name { get; set; }
        [StringLength(4)]
        public string dataType { get; set; }
        [StringLength(2000)]
        public string listValues { get; set; }

        [InverseProperty("idFieldNavigation")]
        public virtual ICollection<BookingField> BookingField { get; set; }
        [InverseProperty("idFieldNavigation")]
        public virtual ICollection<OrderField> OrderField { get; set; }
        [InverseProperty("idFieldNavigation")]
        public virtual ICollection<OrderItemField> OrderItemField { get; set; }
        [InverseProperty("idFieldNavigation")]
        public virtual ICollection<ProductField> ProductField { get; set; }
    }
}