namespace JustWatch.OpenCart
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_menu_module")]
    public class oc_menu_module
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int menu_module_id { get; set; }

        public int menu_id { get; set; }

        [Required]
        [StringLength(64)]
        [Column("code")]
        public string Code { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }
    }
}
