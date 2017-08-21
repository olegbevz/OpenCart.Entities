namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_tax_rule")]
    public class oc_tax_rule
    {
        [Key]
        public int tax_rule_id { get; set; }

        public int tax_class_id { get; set; }

        public int tax_rate_id { get; set; }

        [Required]
        [StringLength(10)]
        public string based { get; set; }

        public int priority { get; set; }
    }
}
