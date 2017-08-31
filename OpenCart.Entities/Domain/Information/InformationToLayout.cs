namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_information_to_layout")]
    public class InformationToLayout
    {
        [Key]
        [Column("information_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InformationId { get; set; }

        public virtual Information Information { get; set; }

        [Key]
        [Column("store_id", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreId { get; set; }

        public virtual Store Store { get; set; }

        [Column("layout_id")]
        public int LayoutId { get; set; }

        public virtual Layout Layout { get; set; }
    }
}
