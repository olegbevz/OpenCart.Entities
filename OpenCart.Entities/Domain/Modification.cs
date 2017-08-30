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
        [Column("modification_id")]
        public int Id { get; protected set; }

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
        [Column("author")]
        public string Author { get; set; }

        [Required]
        [StringLength(32)]
        [Column("version")]
        public string Version { get; set; }

        [Required]
        [StringLength(255)]
        [Column("link")]
        public string Link { get; set; }

        [Required]
        [StringLength(16777215)]
        [Column("xml")]
        public string Xml { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
