namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_coupon_history")]
    public class CouponHistory
    {
        [Key]
        [Column("coupon_history_id")]
        public int Id { get; protected set; }

        [Column("coupon_id")]
        public int CouponId { get; set; }

        [Column("order_id")]
        public int OrderId { get; set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }

        [Column("amount")]
        public decimal Amount { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
