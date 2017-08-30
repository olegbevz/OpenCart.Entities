namespace OpenCart.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_product_stickers")]
    public class ProductSticker : IEntityWithStatus
    {
        [Key]
        [Column("product_sticker_id")]
        public int Id { get; protected set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        [Column("color", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Color { get; set; }

        [Column("background", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Background { get; set; }

        public ICollection<ProductStickerDescription> Descriptions { get; set; }
    }
}
