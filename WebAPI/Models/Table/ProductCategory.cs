using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class ProductCategory
    {
        public long idCategory { get; set; }
        public long idProduct { get; set; }

        [ForeignKey("idCategory")]
        [InverseProperty("ProductCategory")]
        public virtual Category idCategoryNavigation { get; set; }
        [ForeignKey("idProduct")]
        [InverseProperty("ProductCategory")]
        public virtual Product idProductNavigation { get; set; }
    }
}