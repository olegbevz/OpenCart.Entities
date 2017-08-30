namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_option_value")]
    public class OptionValue
    {
        [Key]
		[Column("option_value_id")]
        public int option_value_id { get; set; }

		[Column("option_id")]
        public int option_id { get; set; }

        [Required]
        [StringLength(255)]
		[Column("image")]
        public string image { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }
    }
}
