namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_setting")]
    public class Setting
    {
        [Key]
		[Column("setting_id")]
        public int setting_id { get; set; }

		[Column("store_id")]
        public int store_id { get; set; }

        [Required]
        [StringLength(32)]
        [Column("code")]
        public string Code { get; set; }

        [Required]
        [StringLength(64)]
		[Column("key")]
        public string key { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string value { get; set; }

        public bool serialized { get; set; }
    }
}
