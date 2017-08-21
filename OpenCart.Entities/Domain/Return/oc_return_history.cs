namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_return_history")]
    public class oc_return_history
    {
        [Key]
        public int return_history_id { get; set; }

        public int return_id { get; set; }

        public int return_status_id { get; set; }

        public bool notify { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string comment { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
