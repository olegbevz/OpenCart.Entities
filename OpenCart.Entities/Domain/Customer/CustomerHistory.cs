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
        public int customer_history_id { get; set; }

		[Column("customer_id")]
        public int customer_id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string comment { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
