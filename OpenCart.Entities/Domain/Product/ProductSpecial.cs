namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_product_special")]
    public class ProductSpecial
    {
        [Key]
		[Column("product_special_id")]
        public int product_special_id { get; set; }

		[Column("product_id")]
        public int product_id { get; set; }

		[Column("customer_group_id")]
        public int customer_group_id { get; set; }

		[Column("priority")]
        public int priority { get; set; }

        public decimal price { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_start { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_end { get; set; }
    }
}
