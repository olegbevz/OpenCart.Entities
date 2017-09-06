namespace OpenCart.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_customer_transaction")]
    public class CustomerTransaction
    {
        [Key]
        [Column("customer_transaction_id")]
        public int Id { get; protected set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        [Column("order_id")]
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }

        [Column("description", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Description { get; set; }

        [Column("amount")]
        public decimal Amount { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
