using System.Data.Entity.ModelConfiguration;

namespace OpenCart.Entities
{
    internal class AttributeGroupMapping : EntityTypeConfiguration<AttributeGroup>
    {
        public AttributeGroupMapping()
        {
            HasMany(x => x.Attributes).WithRequired(x => x.Group).HasForeignKey(x => x.GroupId);

            HasMany(x => x.Descriptions);
        }
    }
}
