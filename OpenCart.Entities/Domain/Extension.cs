namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_extension")]
    public class Extension
    {
        [Key]
		[Column("extension_id")]
        public int extension_id { get; set; }

        [Required]
        [StringLength(32)]
		[Column("type")]
        public string type { get; set; }

        [Required]
        [StringLength(32)]
        [Column("code")]
        public string Code { get; set; }
    }
}
