namespace OpenCart.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_customer_transaction")]
    public class oc_customer_transaction
    {
        [Key]
        public int customer_transaction_id { get; set; }

        public int customer_id { get; set; }

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
