namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_menu_description")]
    public class MenuDescription : Localizable, IEntityWithName
    {
        [Key]
        [Column("menu_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MenuId { get; set; }

        [Required]
        [StringLength(64)]
        [Column("name")]
        public string Name { get; set; }
    }
}
