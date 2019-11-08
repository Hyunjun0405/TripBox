using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class CategorySeoTag
    {
        public long idCategory { get; set; }
        public long idSeoTag { get; set; }

        [ForeignKey("idCategory")]
        [InverseProperty("CategorySeoTag")]
        public virtual Category idCategoryNavigation { get; set; }
        [ForeignKey("idSeoTag")]
        [InverseProperty("CategorySeoTag")]
        public virtual SeoTag idSeoTagNavigation { get; set; }
    }
}