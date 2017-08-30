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
        public int custom_field_id { get; set; }

        [Required]
        [StringLength(32)]
		[Column("type")]
        public string type { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string value { get; set; }

        [Required]
        [StringLength(255)]
		[Column("validation")]
        public string validation { get; set; }

        [Required]
        [StringLength(7)]
		[Column("location")]
        public string location { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }
    }
}
