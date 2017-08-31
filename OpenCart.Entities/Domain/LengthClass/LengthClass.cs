namespace OpenCart.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_length_class")]
    public class LengthClass
    {
        [Key, Column("length_class_id")]
        public int Id { get; protected set; }

        [Column("value")]
        public decimal Value { get; set; }

        public virtual ICollection<LengthClassDescription> Descriptions { get; set; }
    }
}
