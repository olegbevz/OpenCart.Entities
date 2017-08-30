namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_marketing")]
    public class Marketing : IEntityWithName
    {
        [Key]
        [Column("marketing_id")]
        public int MarketingId { get; set; }

        [Required]
        [StringLength(32)]
        [Column("name")]
        public string Name { get; set; }

        [Column("description", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Description { get; set; }

        [Required]
        [StringLength(64)]
        [Column("code")]
        public string Code { get; set; }

        [Column("clicks")]
        public int Clicks { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
