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
        public int Id { get; protected set; }

        [Column("product_id")]
        public int ProductId { get; set; }

        [Column("customer_group_id")]
        public int CustomerGroupId { get; set; }

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
