namespace JustWatch.OpenCart
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_module")]
    public class oc_module
    {
        [Key]
        public int module_id { get; set; }

        [Required]
        [StringLength(64)]
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [StringLength(32)]
        [Column("code")]
        public string Code { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string setting { get; set; }
    }
}
