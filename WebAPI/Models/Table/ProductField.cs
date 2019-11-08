using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class ProductField
    {
        public long idProduct { get; set; }
        public long idField { get; set; }
        [StringLength(4000)]
        public string value { get; set; }

        [ForeignKey("idField")]
        [InverseProperty("ProductField")]
        public virtual Field idFieldNavigation { get; set; }
        [ForeignKey("idProduct")]
        [InverseProperty("ProductField")]
        public virtual Product idProductNavigation { get; set; }
    }
}