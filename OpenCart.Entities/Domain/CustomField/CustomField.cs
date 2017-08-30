namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_custom_field")]
    public class CustomField : IEntityWithStatus
    {
        [Key]
        [Column("custom_field_id")]
        public int Id { get; protected set; }

        [Required]
        [StringLength(32)]
        [Column("type")]
        public string Type { get; set; }

        [Column("value", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Value { get; set; }

        [Required]
        [StringLength(255)]
        [Column("validation")]
        public string Validation { get; set; }

        [Required]
        [StringLength(7)]
        [Column("location")]
        public string Location { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }
    }
}
