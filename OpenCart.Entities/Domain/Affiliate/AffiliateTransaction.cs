namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_affiliate_transaction")]
    public class AffiliateTransaction
    {
        [Key]
        [Column("affiliate_transaction_id")]
        public int AffiliateTransactionId { get; set; }

        [Column("affiliate_id")]
        public int AffiliateId { get; set; }

        [Column("order_id")]
        public int OrderId { get; set; }

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
