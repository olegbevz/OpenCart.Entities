namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_theme")]
    public class Theme
    {
        [Key]
        public int theme_id { get; set; }

        public int store_id { get; set; }

        [Required]
        [StringLength(64)]
        public string theme { get; set; }

        [Required]
        [StringLength(64)]
        public string route { get; set; }

        [Column("code", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Code { get; set; }
    }
}
