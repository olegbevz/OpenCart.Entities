namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_option")]
    public class Option
    {
        [Key]
        [Column("option_id")]
        public int OptionId { get; set; }

        [Required]
        [StringLength(32)]
        [Column("type")]
        public string Type { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }
    }
}
