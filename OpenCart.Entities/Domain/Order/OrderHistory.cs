namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_order_history")]
    public class OrderHistory
    {
        [Key]
        public int order_history_id { get; set; }

        public int order_id { get; set; }

        public int order_status_id { get; set; }

        public bool notify { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string comment { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
