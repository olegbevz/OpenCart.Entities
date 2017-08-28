namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_return")]
    public class Return
    {
        [Key]
        public int return_id { get; set; }

        public int order_id { get; set; }

        public int product_id { get; set; }

        public int customer_id { get; set; }

        [Required]
        [StringLength(32)]
        public string firstname { get; set; }

        [Required]
        [StringLength(32)]
        public string lastname { get; set; }

        [Required]
        [StringLength(96)]
        public string email { get; set; }

        [Required]
        [StringLength(32)]
        public string telephone { get; set; }

        [Required]
        [StringLength(255)]
        public string product { get; set; }

        [Required]
        [StringLength(64)]
        public string model { get; set; }

        public int quantity { get; set; }

        public bool opened { get; set; }

        public int return_reason_id { get; set; }

        public int return_action_id { get; set; }

        public int return_status_id { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string comment { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_ordered { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }

        [Column("date_modified")]
        public DateTime DateModified { get; set; }
    }
}
