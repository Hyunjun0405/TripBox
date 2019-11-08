using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class CampaignProduct
    {
        public long id { get; set; }
        public long idPromotion { get; set; }
        public long idCategory { get; set; }
        public long idProduct { get; set; }
        [StringLength(4)]
        public string typePriceOption { get; set; }
        public string listSession { get; set; }

        [ForeignKey("idCategory")]
        [InverseProperty("CampaignProduct")]
        public virtual Category idCategoryNavigation { get; set; }
        [ForeignKey("idProduct")]
        [InverseProperty("CampaignProduct")]
        public virtual Product idProductNavigation { get; set; }
        [ForeignKey("idPromotion")]
        [InverseProperty("CampaignProduct")]
        public virtual Campaign idPromotionNavigation { get; set; }
    }
}