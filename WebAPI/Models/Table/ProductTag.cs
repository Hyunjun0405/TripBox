using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class ProductTag
    {
        public long idProduct { get; set; }
        [StringLength(4)]
        public string typeTag { get; set; }
        [StringLength(4)]
        public string tag { get; set; }

        [ForeignKey("idProduct")]
        [InverseProperty("ProductTag")]
        public virtual Product idProductNavigation { get; set; }
    }
}