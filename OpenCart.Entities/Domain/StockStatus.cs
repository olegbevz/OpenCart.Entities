namespace OpenCart.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_stock_status")]
    public class StockStatus : Localizable, IEntityWithName
    {
        [Key, Column("stock_status_id", Order = 0)]
        public int Id { get; protected set; }

        [Required, StringLength(32), Column("name")]
        public string Name { get; set; }
    }
}
