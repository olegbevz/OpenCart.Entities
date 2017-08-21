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
        DbSet<WeightUnit> WeightUnits { get; }
        DbSet<LengthUnit> LengthUnits { get; }
        DbSet<Store> Stores { get; }
        DbSet<ExtraTab> ExtraTabs { get; }
        DbSet<Sticker> Stickers { get; }

        int SaveChanges();
    }
}