using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class Category
    {
        public Category()
        {
            CampaignProduct = new HashSet<CampaignProduct>();
            CategorySeoTag = new HashSet<CategorySeoTag>();
            ProductCategory = new HashSet<ProductCategory>();
        }

        public long id { get; set; }
        public long? idSupplier { get; set; }
        [StringLength(100)]
        public string name { get; set; }
        [StringLength(1000)]
        public string description { get; set; }
        public bool? isVisible { get; set; }

        [InverseProperty("idCategoryNavigation")]
        public virtual ICollection<CampaignProduct> CampaignProduct { get; set; }
        [InverseProperty("idCategoryNavigation")]
        public virtual ICollection<CategorySeoTag> CategorySeoTag { get; set; }
        [InverseProperty("idCategoryNavigation")]
        public virtual ICollection<ProductCategory> ProductCategory { get; set; }
    }
}