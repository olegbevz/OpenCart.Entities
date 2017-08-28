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
        public int order_recurring_id { get; set; }

        public int order_id { get; set; }

        [Required]
        [StringLength(255)]
        public string reference { get; set; }

        public int product_id { get; set; }

        [Required]
        [StringLength(255)]
        public string product_name { get; set; }

        public int product_quantity { get; set; }

        public int recurring_id { get; set; }

        [Required]
        [StringLength(255)]
        public string recurring_name { get; set; }

        [Required]
        [StringLength(255)]
        public string recurring_description { get; set; }

        [Required]
        [StringLength(25)]
        public string recurring_frequency { get; set; }

        public short recurring_cycle { get; set; }

        public short recurring_duration { get; set; }

        public decimal recurring_price { get; set; }

        public bool trial { get; set; }

        [Required]
        [StringLength(25)]
        public string trial_frequency { get; set; }

        public short trial_cycle { get; set; }

        public short trial_duration { get; set; }

        public decimal trial_price { get; set; }

        public sbyte status { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
