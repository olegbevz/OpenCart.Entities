using System.Data.Entity.ModelConfiguration;

namespace OpenCart.Entities
{
    internal class CategoryMapping : EntityTypeConfiguration<Category>
    {
        public CategoryMapping()
        {
            HasMany(x => x.Filters)
                .WithMany()
                .Map(x => x.ToTable("oc_category_filter")
                .MapLeftKey("category_id")
                .MapRightKey("filter_id"));

            HasMany(x => x.Stores)
                .WithMany()
                .Map(x => x.ToTable("oc_category_to_store")
                .MapLeftKey("category_id")
                .MapRightKey("store_id"));
        }
    }
}
