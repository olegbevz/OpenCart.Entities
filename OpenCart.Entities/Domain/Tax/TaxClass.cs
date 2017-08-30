namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_tax_class")]
    public class TaxClass : IEntityWithTitle
    {
        [Key]
        [Column("tax_class_id")]
        public int Id { get; set; }

        [Required]
        [StringLength(32)]
        [Column("title")]
        public string Title { get; set; }

        [Required]
        [StringLength(255)]
        [Column("description")]
        public string Description { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }

        [Column("date_modified")]
        public DateTime DateModified { get; set; }
    }
}
