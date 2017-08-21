namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_layout_module")]
    public class oc_layout_module
    {
        [Key]
        public int layout_module_id { get; set; }

        public int layout_id { get; set; }

        [Required]
        [StringLength(64)]
        [Column("code")]
        public string Code { get; set; }

        [Required]
        [StringLength(14)]
        public string position { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }
    }
}
