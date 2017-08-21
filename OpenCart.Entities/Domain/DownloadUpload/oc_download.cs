namespace OpenCart.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_download")]
    public class oc_download
    {
        [Key]
        public int download_id { get; set; }

        [Required]
        [StringLength(160)]
        public string filename { get; set; }

        [Required]
        [StringLength(128)]
        public string mask { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
