namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_customer_history")]
    public class CustomerHistory
    {
        [Key]
        [Column("customer_history_id")]
        public int CustomerHistoryId { get; set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }

        [Column("comment", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Comment { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
