namespace JustWatch.OpenCart
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_product_option_value")]
    public class oc_product_option_value
    {
        [Key]
        public int product_option_value_id { get; set; }

        public int product_option_id { get; set; }

        public int product_id { get; set; }

        public int option_id { get; set; }

        public int option_value_id { get; set; }

        public int quantity { get; set; }

        public bool subtract { get; set; }

        public decimal price { get; set; }

        [Required]
        [StringLength(1)]
        public string price_prefix { get; set; }

        public int points { get; set; }

        [Required]
        [StringLength(1)]
        public string points_prefix { get; set; }

        public decimal weight { get; set; }

        [Required]
        [StringLength(1)]
        public string weight_prefix { get; set; }
    }
}
