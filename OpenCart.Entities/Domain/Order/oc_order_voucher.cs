namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_order_voucher")]
    public class oc_order_voucher
    {
        [Key]
        public int order_voucher_id { get; set; }

        public int order_id { get; set; }

        public int voucher_id { get; set; }

        [Required]
        [StringLength(255)]
        [Column("description")]
        public string Description { get; set; }

        [Required]
        [StringLength(10)]
        [Column("code")]
        public string Code { get; set; }

        [Required]
        [StringLength(64)]
        public string from_name { get; set; }

        [Required]
        [StringLength(96)]
        public string from_email { get; set; }

        [Required]
        [StringLength(64)]
        public string to_name { get; set; }

        [Required]
        [StringLength(96)]
        public string to_email { get; set; }

        public int voucher_theme_id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string message { get; set; }

        public decimal amount { get; set; }
    }
}
