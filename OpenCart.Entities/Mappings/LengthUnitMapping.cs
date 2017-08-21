using System.Data.Entity.ModelConfiguration;

namespace JustWatch.OpenCart
{
    internal class LengthUnitMapping : EntityTypeConfiguration<LengthUnit>
    {
        public LengthUnitMapping()
        {
            HasMany(x => x.Descriptions);
        }
    }
}
