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
        public int zone_id { get; set; }

        public int country_id { get; set; }

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
