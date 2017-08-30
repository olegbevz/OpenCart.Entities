namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_translation")]
    public class Translation
    {
        [Key]
		[Column("translation_id")]
        public int translation_id { get; set; }

		[Column("store_id")]
        public int store_id { get; set; }

        [Column("language_id")]
        public int LanguageId { get; set; }

        [Required]
        [StringLength(64)]
		[Column("route")]
        public string route { get; set; }

        [Required]
        [StringLength(64)]
		[Column("key")]
        public string key { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string value { get; set; }
    }
}
