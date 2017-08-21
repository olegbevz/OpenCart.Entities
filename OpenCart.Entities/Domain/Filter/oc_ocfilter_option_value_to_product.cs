namespace JustWatch.OpenCart
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_ocfilter_option_value_to_product")]
    public class oc_ocfilter_option_value_to_product
    {
        [Key]
        public int ocfilter_option_value_to_product_id { get; set; }

        public int product_id { get; set; }

        public int option_id { get; set; }

        public long value_id { get; set; }

        public decimal slide_value_min { get; set; }

        public decimal slide_value_max { get; set; }
    }
}
