using System.Data.Entity.ModelConfiguration;

namespace JustWatch.OpenCart
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