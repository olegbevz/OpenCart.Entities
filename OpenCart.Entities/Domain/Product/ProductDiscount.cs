namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_product_discount")]
    public class ProductDiscount
    {
        [Key]
        [Column("product_discount_id")]
        public int ProductDiscountId { get; set; }

        [Column("product_id")]
        public int ProductId { get; set; }

        [Column("customer_group_id")]
        public int CustomerGroupId { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("priority")]
        public int Priority { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("date_start", TypeName = "date")]
        public DateTime DateStart { get; set; }

        [Column("date_end", TypeName = "date")]
        public DateTime DateEnd { get; set; }
    }
}
