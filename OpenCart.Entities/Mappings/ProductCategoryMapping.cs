using System.Data.Entity.ModelConfiguration;

namespace OpenCart.Entities
{
    internal class ProductCategoryMapping : EntityTypeConfiguration<ProductToCategory>
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
