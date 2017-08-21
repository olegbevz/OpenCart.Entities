using System.Data.Entity.ModelConfiguration;

namespace JustWatch.OpenCart
{
    internal class ProductMapping : EntityTypeConfiguration<Product>
    {
        public ProductMapping()
        {
            HasMany(x => x.Descriptions)
                .WithRequired(x => x.Product)
                .HasForeignKey(x => x.ProductId)
                .WillCascadeOnDelete(true);

            HasMany(x => x.Images)
                .WithRequired(x => x.Product)
                .HasForeignKey(x => x.ProductId)
                .WillCascadeOnDelete(true);

            HasMany(x => x.Attributes)
                .WithRequired(x => x.Product)
                .HasForeignKey(x => x.ProductId)
                .WillCascadeOnDelete(true);

            HasRequired(x => x.LengthUnit).WithMany()
                .HasForeignKey(x => x.LengthUnitId);

            HasRequired(x => x.WeightUnit).WithMany()
                .HasForeignKey(x => x.WeightUnitId);

            HasMany(x => x.Stores).WithMany(x => x.Products)
                .Map(x => x.ToTable("oc_product_to_store").MapLeftKey("product_id").MapRightKey("store_id"));

            HasMany(x => x.RelatedProducts).WithMany()
                .Map(x => x.ToTable("oc_product_related").MapLeftKey("product_id").MapRightKey("related_id"));

            HasMany(x => x.ExtraTabs)
                .WithRequired(x => x.Product)
                .HasForeignKey(x => x.ProductId)
                .WillCascadeOnDelete(true);
        }
    }
}
