using System.Data.Entity.ModelConfiguration;

namespace OpenCart.Entities.Mappings
{
    internal class BlogMapping : EntityTypeConfiguration<Blog>
    {
        public BlogMapping()
        {
            HasMany(x => x.Products)
                .WithMany()
                .Map(x => x.ToTable("oc_blog_product")
                .MapLeftKey("blog_id")
                .MapRightKey("product_id"));

            HasMany(x => x.Stores)
                .WithMany()
                .Map(x => x.ToTable("oc_blog_to_store")
                .MapLeftKey("blog_id")
                .MapRightKey("store_id"));
        }
    }
}
