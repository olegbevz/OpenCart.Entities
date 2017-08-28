using System.Data.Entity.ModelConfiguration;

namespace OpenCart.Entities
{
    internal class LengthUnitMapping : EntityTypeConfiguration<LengthClass>
    {
        public LengthUnitMapping()
        {
            HasMany(x => x.Descriptions);
        }
    }
}
