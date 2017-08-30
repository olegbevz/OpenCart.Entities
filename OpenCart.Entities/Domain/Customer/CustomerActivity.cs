namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_customer_activity")]
    public class CustomerActivity
    {
        [Key]
        [Column("customer_activity_id")]
        public int Id { get; protected set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(64)]
        [Column("key")]
        public string Key { get; set; }

        [Column("data", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Data { get; set; }

        [Required]
        [StringLength(40)]
        [Column("ip")]
        public string Ip { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
