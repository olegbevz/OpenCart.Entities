namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_location")]
    public class Location : IEntityWithName
    {
        [Key]
        [Column("location_id")]
        public int Id { get; protected set; }

        [Required]
        [StringLength(32)]
        [Column("name")]
        public string Name { get; set; }

        [Column("address", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Address { get; set; }

        [Required]
        [StringLength(32)]
        [Column("telephone")]
        public string Telephone { get; set; }

        [Required]
        [StringLength(32)]
        [Column("fax")]
        public string Fax { get; set; }

        [Required]
        [StringLength(32)]
        [Column("geocode")]
        public string Geocode { get; set; }

        [StringLength(255)]
        [Column("image")]
        public string Image { get; set; }

        [Column("open", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Open { get; set; }

        [Column("comment", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Comment { get; set; }
    }
}
