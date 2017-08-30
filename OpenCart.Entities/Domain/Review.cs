namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_review")]
    public class Review : IEntityWithStatus
    {
        [Key]
		[Column("review_id")]
        public int review_id { get; set; }

		[Column("product_id")]
        public int product_id { get; set; }

		[Column("customer_id")]
        public int customer_id { get; set; }

        [Required]
        [StringLength(64)]
		[Column("author")]
        public string author { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string text { get; set; }

		[Column("rating")]
        public int rating { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }

        [Column("date_modified")]
        public DateTime DateModified { get; set; }
    }
}
