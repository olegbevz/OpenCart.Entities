namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_coupon_category")]
    public class CouponCategory
    {
        [Key]
        [Column("coupon_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CouponId { get; set; }

        [Key]
        [Column("category_id", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryId { get; set; }
    }
}
