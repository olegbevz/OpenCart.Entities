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
        public int Id { get; protected set; }

        [Column("order_id")]
        public int OrderId { get; set; }

        [Column("voucher_id")]
        public int VoucherId { get; set; }

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
        public string FromName { get; set; }

        [Required]
        [StringLength(96)]
        [Column("from_email")]
        public string FromEmail { get; set; }

        [Required]
        [StringLength(64)]
        [Column("to_name")]
        public string ToName { get; set; }

        [Required]
        [StringLength(96)]
        [Column("to_email")]
        public string ToEmail { get; set; }

        [Column("voucher_theme_id")]
        public int VoucherThemeId { get; set; }

        [Column("message", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Message { get; set; }

        [Column("amount")]
        public decimal Amount { get; set; }
    }
}
