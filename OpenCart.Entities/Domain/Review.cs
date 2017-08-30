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
        public int Id { get; set; }

        [Column("product_id")]
        public int ProductId { get; set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(64)]
        [Column("author")]
        public string Author { get; set; }

        [Column("text", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Text { get; set; }

        [Column("rating")]
        public int Rating { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }

        [Column("date_modified")]
        public DateTime DateModified { get; set; }
    }
}
