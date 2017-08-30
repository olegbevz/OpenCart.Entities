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
        public int Id { get; protected set; }

        [Column("order_id")]
        public int OrderId { get; set; }

        [Column("order_product_id")]
        public int OrderProductId { get; set; }

        [Column("product_option_id")]
        public int ProductOptionId { get; set; }

        [Column("product_option_value_id")]
        public int ProductOptionValueId { get; set; }

        [Required]
        [StringLength(255)]
        [Column("name")]
        public string Name { get; set; }

        [Column("value", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Value { get; set; }

        [Required]
        [StringLength(32)]
        [Column("type")]
        public string Type { get; set; }
    }
}
