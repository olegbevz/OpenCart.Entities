namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_order_option")]
    public class oc_order_option
    {
        [Key]
        public int order_option_id { get; set; }

        public int order_id { get; set; }

        public int order_product_id { get; set; }

        public int product_option_id { get; set; }

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
        public string type { get; set; }
    }
}
