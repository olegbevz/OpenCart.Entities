namespace JustWatch.OpenCart
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_affiliate_transaction")]
    public class oc_affiliate_transaction
    {
        [Key]
        public int affiliate_transaction_id { get; set; }

        public int affiliate_id { get; set; }

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
