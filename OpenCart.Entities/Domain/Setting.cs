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
        public int Id { get; protected set; }

        [Column("store_id")]
        public int StoreId { get; set; }

        [Required]
        [StringLength(32)]
        [Column("code")]
        public string Code { get; set; }

        [Required]
        [StringLength(64)]
        [Column("key")]
        public string Key { get; set; }

        [Column("value", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Value { get; set; }

        public bool serialized { get; set; }
    }
}
