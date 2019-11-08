using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class OrderField
    {
        public long id { get; set; }
        public long? idOrder { get; set; }
        public long idField { get; set; }
        [StringLength(1000)]
        public string value { get; set; }

        [ForeignKey("idField")]
        [InverseProperty("OrderField")]
        public virtual Field idFieldNavigation { get; set; }
        [ForeignKey("idOrder")]
        [InverseProperty("OrderField")]
        public virtual Order idOrderNavigation { get; set; }
    }
}