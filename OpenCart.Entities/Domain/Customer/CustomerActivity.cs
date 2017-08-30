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
        public int customer_activity_id { get; set; }

		[Column("customer_id")]
        public int customer_id { get; set; }

        [Required]
        [StringLength(64)]
		[Column("key")]
        public string key { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string data { get; set; }

        [Required]
        [StringLength(40)]
		[Column("ip")]
        public string ip { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
