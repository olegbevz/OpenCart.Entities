namespace OpenCart.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_product_stickers_description")]
    public class StickerDescription : Localizable, IEntityWithTitle
    {
        [Key]
        [Column("product_sticker_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StickerId { get; set; }

        [Column("text", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Title { get; set; }

        [Column("title", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Text { get; set; }
    }
}
