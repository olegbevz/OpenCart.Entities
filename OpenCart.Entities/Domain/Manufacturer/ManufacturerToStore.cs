namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_manufacturer_to_store")]
    public class ManufacturerToStore
    {
        [Key]
        [Column("manufacturer_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ManufacturerId { get; set; }

        [Key]
        [Column("store_id", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreId { get; set; }
    }
}
