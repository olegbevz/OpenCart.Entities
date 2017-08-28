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
        public int customer_history_id { get; set; }

        public int customer_id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string comment { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
