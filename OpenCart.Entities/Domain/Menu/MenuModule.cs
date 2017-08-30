namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_menu_module")]
    public class MenuModule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("menu_module_id")]
        public int Id { get; set; }

        [Column("menu_id")]
        public int MenuId { get; set; }

        [Required]
        [StringLength(64)]
        [Column("code")]
        public string Code { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }
    }
}
