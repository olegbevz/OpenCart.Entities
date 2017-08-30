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
        public int coupon_history_id { get; set; }

		[Column("coupon_id")]
        public int coupon_id { get; set; }

		[Column("order_id")]
        public int order_id { get; set; }

		[Column("customer_id")]
        public int customer_id { get; set; }

        public decimal amount { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
