namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_order_recurring")]
    public class OrderRecurring
    {
        [Key]
        [Column("order_recurring_id")]
        public int Id { get; protected set; }

        [Column("order_id")]
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }

        [Required]
        [StringLength(255)]
        [Column("reference")]
        public string Reference { get; set; }

        [Column("product_id")]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        [Required]
        [StringLength(255)]
        [Column("product_name")]
        public string ProductName { get; set; }

        [Column("product_quantity")]
        public int ProductQuantity { get; set; }

        [Column("recurring_id")]
        public int RecurringId { get; set; }

        public virtual Recurring Recurring { get; set; }

        [Required]
        [StringLength(255)]
        [Column("recurring_name")]
        public string RecurringName { get; set; }

        [Required]
        [StringLength(255)]
        [Column("recurring_description")]
        public string RecurringDescription { get; set; }

        [Required]
        [StringLength(25)]
        [Column("recurring_frequency")]
        public string RecurringFrequency { get; set; }

        [Column("recurring_cycle")]
        public short RecurringCycle { get; set; }

        [Column("recurring_duration")]
        public short RecurringDuration { get; set; }

        [Column("recurring_price")]
        public decimal RecurringPrice { get; set; }

        [Column("trial")]
        public bool Trial { get; set; }

        [Required]
        [StringLength(25)]
        [Column("trial_frequency")]
        public string TrialFrequency { get; set; }

        [Column("trial_cycle")]
        public short TrialCycle { get; set; }

        [Column("trial_duration")]
        public short TrialDuration { get; set; }

        [Column("trial_price")]
        public decimal TrialPrice { get; set; }

        [Column("status")]
        public sbyte Status { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }

        public virtual ICollection<OrderRecurringTransaction> Transactions { get; set; } = new HashSet<OrderRecurringTransaction>();
    }
}
