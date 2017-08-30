namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_custom_field_customer_group")]
    public class CustomFieldCustomerGroup
    {
        [Key]
        [Column("custom_field_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomFieldId { get; set; }

        [Key]
        [Column("CustomerGroupId", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerGroupId { get; set; }

        public bool required { get; set; }
    }
}
