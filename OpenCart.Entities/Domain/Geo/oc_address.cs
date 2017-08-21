namespace JustWatch.OpenCart
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_address")]
    public class oc_address
    {
        [Key]
        public int address_id { get; set; }

        public int customer_id { get; set; }

        [Required]
        [StringLength(32)]
        public string firstname { get; set; }

        [Required]
        [StringLength(32)]
        public string lastname { get; set; }

        [Required]
        [StringLength(40)]
        public string company { get; set; }

        [Required]
        [StringLength(128)]
        public string address_1 { get; set; }

        [Required]
        [StringLength(128)]
        public string address_2 { get; set; }

        [Required]
        [StringLength(128)]
        public string city { get; set; }

        [Required]
        [StringLength(10)]
        public string postcode { get; set; }

        public int country_id { get; set; }

        public int zone_id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string custom_field { get; set; }
    }
}
