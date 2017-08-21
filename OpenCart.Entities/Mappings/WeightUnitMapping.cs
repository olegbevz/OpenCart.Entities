using System.Data.Entity.ModelConfiguration;

namespace OpenCart.Entities
{
    internal class WeightUnitMapping : EntityTypeConfiguration<WeightUnit>
    {
        public WeightUnitMapping()
        {
            HasMany(x => x.Descriptions);
        }
    }
}
