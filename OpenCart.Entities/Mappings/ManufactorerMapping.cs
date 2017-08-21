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
        }
    }
}
