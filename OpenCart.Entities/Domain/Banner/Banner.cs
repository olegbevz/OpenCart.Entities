namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_banner")]
    public class Banner : IEntityWithName, IEntityWithStatus
    {
        [Key]
        [Column("banner_id")]
        public int Id { get; protected set; }

        [Required]
        [StringLength(64)]
        [Column("name")]
        public string Name { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        public virtual ICollection<BannerImage> Images { get; set; } = new HashSet<BannerImage>();
    }
}
