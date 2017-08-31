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
        public int Id { get; protected set; }

        [Column("geo_zone_id")]
        public int GeoZoneId { get; set; }

        [Required]
        [StringLength(32)]
        [Column("name")]
        public string Name { get; set; }

        [Column("rate")]
        public decimal Rate { get; set; }

        [Column("type", TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string Type { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }

        [Column("date_modified")]
        public DateTime DateModified { get; set; }

        public virtual ICollection<CustomerGroup> CustomerGroups { get; set; }
    }
}
