namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_return_history")]
    public class ReturnHistory
    {
        [Key]
        [Column("return_history_id")]
        public int Id { get; set; }

        [Column("return_id")]
        public int ReturnId { get; set; }

        [Column("return_status_id")]
        public int ReturnStatusId { get; set; }

        public bool notify { get; set; }

        [Column("comment", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Comment { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
