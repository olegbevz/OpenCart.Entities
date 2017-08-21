using System.Data.Entity.ModelConfiguration;

namespace OpenCart.Entities
{
    internal class LengthUnitMapping : EntityTypeConfiguration<LengthUnit>
    {
        public LengthUnitMapping()
        {
            HasMany(x => x.Descriptions);
        }
    }
}
