namespace OpenCart.Entities
{
    using System.Data.Entity;

    /// <summary>
    /// Tables that are not used in original opencart 2.3.0.2:
    /// 'oc_blog'
    /// 'oc_blog_description'
    /// 'oc_blog_product'
    /// 'oc_blog_to_layout'
    /// 'oc_blog_to_store'
    /// 'oc_extra_tabs'
    /// 'oc_extra_tabs_description'
    /// 'oc_product_extra_tabs'
    /// 'oc_oct_product_reviews'
    /// 'oc_oct_product_reviews_reputation'
    /// 'oc_oct_sreview_reviews'
    /// 'oc_oct_sreview_reviews_vote'
    /// 'oc_oct_sreview_subject'
    /// 'oc_oct_sreview_subject_description'
    /// 'oc_oct_sreview_subject_to_store'
    /// 'oc_product_image_by_option'
    /// 'oc_product_stickers'
    /// 'oc_product_stickers_description'
    /// </summary>
    public class OpenCartDomain : DbContext, IOpenCartDomain
    {
        public OpenCartDomain()
            : base("name=OpenCartDomain")
        {
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
            this.Configuration.ValidateOnSaveEnabled = true;

            Database.SetInitializer<OpenCartDomain>(null);
        }

        public virtual DbSet<Affiliate> Affiliates { get; set; }
        public virtual DbSet<Api> Apis { get; set; }
        public virtual DbSet<AttributeGroup> AttributeGroups { get; set; }
        public virtual DbSet<Banner> Banners { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Coupon> Coupons { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<CustomField> CustomFields { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerGroup> CustomerGroups { get; set; }
        public virtual DbSet<Download> Downloads { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Extension> Extensions { get; set; }
        public virtual DbSet<ExtraTab> ExtraTabs { get; set; }
        public virtual DbSet<Filter> Filters { get; set; }
        public virtual DbSet<FilterGroup> FilterGroups { get; set; }
        public virtual DbSet<GeoZone> GeoZones { get; set; }
        public virtual DbSet<Information> Information { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Layout> Layouts { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Manufacturer> Manufactorers { get; set; }
        public virtual DbSet<Marketing> Marketing { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Modification> Modifications { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<Option> Options { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderStatus> OrderStatuses { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Sticker> Stickers { get; set; }
        public virtual DbSet<Recurring> Recurrings { get; set; }
        public virtual DbSet<Return> Returns { get; set; }
        public virtual DbSet<ReturnAction> ReturnActions { get; set; }
        public virtual DbSet<ReturnReason> ReturnReasons { get; set; }
        public virtual DbSet<ReturnStatus> ReturnStatuses { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Setting> Setting { get; set; }
        public virtual DbSet<StockStatus> StockStatuses { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<TaxClass> TaxClasses { get; set; }
        public virtual DbSet<TaxRate> TaxRates { get; set; }
        public virtual DbSet<TaxRule> TaxRule { get; set; }
        public virtual DbSet<Theme> Themes { get; set; }
        public virtual DbSet<Translation> Translations { get; set; }
        public virtual DbSet<Upload> Uploads { get; set; }
        public virtual DbSet<UrlAlias> UrlAliases { get; set; }
        public virtual DbSet<Voucher> Vouchers { get; set; }
        public virtual DbSet<VoucherTheme> VoucherThemes { get; set; }
        public virtual DbSet<Zone> Zones { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
        public virtual DbSet<WeightUnit> WeightUnits { get; set; }
        public virtual DbSet<LengthUnit> LengthUnits { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(GetType().Assembly);
        }
    }
}
