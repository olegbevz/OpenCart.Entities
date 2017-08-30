namespace OpenCart.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_category_description")]
    public class CategoryDescription : MetaDescriptionBase
    {
        [Key, Column("category_id", Order = 0), DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
    }
}
