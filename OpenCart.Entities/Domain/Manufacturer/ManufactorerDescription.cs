namespace JustWatch.OpenCart
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_manufacturer_description")]
    public class ManufacturerDescription : MetaDescriptionBase
    {
        [Key, Column("manufacturer_id", Order=0), DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ManufacturerId { get; set; }
    }
}
