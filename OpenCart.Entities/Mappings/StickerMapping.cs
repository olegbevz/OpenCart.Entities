using System.Data.Entity.ModelConfiguration;

namespace OpenCart.Entities.Mappings
{
    class StickerMapping : EntityTypeConfiguration<Sticker>
    {
        public StickerMapping()
        {
            HasMany(x => x.Descriptions);
        }
    }
}
