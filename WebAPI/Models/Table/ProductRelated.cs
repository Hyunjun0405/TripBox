using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class ProductRelated
    {
        public long idProduct1 { get; set; }
        public long idProduct2 { get; set; }

        [ForeignKey("idProduct1")]
        [InverseProperty("ProductRelatedidProduct1Navigation")]
        public virtual Product idProduct1Navigation { get; set; }
        [ForeignKey("idProduct2")]
        [InverseProperty("ProductRelatedidProduct2Navigation")]
        public virtual Product idProduct2Navigation { get; set; }
    }
}