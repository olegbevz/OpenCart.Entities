using System.Data.Entity.ModelConfiguration;

namespace JustWatch.OpenCart
{
    internal class ProductLayoutMapping : EntityTypeConfiguration<ProductLayout>
    {
        public ProductLayoutMapping()
        {
            HasRequired(x => x.Product).WithMany(x => x.Layouts).HasForeignKey(x => x.ProductId);
            HasRequired(x => x.Store).WithMany().HasForeignKey(x => x.StoreId);
            HasRequired(x => x.Layout).WithMany().HasForeignKey(x => x.LayoutId);
        }
    }
}
