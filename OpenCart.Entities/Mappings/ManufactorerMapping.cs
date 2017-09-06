using System.Data.Entity.ModelConfiguration;

namespace OpenCart.Entities
{
    internal class ManufactorerMapping : EntityTypeConfiguration<Manufacturer>
    {
        public ManufactorerMapping()
        {
            HasMany(x => x.Descriptions);

            HasMany(x => x.Products).WithRequired(x => x.Manufacturer)
                .HasForeignKey(x => x.ManufacturerId);

            HasMany(x => x.Stores)
            .WithMany()
            .Map(x => x.ToTable("oc_manufacturer_to_store")
            .MapLeftKey("manufacturer_id")
            .MapRightKey("store_id"));
        }
    }
}
