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
        public int product_reward_id { get; set; }

        public int product_id { get; set; }

        public int customer_group_id { get; set; }

        public int points { get; set; }
    }
}
