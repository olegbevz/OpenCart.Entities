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
        public int Id { get; protected set; }

        [Column("tax_class_id")]
        public int TaxClassId { get; set; }

        public virtual TaxClass TaxClass { get; set; }

        [Column("tax_rate_id")]
        public int TaxRateId { get; set; }

        public virtual TaxRate TaxRate { get; set; }

        [Required]
        [StringLength(10)]
        [Column("based")]
        public string Based { get; set; }

        [Column("priority")]
        public int Priority { get; set; }
    }
}
