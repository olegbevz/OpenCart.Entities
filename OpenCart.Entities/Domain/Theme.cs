namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_theme")]
    public class Theme : IEntityWithName
    {
        [Key]
        [Column("theme_id")]
        public int ThemeId { get; set; }

        [Column("store_id")]
        public int StoreId { get; set; }

        [Required]
        [StringLength(64)]
        [Column("theme")]
        public string Name { get; set; }

        [Required]
        [StringLength(64)]
        [Column("route")]
        public string Route { get; set; }

        [Column("code", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Code { get; set; }
    }
}
