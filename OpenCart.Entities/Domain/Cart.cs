namespace OpenCart.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_cart")]
    public class Cart
    {
        [Key, Column("cart_id", TypeName = "uint")]
        public long Id { get; protected set; }

        [Column("api_id")]
        public int ApiId { get; set; }

        public virtual Api Api { get; set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        [Required, StringLength(32), Column("session_id")]
        public string SessionId { get; set; }

        [Column("product_id")]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        [Column("recurring_id")]
        public int RecurringId { get; set; }

        public virtual Recurring Recurring { get; set; }

        [Required, StringLength(65535), Column("option")]
        public string Option { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
