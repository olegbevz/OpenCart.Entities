namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_customer_reward")]
    public class CustomerReward
    {
        [Key]
        [Column("customer_reward_id")]
        public int Id { get; set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }

        [Column("order_id")]
        public int OrderId { get; set; }

        [Column("description", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Description { get; set; }

        [Column("points")]
        public int Points { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
