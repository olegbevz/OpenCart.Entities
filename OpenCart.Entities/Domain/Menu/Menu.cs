namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_menu")]
    public class Menu
    {
        [Key]
        public int menu_id { get; set; }

        public int store_id { get; set; }

        [Required]
        [StringLength(6)]
        public string type { get; set; }

        [Required]
        [StringLength(255)]
        public string link { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }

        [Column("status")]
        public bool Status { get; set; }
    }
}
