using System.Data.Entity.ModelConfiguration;

namespace OpenCart.Entities
{
    internal class CategoryMapping : EntityTypeConfiguration<Category>
    {
        public CategoryMapping()
        {
            HasRequired(x => x.ParentCategory)
               .WithMany(x => x.Categories)
               .HasForeignKey(x => x.ParentCategoryId);
            
            HasMany(x => x.Descriptions);

            HasMany(x => x.Products)
              .WithRequired(x => x.Category);
        }
    }
}
