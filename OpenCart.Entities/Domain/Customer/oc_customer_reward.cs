namespace JustWatch.OpenCart
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_customer_reward")]
    public class oc_customer_reward
    {
        [Key]
        public int customer_reward_id { get; set; }

        public int customer_id { get; set; }

        public int order_id { get; set; }

        [Column("description", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Description { get; set; }

        public int points { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
