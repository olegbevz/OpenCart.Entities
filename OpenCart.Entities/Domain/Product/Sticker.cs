namespace JustWatch.OpenCart
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_product_stickers")]
    public class Sticker
    {
        [Key]
        [Column("product_sticker_id")]
        public int Id { get; protected set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Color { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Background { get; set; }

        public ICollection<StickerDescription> Descriptions { get; set; }
    }
}
