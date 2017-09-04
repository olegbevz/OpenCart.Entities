using System;
using System.Data.Entity;

namespace OpenCart.Entities
{
    public interface IOpenCartDomain : IDisposable
    {
        DbSet<Affiliate> Affiliates { get; set; }
        DbSet<Api> Apis { get; set; }
        DbSet<Attribute> Attributes { get; set; }
        DbSet<AttributeGroup> AttributeGroups { get; set; }
        DbSet<Banner> Banners { get; set; }
        DbSet<Blog> Blogs { get; set; }
        DbSet<Cart> Cart { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Country> Countries { get; set; }
        DbSet<Coupon> Coupons { get; set; }
        DbSet<Currency> Currencies { get; set; }
        DbSet<CustomField> CustomFields { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<CustomerGroup> CustomerGroups { get; set; }
        DbSet<Download> Downloads { get; set; }
        DbSet<Event> Events { get; set; }
        DbSet<Extension> Extensions { get; set; }
        DbSet<ExtraTab> ExtraTabs { get; set; }
        DbSet<Filter> Filters { get; set; }
        DbSet<FilterGroup> FilterGroups { get; set; }
        DbSet<GeoZone> GeoZones { get; set; }
        DbSet<Information> Information { get; set; }
        DbSet<Language> Languages { get; set; }
        DbSet<Layout> Layouts { get; set; }
        DbSet<Location> Locations { get; set; }
        DbSet<Manufacturer> Manufactorers { get; set; }
        DbSet<Marketing> Marketing { get; set; }
        DbSet<Menu> Menus { get; set; }
        DbSet<Modification> Modifications { get; set; }
        DbSet<Module> Modules { get; set; }
        DbSet<Option> Options { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderStatus> OrderStatuses { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<ProductSticker> Stickers { get; set; }
        DbSet<Recurring> Recurrings { get; set; }
        DbSet<Return> Returns { get; set; }
        DbSet<ReturnAction> ReturnActions { get; set; }
        DbSet<ReturnReason> ReturnReasons { get; set; }
        DbSet<ReturnStatus> ReturnStatuses { get; set; }
        DbSet<Review> Reviews { get; set; }
        DbSet<Setting> Setting { get; set; }
        DbSet<StockStatus> StockStatuses { get; set; }
        DbSet<Store> Stores { get; set; }
        DbSet<TaxClass> TaxClasses { get; set; }
        DbSet<TaxRate> TaxRates { get; set; }
        DbSet<TaxRule> TaxRule { get; set; }
        DbSet<Theme> Themes { get; set; }
        DbSet<Translation> Translations { get; set; }
        DbSet<Upload> Uploads { get; set; }
        DbSet<UrlAlias> UrlAliases { get; set; }
        DbSet<Voucher> Vouchers { get; set; }
        DbSet<VoucherTheme> VoucherThemes { get; set; }
        DbSet<Zone> Zones { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<UserGroup> UserGroups { get; set; }
        DbSet<WeightClass> WeightUnits { get; set; }
        DbSet<LengthClass> LengthUnits { get; set; }

        int SaveChanges();
    }
}