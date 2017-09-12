using System.Data.Entity.ModelConfiguration;

namespace OpenCart.Entities.Mappings
{
    internal class ManufactorerMapping : EntityTypeConfiguration<Manufacturer>
    {
        public ManufactorerMapping()
        {
            HasMany(x => x.Stores)
                .WithMany()
                .Map(x => x.ToTable("oc_manufacturer_to_store")
                .MapLeftKey("manufacturer_id")
                .MapRightKey("store_id"));
        }
    }
}
