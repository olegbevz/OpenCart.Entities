namespace JustWatch.OpenCart
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_language")]
    public class Language : IEntityWithName
    {
        [Key, Column("language_id")]
        public int Id { get; set; }

        [Required, StringLength(32), Column("name")]
        public string Name { get; set; }

        [Required, StringLength(5), Column("code")]
        public string Code { get; set; }

        [Required, StringLength(255), Column("locale")]
        public string Locale { get; set; }
        
        [Required, StringLength(64), Column("image")]
        public string Image { get; set; }

        [Required, StringLength(32), Column("directory")]
        public string Directory { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }
        
        [Column("status")]
        public bool Status { get; set; }
    }
}
