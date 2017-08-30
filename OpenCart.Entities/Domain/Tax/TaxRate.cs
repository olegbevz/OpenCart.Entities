namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_tax_rate")]
    public class TaxRate : IEntityWithName
    {
        [Key]
		[Column("tax_rate_id")]
        public int tax_rate_id { get; set; }

		[Column("geo_zone_id")]
        public int geo_zone_id { get; set; }

        [Required]
        [StringLength(32)]
        [Column("name")]
        public string Name { get; set; }

        public decimal rate { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string type { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }

        [Column("date_modified")]
        public DateTime DateModified { get; set; }
    }
}
