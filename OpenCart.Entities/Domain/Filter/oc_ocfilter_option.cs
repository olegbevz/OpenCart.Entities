namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_ocfilter_option")]
    public class oc_ocfilter_option
    {
        [Key]
        public int option_id { get; set; }

        [Required]
        [StringLength(16)]
        public string type { get; set; }

        [Required]
        [StringLength(255)]
        public string keyword { get; set; }

        public bool selectbox { get; set; }

        public sbyte grouping { get; set; }

        public bool color { get; set; }

        public bool image { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }
    }
}
