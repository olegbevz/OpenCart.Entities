using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JustWatch.OpenCart.Mappings
{
    internal class ProductImageMapping : EntityTypeConfiguration<ProductImage>
    {
        public ProductImageMapping()
        {
            HasKey(x => new { x.Id, x.ProductId });
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
