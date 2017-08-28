using System.Data.Entity.ModelConfiguration;

namespace OpenCart.Entities
{
    internal class WeightUnitMapping : EntityTypeConfiguration<WeightClass>
    {
        public WeightUnitMapping()
        {
            HasMany(x => x.Descriptions);
        }
    }
}
