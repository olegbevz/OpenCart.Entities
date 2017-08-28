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
        public int coupon_product_id { get; set; }

        public int coupon_id { get; set; }

        public int product_id { get; set; }
    }
}
