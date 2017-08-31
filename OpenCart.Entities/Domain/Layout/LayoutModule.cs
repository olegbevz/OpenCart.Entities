namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_layout_module")]
    public class LayoutModule
    {
        [Key]
        [Column("layout_module_id")]
        public int Id { get; protected set; }

        [Column("layout_id")]
        public int LayoutId { get; set; }

        public virtual Layout Layout { get; set; }

        [Required]
        [StringLength(64)]
        [Column("code")]
        public string Code { get; set; }

        [Required]
        [StringLength(14)]
        [Column("position")]
        public string Position { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }
    }
}
