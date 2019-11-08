using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class Campaign
    {
        public Campaign()
        {
            CampaignProduct = new HashSet<CampaignProduct>();
            Order = new HashSet<Order>();
        }

        public long id { get; set; }
        [Column(TypeName = "date")]
        public DateTime? dateOrderStart { get; set; }
        [Column(TypeName = "date")]
        public DateTime? dateOrderEnd { get; set; }
        [Column(TypeName = "date")]
        public DateTime? dateSessionStart { get; set; }
        [Column(TypeName = "date")]
        public DateTime? dateSessionEnd { get; set; }
        [StringLength(4)]
        public string typeCampaign { get; set; }
        [Column(TypeName = "numeric(12, 2)")]
        public decimal rate { get; set; }

        [InverseProperty("idPromotionNavigation")]
        public virtual ICollection<CampaignProduct> CampaignProduct { get; set; }
        [InverseProperty("idCampaignNavigation")]
        public virtual ICollection<Order> Order { get; set; }
    }
}