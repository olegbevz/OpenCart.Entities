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
        public int Id { get; protected set; }

        [Column("store_id")]
        public int StoreId { get; set; }

        [Required]
        [StringLength(6)]
        [Column("type")]
        public string Type { get; set; }

        [Required]
        [StringLength(255)]
        [Column("link")]
        public string Link { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }

        [Column("status")]
        public bool Status { get; set; }
    }
}
