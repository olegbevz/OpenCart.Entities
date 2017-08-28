namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_modification")]
    public class Modification : IEntityWithName, IEntityWithStatus
    {
        [Key]
        public int modification_id { get; set; }

        [Required]
        [StringLength(64)]
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [StringLength(64)]
        [Column("code")]
        public string Code { get; set; }

        [Required]
        [StringLength(64)]
        public string author { get; set; }

        [Required]
        [StringLength(32)]
        public string version { get; set; }

        [Required]
        [StringLength(255)]
        public string link { get; set; }

        [Required]
        [StringLength(16777215)]
        public string xml { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
