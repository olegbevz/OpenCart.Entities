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
        public int product_special_id { get; set; }

        public int product_id { get; set; }

        public int customer_group_id { get; set; }

        public int priority { get; set; }

        public decimal price { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_start { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_end { get; set; }
    }
}
