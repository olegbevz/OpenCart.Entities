namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_module")]
    public class Module : IEntityWithName
    {
        [Key]
        [Column("module_id")]
        public int Id { get; protected set; }

        [Required]
        [StringLength(64)]
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [StringLength(32)]
        [Column("code")]
        public string Code { get; set; }

        [Column("setting", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Setting { get; set; }
    }
}
