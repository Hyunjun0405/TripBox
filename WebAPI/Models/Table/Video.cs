using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class Video
    {
        public Video()
        {
            ProductVideo = new HashSet<ProductVideo>();
        }

        public long id { get; set; }
        [StringLength(4)]
        public string typePlatform { get; set; }
        [StringLength(200)]
        public string urlVideo { get; set; }

        [InverseProperty("idVideoNavigation")]
        public virtual ICollection<ProductVideo> ProductVideo { get; set; }
    }
}