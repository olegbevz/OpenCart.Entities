namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_coupon_product")]
    public class CouponProduct
    {
        [Key]
        [Column("coupon_product_id")]
        public int CouponProductId { get; set; }

        [Column("coupon_id")]
        public int CouponId { get; set; }

        [Column("product_id")]
        public int ProductId { get; set; }
    }
}
