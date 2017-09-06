namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_product_reward")]
    public class ProductReward
    {
        [Key]
        [Column("product_reward_id")]
        public int Id { get; protected set; }

        [Column("product_id")]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        [Column("customer_group_id")]
        public int CustomerGroupId { get; set; }

        public virtual CustomerGroup CustomerGroup { get; set; }

        [Column("points")]
        public int Points { get; set; }
    }
}
