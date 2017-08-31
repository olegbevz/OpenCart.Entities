namespace OpenCart.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_recurring_description")]
    public class RecurringDescription : Localizable, IEntityWithName
    {
        [Key]
        [Column("recurring_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RecurringId { get; set; }

        public virtual Recurring Recurring { get; set; }

        [Required]
        [StringLength(255)]
        [Column("name")]
        public string Name { get; set; }
    }
}
