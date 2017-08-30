namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_voucher_history")]
    public class VoucherHistory
    {
        [Key]
		[Column("voucher_history_id")]
        public int voucher_history_id { get; set; }

		[Column("voucher_id")]
        public int voucher_id { get; set; }

		[Column("order_id")]
        public int order_id { get; set; }

        public decimal amount { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
