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
        public int TranslationId { get; set; }

        [Column("store_id")]
        public int StoreId { get; set; }

        [Column("language_id")]
        public int LanguageId { get; set; }

        [Required]
        [StringLength(64)]
        [Column("route")]
        public string Route { get; set; }

        [Required]
        [StringLength(64)]
        [Column("key")]
        public string Key { get; set; }

        [Column("value", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Value { get; set; }
    }
}
