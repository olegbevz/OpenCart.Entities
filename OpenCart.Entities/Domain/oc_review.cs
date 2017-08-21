namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_review")]
    public class oc_review
    {
        [Key]
        public int review_id { get; set; }

        public int product_id { get; set; }

        public int customer_id { get; set; }

        [Required]
        [StringLength(64)]
        public string author { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string text { get; set; }

        public int rating { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }

        [Column("date_modified")]
        public DateTime DateModified { get; set; }
    }
}
