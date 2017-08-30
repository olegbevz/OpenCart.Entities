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
        public int Id { get; protected set; }

        [Column("voucher_id")]
        public int VoucherId { get; set; }

        [Column("order_id")]
        public int OrderId { get; set; }

        [Column("amount")]
        public decimal Amount { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
