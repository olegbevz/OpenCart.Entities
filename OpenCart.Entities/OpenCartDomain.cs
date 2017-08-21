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
    /// 'oc_ocfilter_option'
    /// 'oc_ocfilter_option_description'
    /// 'oc_ocfilter_option_to_category'
    /// 'oc_ocfilter_option_to_store'
    /// 'oc_ocfilter_option_value'
    /// 'oc_ocfilter_option_value_description'
    /// 'oc_ocfilter_option_value_to_product'
    /// 'oc_ocfilter_option_value_to_product_description'
    /// 'oc_ocfilter_page'
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

        public virtual DbSet<oc_address> oc_address { get; set; }
        public virtual DbSet<oc_affiliate> oc_affiliate { get; set; }
        public virtual DbSet<oc_affiliate_activity> oc_affiliate_activity { get; set; }
        public virtual DbSet<oc_affiliate_login> oc_affiliate_login { get; set; }
        public virtual DbSet<oc_affiliate_transaction> oc_affiliate_transaction { get; set; }
        public virtual DbSet<oc_api> oc_api { get; set; }
        public virtual DbSet<oc_api_ip> oc_api_ip { get; set; }
        public virtual DbSet<oc_api_session> oc_api_session { get; set; }
        public virtual DbSet<AttributeGroup> AttributeGroups { get; set; }
        public virtual DbSet<oc_banner> oc_banner { get; set; }
        public virtual DbSet<oc_banner_image> oc_banner_image { get; set; }
        public virtual DbSet<oc_blog> oc_blog { get; set; }
        public virtual DbSet<oc_blog_description> oc_blog_description { get; set; }
        public virtual DbSet<oc_blog_product> oc_blog_product { get; set; }
        public virtual DbSet<oc_blog_to_layout> oc_blog_to_layout { get; set; }
        public virtual DbSet<oc_blog_to_store> oc_blog_to_store { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<oc_category_filter> oc_category_filter { get; set; }
        public virtual DbSet<oc_category_path> oc_category_path { get; set; }
        public virtual DbSet<oc_category_to_layout> oc_category_to_layout { get; set; }
        public virtual DbSet<oc_category_to_store> oc_category_to_store { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<oc_coupon> oc_coupon { get; set; }
        public virtual DbSet<oc_coupon_category> oc_coupon_category { get; set; }
        public virtual DbSet<oc_coupon_history> oc_coupon_history { get; set; }
        public virtual DbSet<oc_coupon_product> oc_coupon_product { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<oc_custom_field> oc_custom_field { get; set; }
        public virtual DbSet<oc_custom_field_customer_group> oc_custom_field_customer_group { get; set; }
        public virtual DbSet<oc_custom_field_description> oc_custom_field_description { get; set; }
        public virtual DbSet<oc_custom_field_value> oc_custom_field_value { get; set; }
        public virtual DbSet<oc_custom_field_value_description> oc_custom_field_value_description { get; set; }
        public virtual DbSet<oc_customer> oc_customer { get; set; }
        public virtual DbSet<oc_customer_activity> oc_customer_activity { get; set; }
        public virtual DbSet<oc_customer_group> oc_customer_group { get; set; }
        public virtual DbSet<oc_customer_group_description> oc_customer_group_description { get; set; }
        public virtual DbSet<oc_customer_history> oc_customer_history { get; set; }
        public virtual DbSet<oc_customer_ip> oc_customer_ip { get; set; }
        public virtual DbSet<oc_customer_login> oc_customer_login { get; set; }
        public virtual DbSet<oc_customer_online> oc_customer_online { get; set; }
        public virtual DbSet<oc_customer_reward> oc_customer_reward { get; set; }
        public virtual DbSet<oc_customer_search> oc_customer_search { get; set; }
        public virtual DbSet<oc_customer_transaction> oc_customer_transaction { get; set; }
        public virtual DbSet<oc_customer_wishlist> oc_customer_wishlist { get; set; }
        public virtual DbSet<oc_download> oc_download { get; set; }
        public virtual DbSet<oc_download_description> oc_download_description { get; set; }
        public virtual DbSet<Event> oc_event { get; set; }
        public virtual DbSet<oc_extension> oc_extension { get; set; }
        public virtual DbSet<ExtraTab> ExtraTabs { get; set; }
        public virtual DbSet<oc_filter> oc_filter { get; set; }
        public virtual DbSet<oc_filter_description> oc_filter_description { get; set; }
        public virtual DbSet<oc_filter_group> oc_filter_group { get; set; }
        public virtual DbSet<oc_filter_group_description> oc_filter_group_description { get; set; }
        public virtual DbSet<oc_geo_zone> oc_geo_zone { get; set; }
        public virtual DbSet<oc_information> oc_information { get; set; }
        public virtual DbSet<oc_information_description> oc_information_description { get; set; }
        public virtual DbSet<oc_information_to_layout> oc_information_to_layout { get; set; }
        public virtual DbSet<oc_information_to_store> oc_information_to_store { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Layout> oc_layout { get; set; }
        public virtual DbSet<oc_layout_module> oc_layout_module { get; set; }
        public virtual DbSet<oc_layout_route> oc_layout_route { get; set; }
        public virtual DbSet<oc_location> oc_location { get; set; }
        public virtual DbSet<Manufacturer> Manufactorers { get; set; }
        public virtual DbSet<oc_manufacturer_to_store> oc_manufacturer_to_store { get; set; }
        public virtual DbSet<oc_marketing> oc_marketing { get; set; }
        public virtual DbSet<oc_menu> oc_menu { get; set; }
        public virtual DbSet<oc_menu_description> oc_menu_description { get; set; }
        public virtual DbSet<oc_menu_module> oc_menu_module { get; set; }
        public virtual DbSet<oc_modification> oc_modification { get; set; }
        public virtual DbSet<oc_module> oc_module { get; set; }
        public virtual DbSet<oc_ocfilter_option> oc_ocfilter_option { get; set; }
        public virtual DbSet<oc_ocfilter_option_description> oc_ocfilter_option_description { get; set; }
        public virtual DbSet<oc_ocfilter_option_to_category> oc_ocfilter_option_to_category { get; set; }
        public virtual DbSet<oc_ocfilter_option_to_store> oc_ocfilter_option_to_store { get; set; }
        public virtual DbSet<oc_ocfilter_option_value> oc_ocfilter_option_value { get; set; }
        public virtual DbSet<oc_ocfilter_option_value_description> oc_ocfilter_option_value_description { get; set; }
        public virtual DbSet<oc_ocfilter_option_value_to_product> oc_ocfilter_option_value_to_product { get; set; }
        public virtual DbSet<oc_ocfilter_option_value_to_product_description> oc_ocfilter_option_value_to_product_description { get; set; }
        public virtual DbSet<oc_ocfilter_page> oc_ocfilter_page { get; set; }
        public virtual DbSet<oc_option> oc_option { get; set; }
        public virtual DbSet<oc_option_description> oc_option_description { get; set; }
        public virtual DbSet<oc_option_value> oc_option_value { get; set; }
        public virtual DbSet<oc_option_value_description> oc_option_value_description { get; set; }
        public virtual DbSet<oc_order> oc_order { get; set; }
        public virtual DbSet<oc_order_custom_field> oc_order_custom_field { get; set; }
        public virtual DbSet<oc_order_history> oc_order_history { get; set; }
        public virtual DbSet<oc_order_option> oc_order_option { get; set; }
        public virtual DbSet<oc_order_product> oc_order_product { get; set; }
        public virtual DbSet<oc_order_recurring> oc_order_recurring { get; set; }
        public virtual DbSet<oc_order_recurring_transaction> oc_order_recurring_transaction { get; set; }
        public virtual DbSet<oc_order_status> oc_order_status { get; set; }
        public virtual DbSet<oc_order_total> oc_order_total { get; set; }
        public virtual DbSet<oc_order_voucher> oc_order_voucher { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<oc_product_discount> oc_product_discount { get; set; }
        public virtual DbSet<oc_product_filter> oc_product_filter { get; set; }
        public virtual DbSet<oc_product_option> oc_product_option { get; set; }
        public virtual DbSet<oc_product_option_value> oc_product_option_value { get; set; }
        public virtual DbSet<oc_product_recurring> oc_product_recurring { get; set; }
        public virtual DbSet<oc_product_reward> oc_product_reward { get; set; }
        public virtual DbSet<oc_product_special> oc_product_special { get; set; }
        public virtual DbSet<Sticker> Stickers { get; set; }
        public virtual DbSet<ProductCategory> oc_product_to_category { get; set; }
        public virtual DbSet<oc_product_to_download> oc_product_to_download { get; set; }
        public virtual DbSet<oc_recurring> oc_recurring { get; set; }
        public virtual DbSet<oc_recurring_description> oc_recurring_description { get; set; }
        public virtual DbSet<oc_return> oc_return { get; set; }
        public virtual DbSet<oc_return_action> oc_return_action { get; set; }
        public virtual DbSet<oc_return_history> oc_return_history { get; set; }
        public virtual DbSet<oc_return_reason> oc_return_reason { get; set; }
        public virtual DbSet<oc_return_status> oc_return_status { get; set; }
        public virtual DbSet<oc_review> oc_review { get; set; }
        public virtual DbSet<oc_setting> oc_setting { get; set; }
        public virtual DbSet<StockStatus> StockStatuses { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<oc_tax_class> oc_tax_class { get; set; }
        public virtual DbSet<oc_tax_rate> oc_tax_rate { get; set; }
        public virtual DbSet<oc_tax_rate_to_customer_group> oc_tax_rate_to_customer_group { get; set; }
        public virtual DbSet<oc_tax_rule> oc_tax_rule { get; set; }
        public virtual DbSet<oc_theme> oc_theme { get; set; }
        public virtual DbSet<oc_translation> oc_translation { get; set; }
        public virtual DbSet<oc_upload> oc_upload { get; set; }
        public virtual DbSet<UrlAlias> UrlAliases { get; set; }
        public virtual DbSet<oc_voucher> oc_voucher { get; set; }
        public virtual DbSet<oc_voucher_history> oc_voucher_history { get; set; }
        public virtual DbSet<oc_voucher_theme> oc_voucher_theme { get; set; }
        public virtual DbSet<oc_voucher_theme_description> oc_voucher_theme_description { get; set; }
        public virtual DbSet<oc_zone> oc_zone { get; set; }
        public virtual DbSet<oc_zone_to_geo_zone> oc_zone_to_geo_zone { get; set; }
        public virtual DbSet<oc_product_image_by_option> oc_product_image_by_option { get; set; }
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
