using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class ProductExtra
    {
        public long idProduct { get; set; }
        public long idExtra { get; set; }

        [ForeignKey("idExtra")]
        [InverseProperty("ProductExtra")]
        public virtual Extra idExtraNavigation { get; set; }
        [ForeignKey("idProduct")]
        [InverseProperty("ProductExtra")]
        public virtual Product idProductNavigation { get; set; }
    }
}