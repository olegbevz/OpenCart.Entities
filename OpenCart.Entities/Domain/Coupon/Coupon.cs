namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_coupon")]
    public class Coupon
    {
        [Key]
        public int coupon_id { get; set; }

        [Required]
        [StringLength(128)]
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [StringLength(20)]
        [Column("code")]
        public string Code { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string type { get; set; }

        public decimal discount { get; set; }

        public bool logged { get; set; }

        public bool shipping { get; set; }

        public decimal total { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_start { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_end { get; set; }

        public int uses_total { get; set; }

        [Required]
        [StringLength(11)]
        public string uses_customer { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
