namespace OpenCart.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_layout")]
    public class Layout
    {
        [Key, Column("layout_id")]
        public int Id { get; set; }

        [Required, StringLength(64), Column("name")]
        public string Name { get; set; }
    }
}
