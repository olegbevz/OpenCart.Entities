using System.Data.Entity.ModelConfiguration;

namespace OpenCart.Entities.Mappings
{
    class StickerMapping : EntityTypeConfiguration<ProductSticker>
    {
        public StickerMapping()
        {
            HasMany(x => x.Descriptions);
        }
    }
}
