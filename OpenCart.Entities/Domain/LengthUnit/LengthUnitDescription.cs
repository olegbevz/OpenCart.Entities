namespace OpenCart.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_length_class_description")]
    public class LengthUnitDescription : Localizable, IEntityWithTitle
    {
        [Key, Column("length_class_id", Order = 0), DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LengthUnitId { get; set; }

        [Required, StringLength(32), Column("title")]
        public string Title { get; set; }

        [Required, StringLength(4), Column("unit")]
        public string Unit { get; set; }
    }
}
