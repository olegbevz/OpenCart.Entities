namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_order_product")]
    public class OrderProduct : IEntityWithName
    {
        [Key]
		[Column("order_product_id")]
        public int order_product_id { get; set; }

		[Column("order_id")]
        public int order_id { get; set; }

		[Column("product_id")]
        public int product_id { get; set; }

        [Required]
        [StringLength(255)]
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [StringLength(64)]
		[Column("model")]
        public string model { get; set; }

		[Column("quantity")]
        public int quantity { get; set; }

        public decimal price { get; set; }

        public decimal total { get; set; }

        public decimal tax { get; set; }

		[Column("reward")]
        public int reward { get; set; }
    }
}
