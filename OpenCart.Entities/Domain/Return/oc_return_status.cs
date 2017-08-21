namespace JustWatch.OpenCart
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_return_status")]
    public class oc_return_status : Localizable
    {
        [Key]
        [Column(Order = 0)]
        public int return_status_id { get; set; }

        [Required]
        [StringLength(128)]
        [Column("name")]
        public string Name { get; set; }
    }
}
