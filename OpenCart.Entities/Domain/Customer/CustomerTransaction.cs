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
        public int customer_transaction_id { get; set; }

		[Column("customer_id")]
        public int customer_id { get; set; }

		[Column("order_id")]
        public int order_id { get; set; }

        [Column("description", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Description { get; set; }

        public decimal amount { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
