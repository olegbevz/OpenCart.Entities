using System.Data.Entity.ModelConfiguration;

namespace JustWatch.OpenCart.Mappings
{
    class StickerMapping : EntityTypeConfiguration<Sticker>
    {
        public StickerMapping()
        {
            HasMany(x => x.Descriptions);
        }
    }
}
