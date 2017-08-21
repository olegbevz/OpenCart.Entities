namespace JustWatch.OpenCart
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_length_class")]
    public class LengthUnit
    {
        [Key, Column("length_class_id")]
        public int Id { get; set; }

        [Column("value")]
        public decimal Value { get; set; }

        public virtual ICollection<LengthUnitDescription> Descriptions { get; protected set; }
    }
}
