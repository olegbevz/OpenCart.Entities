using System.Data.Entity.ModelConfiguration;

namespace OpenCart.Entities
{
    internal class AttributeMapping : EntityTypeConfiguration<Attribute>
    {
        public AttributeMapping()
        {
            HasMany(x => x.Descriptions);
        }
    }
}
