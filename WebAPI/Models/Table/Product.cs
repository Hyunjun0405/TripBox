using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class Product
    {
        public Product()
        {
            //BookingField = new HashSet<BookingField>();
            //CampaignProduct = new HashSet<CampaignProduct>();
            //Itinerary = new HashSet<Itinerary>();
            //OrderItem = new HashSet<OrderItem>();
            //PriceOption = new HashSet<PriceOption>();
            //ProductCategory = new HashSet<ProductCategory>();
            //ProductExtra = new HashSet<ProductExtra>();
            //ProductField = new HashSet<ProductField>();
            //ProductImage = new HashSet<ProductImage>();
            //ProductRelatedidProduct1Navigation = new HashSet<ProductRelated>();
            //ProductRelatedidProduct2Navigation = new HashSet<ProductRelated>();
            //ProductTag = new HashSet<ProductTag>();
            //ProductVideo = new HashSet<ProductVideo>();
            //Session = new HashSet<Session>();
            //SessionTemplate = new HashSet<SessionTemplate>();
        }

        public long id { get; set; }
        public long? idSupplier { get; set; }
        [StringLength(4)]
        public string typeProduct { get; set; }
        [StringLength(4)]
        public string typePart { get; set; }
        [StringLength(100)]
        public string name { get; set; }
        [StringLength(20)]
        public string code { get; set; }
        public long priceAdvertise { get; set; }
        public short? quantityMin { get; set; }
        public short? quantityMax { get; set; }
        [StringLength(10)]
        public string quantityLabel { get; set; }
        [StringLength(10)]
        public string quantityLabelPlural { get; set; }
        [StringLength(1000)]
        public string descriptionShort { get; set; }
        [StringLength(4000)]
        public string descriptionLong { get; set; }
        public bool? isPaymentSpecial { get; set; }
        [StringLength(4)]
        public string typeDepoist { get; set; }
        [Column(TypeName = "numeric(12, 2)")]
        public decimal valueDeposit { get; set; }
        public bool? isPaymentFull { get; set; }
        public bool? isPaymentNotice { get; set; }
        public short? dayPaymentNotice { get; set; }
        public bool? isSpecialRule { get; set; }
        [StringLength(4000)]
        public string valueSpecialRule { get; set; }
        [StringLength(4)]
        public string typeSession { get; set; }
        [StringLength(1000)]
        public string timeList { get; set; }
        [StringLength(4)]
        public string typeAvail { get; set; }
        public bool? isAllowWaiting { get; set; }
        public bool? isShowSeat { get; set; }
        [StringLength(4)]
        public string typeConfirm { get; set; }
        public short? quantityAfter { get; set; }
        public short? timeMiniumNotice { get; set; }
        [StringLength(4)]
        public string timeTypeMiniumNotice { get; set; }
        public short? timeDuration { get; set; }
        [StringLength(4)]
        public string timeTypeDuration { get; set; }
        [StringLength(10)]
        public string productColor { get; set; }
        public long? idSpot { get; set; }
        public long? idPickup { get; set; }

        //[ForeignKey("idPickup")]
        //[InverseProperty("Product")]
        //public virtual Pickup idPickupNavigation { get; set; }
        //[InverseProperty("idProductNavigation")]
        //public virtual ICollection<BookingField> BookingField { get; set; }
        //[InverseProperty("idProductNavigation")]
        //public virtual ICollection<CampaignProduct> CampaignProduct { get; set; }
        //[InverseProperty("idProductNavigation")]
        //public virtual ICollection<Itinerary> Itinerary { get; set; }
        //[InverseProperty("idProductNavigation")]
        //public virtual ICollection<OrderItem> OrderItem { get; set; }
        //[InverseProperty("idProductNavigation")]
        //public virtual ICollection<PriceOption> PriceOption { get; set; }
        //[InverseProperty("idProductNavigation")]
        //public virtual ICollection<ProductCategory> ProductCategory { get; set; }
        //[InverseProperty("idProductNavigation")]
        //public virtual ICollection<ProductExtra> ProductExtra { get; set; }
        //[InverseProperty("idProductNavigation")]
        //public virtual ICollection<ProductField> ProductField { get; set; }
        //[InverseProperty("idProductNavigation")]
        //public virtual ICollection<ProductImage> ProductImage { get; set; }
        //[InverseProperty("idProduct1Navigation")]
        //public virtual ICollection<ProductRelated> ProductRelatedidProduct1Navigation { get; set; }
        //[InverseProperty("idProduct2Navigation")]
        //public virtual ICollection<ProductRelated> ProductRelatedidProduct2Navigation { get; set; }
        //[InverseProperty("idProductNavigation")]
        //public virtual ICollection<ProductTag> ProductTag { get; set; }
        //[InverseProperty("idProductNavigation")]
        //public virtual ICollection<ProductVideo> ProductVideo { get; set; }
        //[InverseProperty("idProductNavigation")]
        //public virtual ICollection<Session> Session { get; set; }
        //[InverseProperty("idProductNavigation")]
        //public virtual ICollection<SessionTemplate> SessionTemplate { get; set; }
    }
}