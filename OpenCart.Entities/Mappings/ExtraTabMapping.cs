using System.Data.Entity.ModelConfiguration;

namespace OpenCart.Entities
{
    internal class ExtraTabMapping : EntityTypeConfiguration<ExtraTab>
    {
        public ExtraTabMapping()
        {
            HasMany(x => x.Descriptions)
                .WithRequired(x => x.ExtraTab)
                .HasForeignKey(x => x.ExtraTabId)
                .WillCascadeOnDelete(true);
        }
    }
}
