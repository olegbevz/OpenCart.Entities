namespace JustWatch.OpenCart
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_voucher_theme_description")]
    public class oc_voucher_theme_description : Localizable
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int voucher_theme_id { get; set; }

        [Required]
        [StringLength(32)]
        [Column("name")]
        public string Name { get; set; }
    }
}
