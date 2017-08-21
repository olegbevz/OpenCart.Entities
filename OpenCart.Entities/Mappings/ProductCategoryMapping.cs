using System.Data.Entity.ModelConfiguration;

namespace JustWatch.OpenCart
{
    internal class ProductCategoryMapping : EntityTypeConfiguration<ProductCategory>
    {
        public ProductCategoryMapping()
        {
            HasRequired(x => x.Product)
              .WithMany(x => x.Categories)
              .HasForeignKey(x => x.ProductId);
            
            HasRequired(x => x.Category)
              .WithMany()
              .HasForeignKey(x => x.CategoryId);
        }
    }
}
