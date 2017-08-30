namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_order_option")]
    public class OrderOption : IEntityWithName
    {
        [Key]
		[Column("order_option_id")]
        public int order_option_id { get; set; }

		[Column("order_id")]
        public int order_id { get; set; }

		[Column("order_product_id")]
        public int order_product_id { get; set; }

		[Column("product_option_id")]
        public int product_option_id { get; set; }

		[Column("product_option_value_id")]
        public int product_option_value_id { get; set; }

        [Required]
        [StringLength(255)]
        [Column("name")]
        public string Name { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string value { get; set; }

        [Required]
        [StringLength(32)]
		[Column("type")]
        public string type { get; set; }
    }
}
