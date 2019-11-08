using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class ProductImage
    {
        public long id { get; set; }
        public long idProduct { get; set; }
        public long idImage { get; set; }

        [ForeignKey("idImage")]
        [InverseProperty("ProductImage")]
        public virtual Image idImageNavigation { get; set; }
        [ForeignKey("idProduct")]
        [InverseProperty("ProductImage")]
        public virtual Product idProductNavigation { get; set; }
    }
}