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
        public int customer_ip_id { get; set; }

        public int customer_id { get; set; }

        [Required]
        [StringLength(40)]
        public string ip { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
