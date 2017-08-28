using System;
using System.Data.Entity;

namespace OpenCart.Entities
{
    public interface IOpenCartDomain : IDisposable
    {
        DbSet<Category> Categories { get; }
        DbSet<Country> Countries { get; }
        DbSet<Currency> Currencies { get; }
        DbSet<Language> Languages { get; }
        DbSet<Manufacturer> Manufactorers { get; }
        DbSet<Product> Products { get; }
        DbSet<StockStatus> StockStatuses { get; }
        DbSet<UrlAlias> UrlAliases { get; }
        DbSet<User> Users { get; }
        DbSet<UserGroup> UserGroups { get; }
        DbSet<AttributeGroup> AttributeGroups { get; }
        DbSet<WeightClass> WeightUnits { get; }
        DbSet<LengthClass> LengthUnits { get; }
        DbSet<Store> Stores { get; }
        DbSet<ExtraTab> ExtraTabs { get; }
        DbSet<ProductSticker> Stickers { get; }

        int SaveChanges();
    }
}