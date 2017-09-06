namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_customer_wishlist")]
    public class CustomerWishlist
    {
        [Key]
        [Column("customer_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        [Key]
        [Column("product_id", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
