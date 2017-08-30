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
        public int Id { get; set; }

        [Column("order_recurring_id")]
        public int OrderRecurringId { get; set; }

        [Required]
        [StringLength(255)]
        [Column("reference")]
        public string Reference { get; set; }

        [Required]
        [StringLength(255)]
        [Column("type")]
        public string Type { get; set; }

        [Column("amount")]
        public decimal Amount { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
