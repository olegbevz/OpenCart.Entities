namespace OpenCart.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_category_path")]
    public class CategoryPath
    {
        [Key]
        [Column("category_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        [Key]
        [Column("path_id", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PathId { get; set; }

        [Column("level")]
        public int Level { get; set; }
    }
}
