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
        public int order_recurring_id { get; set; }

		[Column("order_id")]
        public int order_id { get; set; }

        [Required]
        [StringLength(255)]
		[Column("reference")]
        public string reference { get; set; }

		[Column("product_id")]
        public int product_id { get; set; }

        [Required]
        [StringLength(255)]
		[Column("product_name")]
        public string product_name { get; set; }

		[Column("product_quantity")]
        public int product_quantity { get; set; }

		[Column("recurring_id")]
        public int recurring_id { get; set; }

        [Required]
        [StringLength(255)]
		[Column("recurring_name")]
        public string recurring_name { get; set; }

        [Required]
        [StringLength(255)]
		[Column("recurring_description")]
        public string recurring_description { get; set; }

        [Required]
        [StringLength(25)]
		[Column("recurring_frequency")]
        public string recurring_frequency { get; set; }

        public short recurring_cycle { get; set; }

        public short recurring_duration { get; set; }

        public decimal recurring_price { get; set; }

        public bool trial { get; set; }

        [Required]
        [StringLength(25)]
		[Column("trial_frequency")]
        public string trial_frequency { get; set; }

        public short trial_cycle { get; set; }

        public short trial_duration { get; set; }

        public decimal trial_price { get; set; }

        public sbyte status { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
