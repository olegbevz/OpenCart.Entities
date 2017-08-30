namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_tax_rule")]
    public class TaxRule
    {
        [Key]
		[Column("tax_rule_id")]
        public int tax_rule_id { get; set; }

		[Column("tax_class_id")]
        public int tax_class_id { get; set; }

		[Column("tax_rate_id")]
        public int tax_rate_id { get; set; }

        [Required]
        [StringLength(10)]
		[Column("based")]
        public string based { get; set; }

		[Column("priority")]
        public int priority { get; set; }
    }
}
