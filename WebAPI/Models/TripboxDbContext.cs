using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAPI.Models
{
    public partial class TripboxDbContext : DbContext
    {
        public TripboxDbContext()
        {
        }

        public TripboxDbContext(DbContextOptions<TripboxDbContext> options)
            : base(options)
        {
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=4GXVLD2;Initial Catalog=TripBox;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");            

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        //public virtual DbSet<Agent> Agent { get; set; }
        //public virtual DbSet<BookingField> _BookingField { get; set; }
        public virtual DbSet<Category> _Category { get; set; }
        //public virtual DbSet<City> _City { get; set; }
        //public virtual DbSet<Extra> _Extra { get; set; }
        //public virtual DbSet<Field> _Field { get; set; }
        //public virtual DbSet<MasterCode> MasterCode { get; set; }
        //public virtual DbSet<Member> Member { get; set; }
        //public virtual DbSet<Message> Message { get; set; }
        //public virtual DbSet<MessageTemplate> MessageTemplate { get; set; }
        //public virtual DbSet<NegotiatedRate> NegotiatedRate { get; set; }
        //public virtual DbSet<Order> Order { get; set; }
        //public virtual DbSet<OrderField> OrderField { get; set; }
        //public virtual DbSet<OrderItem> OrderItem { get; set; }
        //public virtual DbSet<OrderItemExtra> OrderItemExtra { get; set; }
        //public virtual DbSet<OrderItemField> OrderItemField { get; set; }
        //public virtual DbSet<OrderItemProduct> OrderItemProduct { get; set; }
        //public virtual DbSet<OrderItemResource> OrderItemResource { get; set; }
        //public virtual DbSet<OrderItemSession> OrderItemSession { get; set; }
        //public virtual DbSet<Package> Package { get; set; }
        //public virtual DbSet<PackageSession> PackageSession { get; set; }
        //public virtual DbSet<Party> Party { get; set; }
        //public virtual DbSet<PartyAccount> PartyAccount { get; set; }
        //public virtual DbSet<PartyContact> PartyContact { get; set; }
        //public virtual DbSet<PartyRelation> PartyRelation { get; set; }
        //public virtual DbSet<Payment> Payment { get; set; }
        //public virtual DbSet<PaymentOrder> PaymentOrder { get; set; }
        //public virtual DbSet<Pickup> Pickup { get; set; }
        //public virtual DbSet<PickupSpot> PickupSpot { get; set; }
        //public virtual DbSet<PriceOption> PriceOption { get; set; }
        //public virtual DbSet<Product> Product { get; set; }
        //public virtual DbSet<ProductCategory> ProductCategory { get; set; }
        //public virtual DbSet<ProductExtra> ProductExtra { get; set; }
        //public virtual DbSet<ProductField> ProductField { get; set; }
        //public virtual DbSet<ProductImage> ProductImage { get; set; }
        //public virtual DbSet<ProductNego> ProductNego { get; set; }
        //public virtual DbSet<ProductPrice> ProductPrice { get; set; }
        //public virtual DbSet<ProductRelated> ProductRelated { get; set; }
        //public virtual DbSet<ProductSession> ProductSession { get; set; }
        //public virtual DbSet<ProductSpot> ProductSpot { get; set; }
        //public virtual DbSet<ProductSurcharge> ProductSurcharge { get; set; }
        //public virtual DbSet<ProductTag> ProductTag { get; set; }
        //public virtual DbSet<ProductVideo> ProductVideo { get; set; }
        //public virtual DbSet<Promotion> Promotion { get; set; }
        //public virtual DbSet<Purchage> Purchage { get; set; }
        //public virtual DbSet<PurchageDetail> PurchageDetail { get; set; }
        //public virtual DbSet<Resource> Resource { get; set; }
        //public virtual DbSet<SessionOrdered> SessionOrdered { get; set; }
        //public virtual DbSet<SessionResource> SessionResource { get; set; }
        //public virtual DbSet<SessionRole> SessionRole { get; set; }
        //public virtual DbSet<SessionTemplate> SessionTemplate { get; set; }
        //public virtual DbSet<SessionTemplateWeek> SessionTemplateWeek { get; set; }
        //public virtual DbSet<Spot> Spot { get; set; }
        //public virtual DbSet<Supplier> Supplier { get; set; }
        //public virtual DbSet<SupplierCity> SupplierCity { get; set; }
        //public virtual DbSet<SupplierPayment> SupplierPayment { get; set; }
        //public virtual DbSet<Surcharge> Surcharge { get; set; }
        //public virtual DbSet<User> User { get; set; }
    }
}