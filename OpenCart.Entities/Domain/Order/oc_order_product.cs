namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_order_product")]
    public class oc_order_product
    {
        [Key]
        public int order_product_id { get; set; }

        public int order_id { get; set; }

        public int product_id { get; set; }

        [Required]
        [StringLength(255)]
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [StringLength(64)]
        public string model { get; set; }

        public int quantity { get; set; }

        public decimal price { get; set; }

        public decimal total { get; set; }

        public decimal tax { get; set; }

        public int reward { get; set; }
    }
}
