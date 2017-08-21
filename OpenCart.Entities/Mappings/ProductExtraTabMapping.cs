using System.Data.Entity.ModelConfiguration;

namespace OpenCart.Entities
{
    internal class ProductExtraTabMapping : EntityTypeConfiguration<ProductExtraTab>
    {
        public ProductExtraTabMapping()
        {
            HasRequired(x => x.ExtraTab)
                .WithMany()
                .HasForeignKey(x => x.ExtraTabId)
                .WillCascadeOnDelete(true);
        }
    }
}