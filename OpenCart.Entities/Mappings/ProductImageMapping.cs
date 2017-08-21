using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OpenCart.Entities.Mappings
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
