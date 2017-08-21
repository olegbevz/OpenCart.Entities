using System.Data.Entity.ModelConfiguration;

namespace JustWatch.OpenCart
{
    internal class WeightUnitMapping : EntityTypeConfiguration<WeightUnit>
    {
        public WeightUnitMapping()
        {
            HasMany(x => x.Descriptions);
        }
    }
}
