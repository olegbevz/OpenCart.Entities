namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_location")]
    public class oc_location
    {
        [Key]
        public int location_id { get; set; }

        [Required]
        [StringLength(32)]
        [Column("name")]
        public string Name { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string address { get; set; }

        [Required]
        [StringLength(32)]
        public string telephone { get; set; }

        [Required]
        [StringLength(32)]
        public string fax { get; set; }

        [Required]
        [StringLength(32)]
        public string geocode { get; set; }

        [StringLength(255)]
        public string image { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string open { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string comment { get; set; }
    }
}
