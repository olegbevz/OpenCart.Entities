namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_affiliate_activity")]
    public class AffiliateActivity
    {
        [Key]
        [Column("affiliate_activity_id")]
        public int AffiliateActivityId { get; set; }

        [Column("affiliate_id")]
        public int AffiliateId { get; set; }

        [Required]
        [StringLength(64)]
        [Column("key")]
        public string Key { get; set; }

        [Column("data", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Data { get; set; }

        [Required]
        [StringLength(40)]
        [Column("ip")]
        public string Ip { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
