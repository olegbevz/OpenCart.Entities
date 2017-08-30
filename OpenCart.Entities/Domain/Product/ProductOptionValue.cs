namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_product_option_value")]
    public class ProductOptionValue
    {
        [Key]
		[Column("product_option_value_id")]
        public int product_option_value_id { get; set; }

		[Column("product_option_id")]
        public int product_option_id { get; set; }

		[Column("product_id")]
        public int product_id { get; set; }

		[Column("option_id")]
        public int option_id { get; set; }

		[Column("option_value_id")]
        public int option_value_id { get; set; }

		[Column("quantity")]
        public int quantity { get; set; }

        public bool subtract { get; set; }

        public decimal price { get; set; }

        [Required]
        [StringLength(1)]
		[Column("price_prefix")]
        public string price_prefix { get; set; }

		[Column("points")]
        public int points { get; set; }

        [Required]
        [StringLength(1)]
		[Column("points_prefix")]
        public string points_prefix { get; set; }

        public decimal weight { get; set; }

        [Required]
        [StringLength(1)]
		[Column("weight_prefix")]
        public string weight_prefix { get; set; }
    }
}
