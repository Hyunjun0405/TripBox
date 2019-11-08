using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class ProductVideo
    {
        public long id { get; set; }
        public long idProduct { get; set; }
        public long idVideo { get; set; }

        [ForeignKey("idProduct")]
        [InverseProperty("ProductVideo")]
        public virtual Product idProductNavigation { get; set; }
        [ForeignKey("idVideo")]
        [InverseProperty("ProductVideo")]
        public virtual Video idVideoNavigation { get; set; }
    }
}