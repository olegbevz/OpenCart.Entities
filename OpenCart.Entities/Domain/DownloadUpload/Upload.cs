namespace OpenCart.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_upload")]
    public class Upload : IEntityWithName
    {
        [Key]
        [Column("upload_id")]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        [Column("filename")]
        public string Filename { get; set; }

        [Required]
        [StringLength(255)]
        [Column("code")]
        public string Code { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
