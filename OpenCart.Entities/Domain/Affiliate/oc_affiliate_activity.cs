namespace JustWatch.OpenCart
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_affiliate_activity")]
    public class oc_affiliate_activity
    {
        [Key]
        public int affiliate_activity_id { get; set; }

        public int affiliate_id { get; set; }

        [Required]
        [StringLength(64)]
        public string key { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string data { get; set; }

        [Required]
        [StringLength(40)]
        public string ip { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
