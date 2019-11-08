using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class SeoTag
    {
        public SeoTag()
        {
            CategorySeoTag = new HashSet<CategorySeoTag>();
        }

        public long id { get; set; }
        [StringLength(4)]
        public string metaType { get; set; }
        [StringLength(100)]
        public string valueAttribute { get; set; }
        [StringLength(100)]
        public string keyAttribute { get; set; }

        [InverseProperty("idSeoTagNavigation")]
        public virtual ICollection<CategorySeoTag> CategorySeoTag { get; set; }
    }
}