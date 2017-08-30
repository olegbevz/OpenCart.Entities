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
        public string ip { get; set; }

		[Column("customer_id")]
        public int customer_id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string url { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string referer { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
