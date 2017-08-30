namespace OpenCart.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_filter_group_description")]
    public class FilterGroupDescription : Localizable, IEntityWithName
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FilterGroupId { get; set; }

        [Required]
        [StringLength(64)]
        [Column("name")]
        public string Name { get; set; }
    }
}
