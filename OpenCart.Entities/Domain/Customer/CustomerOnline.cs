namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_customer_online")]
    public class CustomerOnline
    {
        [Key]
        [StringLength(40)]
        [Column("ip")]
        public string Ip { get; set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        [Column("url", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Url { get; set; }

        [Column("referer", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Referer { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
