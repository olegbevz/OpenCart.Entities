namespace OpenCart.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_extra_tabs")]
    public class ExtraTab : IEntityWithStatus
    {
        [Key, Column("extra_tab_id")]
        public int Id { get; protected set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        public virtual ICollection<ExtraTabDescription> Descriptions { get; set; } 
    }
}
