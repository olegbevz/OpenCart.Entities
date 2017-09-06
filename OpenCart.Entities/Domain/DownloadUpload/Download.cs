using System.Collections.Generic;

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
        public int Id { get; protected set; }

        [Required]
        [StringLength(160)]
        [Column("filename")]
        public string Filename { get; set; }

        [Required]
        [StringLength(128)]
        [Column("mask")]
        public string Mask { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }

        public virtual ICollection<DownloadDescription> Descriptions { get; set; } = new HashSet<DownloadDescription>();
    }
}
