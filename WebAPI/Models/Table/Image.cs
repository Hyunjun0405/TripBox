using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class Image
    {
        public Image()
        {
            Extra = new HashSet<Extra>();
            ProductImage = new HashSet<ProductImage>();
        }

        public long id { get; set; }
        [StringLength(200)]
        public string urlImageFull { get; set; }
        [StringLength(200)]
        public string urlImageLarge { get; set; }
        [StringLength(200)]
        public string urlImageMedium { get; set; }
        [StringLength(200)]
        public string urlImageSmall { get; set; }

        [InverseProperty("idImageNavigation")]
        public virtual ICollection<Extra> Extra { get; set; }
        [InverseProperty("idImageNavigation")]
        public virtual ICollection<ProductImage> ProductImage { get; set; }
    }
}