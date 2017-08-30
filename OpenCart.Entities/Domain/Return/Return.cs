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
		[Column("return_id")]
        public int return_id { get; set; }

		[Column("order_id")]
        public int order_id { get; set; }

		[Column("product_id")]
        public int product_id { get; set; }

		[Column("customer_id")]
        public int customer_id { get; set; }

        [Required]
        [StringLength(32)]
		[Column("firstname")]
        public string firstname { get; set; }

        [Required]
        [StringLength(32)]
		[Column("lastname")]
        public string lastname { get; set; }

        [Required]
        [StringLength(96)]
		[Column("email")]
        public string email { get; set; }

        [Required]
        [StringLength(32)]
		[Column("telephone")]
        public string telephone { get; set; }

        [Required]
        [StringLength(255)]
		[Column("product")]
        public string product { get; set; }

        [Required]
        [StringLength(64)]
		[Column("model")]
        public string model { get; set; }

		[Column("quantity")]
        public int quantity { get; set; }

        public bool opened { get; set; }

		[Column("return_reason_id")]
        public int return_reason_id { get; set; }

		[Column("return_action_id")]
        public int return_action_id { get; set; }

		[Column("return_status_id")]
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
