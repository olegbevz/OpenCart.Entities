namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_order_recurring_transaction")]
    public class OrderRecurringTransaction
    {
        [Key]
		[Column("order_recurring_transaction_id")]
        public int order_recurring_transaction_id { get; set; }

		[Column("order_recurring_id")]
        public int order_recurring_id { get; set; }

        [Required]
        [StringLength(255)]
		[Column("reference")]
        public string reference { get; set; }

        [Required]
        [StringLength(255)]
		[Column("type")]
        public string type { get; set; }

        public decimal amount { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
