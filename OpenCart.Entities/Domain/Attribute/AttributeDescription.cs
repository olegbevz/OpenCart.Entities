namespace OpenCart.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_attribute_description")]
    public class AttributeDescription : Localizable
    {
        [Key, Column("attribute_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AttributeId { get; set; }

        [Required, StringLength(64), Column("name")]
        public string Name { get; set; }
    }
}
