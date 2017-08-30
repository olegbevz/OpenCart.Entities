namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_tax_rate_to_customer_group")]
    public class TaxRateToCustomerGroup
    {
        [Key]
        [Column("tax_rate_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TaxRateId { get; set; }

        [Key]
        [Column("custoemr_group_id", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerGroupId { get; set; }
    }
}
