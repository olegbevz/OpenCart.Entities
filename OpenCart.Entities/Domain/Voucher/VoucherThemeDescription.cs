namespace OpenCart.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_voucher_theme_description")]
    public class VoucherThemeDescription : Localizable, IEntityWithName
    {
        [Key]
        [Column("voucher_theme_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VoucherThemeId { get; set; }

        [Required]
        [StringLength(32)]
        [Column("name")]
        public string Name { get; set; }
    }
}
