namespace JustWatch.OpenCart
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_product_description")]
    public class ProductDescription : MetaDescriptionBase
    {
        [Key, Column("product_id", Order = 0), DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        public virtual Product Product { get; protected set; }

        [Required(AllowEmptyStrings = true), StringLength(65535), Column("tag", TypeName = "text")]
        public string Tag { get; set; }
    }
}
