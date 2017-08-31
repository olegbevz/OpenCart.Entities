using System.Data.Entity.ModelConfiguration;

namespace OpenCart.Entities
{
    internal class AttributeGroupMapping : EntityTypeConfiguration<AttributeGroup>
    {
        public AttributeGroupMapping()
        {
            HasMany(x => x.Attributes).WithRequired(x => x.AttributeGroup).HasForeignKey(x => x.AttributeGroupId);

            HasMany(x => x.Descriptions);
        }
    }
}
