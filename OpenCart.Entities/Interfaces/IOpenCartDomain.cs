using System;
using System.Data.Entity;

namespace OpenCart.Entities
{
    public interface IOpenCartDomain : IDisposable
    {
        DbSet<Affiliate> Affiliates { get; }
        DbSet<Api> Apis { get; }
        DbSet<Attribute> Attributes { get; }
        DbSet<AttributeGroup> AttributeGroups { get; }
        DbSet<Banner> Banners { get; }
        DbSet<Blog> Blogs { get; }
        DbSet<Cart> Cart { get; }
        DbSet<Category> Categories { get; }
        DbSet<Country> Countries { get; }
        DbSet<Coupon> Coupons { get; }
        DbSet<Currency> Currencies { get; }
        DbSet<CustomField> CustomFields { get; }
        DbSet<Customer> Customers { get; }
        DbSet<CustomerGroup> CustomerGroups { get; }
        DbSet<Download> Downloads { get; }
        DbSet<Event> Events { get; }
        DbSet<Extension> Extensions { get; }
        DbSet<ExtraTab> ExtraTabs { get; }
        DbSet<Filter> Filters { get; }
        DbSet<FilterGroup> FilterGroups { get; }
        DbSet<GeoZone> GeoZones { get; }
        DbSet<Information> Information { get; }
        DbSet<Language> Languages { get; }
        DbSet<Layout> Layouts { get; }
        DbSet<Location> Locations { get; }
        DbSet<Manufacturer> Manufactorers { get; }
        DbSet<Marketing> Marketing { get; }
        DbSet<Menu> Menus { get; }
        DbSet<Modification> Modifications { get; }
        DbSet<Module> Modules { get; }
        DbSet<Option> Options { get; }
        DbSet<Order> Orders { get; }
        DbSet<OrderStatus> OrderStatuses { get; }
        DbSet<Product> Products { get; }
        DbSet<ProductSticker> Stickers { get; }
        DbSet<Recurring> Recurrings { get; }
        DbSet<Return> Returns { get; }
        DbSet<ReturnAction> ReturnActions { get; }
        DbSet<ReturnReason> ReturnReasons { get; }
        DbSet<ReturnStatus> ReturnStatuses { get; }
        DbSet<Review> Reviews { get; }
        DbSet<Setting> Setting { get; }
        DbSet<StockStatus> StockStatuses { get; }
        DbSet<Store> Stores { get; }
        DbSet<TaxClass> TaxClasses { get; }
        DbSet<TaxRate> TaxRates { get; }
        DbSet<TaxRule> TaxRule { get; }
        DbSet<Theme> Themes { get; }
        DbSet<Translation> Translations { get; }
        DbSet<Upload> Uploads { get; }
        DbSet<UrlAlias> UrlAliases { get; }
        DbSet<Voucher> Vouchers { get; }
        DbSet<VoucherTheme> VoucherThemes { get; }
        DbSet<Zone> Zones { get; }
        DbSet<User> Users { get; }
        DbSet<UserGroup> UserGroups { get; }
        DbSet<WeightClass> WeightUnits { get; }
        DbSet<LengthClass> LengthUnits { get; }

        int SaveChanges();
    }
}