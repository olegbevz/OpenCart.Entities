namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_customer_ip")]
    public class CustomerIp
    {
        [Key]
        [Column("customer_ip_id")]
        public int Id { get; protected set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(40)]
        [Column("ip")]
        public string Ip { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
