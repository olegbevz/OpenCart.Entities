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
        public int Id { get; set; }

        [Column("order_id")]
        public int OrderId { get; set; }

        [Column("product_id")]
        public int ProductId { get; set; }

        [Required]
        [StringLength(255)]
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [StringLength(64)]
        [Column("model")]
        public string Model { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("total")]
        public decimal Total { get; set; }

        [Column("tax")]
        public decimal Tax { get; set; }

        [Column("reward")]
        public int Reward { get; set; }
    }
}
