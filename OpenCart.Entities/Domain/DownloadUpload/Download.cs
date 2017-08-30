namespace OpenCart.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_download")]
    public class Download
    {
        [Key]
		[Column("download_id")]
        public int download_id { get; set; }

        [Required]
        [StringLength(160)]
		[Column("filename")]
        public string filename { get; set; }

        [Required]
        [StringLength(128)]
		[Column("mask")]
        public string mask { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
