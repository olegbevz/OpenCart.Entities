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
        [Column("order_history_id")]
        public int Id { get; set; }

        [Column("order_id")]
        public int OrderId { get; set; }

        [Column("order_status_id")]
        public int OrderStatusId { get; set; }

        public bool notify { get; set; }

        [Column("comment", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Comment { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
