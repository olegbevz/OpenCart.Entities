using System.Data.Entity.ModelConfiguration;

namespace JustWatch.OpenCart
{
    internal class AttributeMapping : EntityTypeConfiguration<Attribute>
    {
        public AttributeMapping()
        {
            HasMany(x => x.Descriptions);
        }
    }
}
