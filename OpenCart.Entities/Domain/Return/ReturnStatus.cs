namespace OpenCart.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_return_status")]
    public class ReturnStatus : IEntityWithName
    {
        [Key]
        [Column("return_status_id", Order = 0)]
        public int Id { get; protected set; }

        [Required]
        [StringLength(128)]
        [Column("name")]
        public string Name { get; set; }

        [Column("language_id", Order = 1)]
        public int LanguageId { get; set; }

        public virtual Language Language { get; set; }
    }
}
