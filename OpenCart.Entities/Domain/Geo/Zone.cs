namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_zone")]
    public class Zone : IEntityWithName, IEntityWithStatus
    {
        [Key]
        [Column("zone_id")]
        public int ZoneId { get; set; }

        [Column("country_id")]
        public int CountryId { get; set; }

        [Required]
        [StringLength(128)]
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [StringLength(32)]
        [Column("code")]
        public string Code { get; set; }

        [Column("status")]
        public bool Status { get; set; }
    }
}
