namespace OpenCart.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_return_status")]
    public class ReturnStatus : Localizable, IEntityWithName
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; protected set; }

        [Required]
        [StringLength(128)]
        [Column("name")]
        public string Name { get; set; }
    }
}
