namespace OpenCart.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_weight_class_description")]
    public class WeightUnitDescription : Localizable, IEntityWithTitle
    {
        [Key, Column("weight_class_id", Order = 0)]
        public int WeightUnitId { get; set; }

        [Required, StringLength(32), Column("title")]
        public string Title { get; set; }

        [Required, StringLength(4), Column("unit")]
        public string Unit { get; set; }
    }
}
