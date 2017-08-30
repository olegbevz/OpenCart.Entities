namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_menu")]
    public class Menu : IEntityWithStatus
    {
        [Key]
		[Column("menu_id")]
        public int menu_id { get; set; }

		[Column("store_id")]
        public int store_id { get; set; }

        [Required]
        [StringLength(6)]
		[Column("type")]
        public string type { get; set; }

        [Required]
        [StringLength(255)]
		[Column("link")]
        public string link { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }

        [Column("status")]
        public bool Status { get; set; }
    }
}
