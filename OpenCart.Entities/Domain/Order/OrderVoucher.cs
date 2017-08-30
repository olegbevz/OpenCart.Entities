namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_order_voucher")]
    public class OrderVoucher
    {
        [Key]
		[Column("order_voucher_id")]
        public int order_voucher_id { get; set; }

		[Column("order_id")]
        public int order_id { get; set; }

		[Column("voucher_id")]
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
		[Column("from_name")]
        public string from_name { get; set; }

        [Required]
        [StringLength(96)]
		[Column("from_email")]
        public string from_email { get; set; }

        [Required]
        [StringLength(64)]
		[Column("to_name")]
        public string to_name { get; set; }

        [Required]
        [StringLength(96)]
		[Column("to_email")]
        public string to_email { get; set; }

		[Column("voucher_theme_id")]
        public int voucher_theme_id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string message { get; set; }

        public decimal amount { get; set; }
    }
}
