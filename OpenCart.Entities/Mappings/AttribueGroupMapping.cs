using System.Data.Entity.ModelConfiguration;

namespace JustWatch.OpenCart
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
