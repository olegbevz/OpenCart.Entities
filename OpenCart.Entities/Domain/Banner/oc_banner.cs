namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_banner")]
    public class oc_banner
    {
        [Key]
        public int banner_id { get; set; }

        [Required]
        [StringLength(64)]
        [Column("name")]
        public string Name { get; set; }

        [Column("status")]
        public bool Status { get; set; }
    }
}
