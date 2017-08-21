namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_order_recurring_transaction")]
    public class oc_order_recurring_transaction
    {
        [Key]
        public int order_recurring_transaction_id { get; set; }

        public int order_recurring_id { get; set; }

        [Required]
        [StringLength(255)]
        public string reference { get; set; }

        [Required]
        [StringLength(255)]
        public string type { get; set; }

        public decimal amount { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
