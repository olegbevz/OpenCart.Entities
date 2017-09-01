namespace OpenCart.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_product_attribute")]
    public class ProductAttribute
    {
        public ProductAttribute(Attribute attribute, Language language, string value)
        {
            AttributeId = attribute.Id;
            LanguageId = language.Id;
            Value = value;
        }

        public ProductAttribute()
        {
        }

        [Key, Column("product_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; protected set; }

        [Key, Column("attribute_id", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AttributeId { get; set; }

        [Key]
        [Column("language_id", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LanguageId { get; set; }

        public virtual Language Language { get; set; }

        [Required(AllowEmptyStrings = true), StringLength(65535), Column("text", TypeName = "text")]
        public string Value { get; set; }

        public virtual Attribute Attribute { get; set; }

        public virtual Product Product { get; set; }
    }
}
