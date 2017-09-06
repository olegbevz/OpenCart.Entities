namespace OpenCart.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_weight_class")]
    public class WeightClass
    {
        [Key, Column("weight_class_id")]
        public int Id { get; protected set; }

        [Column("value")]
        public decimal Value { get; set; }

        public virtual ICollection<WeightClassDescription> Descriptions { get; set; } = new HashSet<WeightClassDescription>();
    }
}
