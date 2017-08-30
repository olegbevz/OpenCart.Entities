namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_product_recurring")]
    public class ProductRecurring
    {
        [Key]
        [Column("product_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        [Key]
        [Column("recurring_id", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RecurringId { get; set; }

        [Key]
        [Column("customer_group_id", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerGroupId { get; set; }
    }
}
