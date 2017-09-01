namespace OpenCart.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_stock_status")]
    public class StockStatus : IEntityWithName
    {
        [Key, Column("stock_status_id", Order = 0)]
        public int Id { get; protected set; }

        [Required, StringLength(32), Column("name")]
        public string Name { get; set; }
        
        [Column("language_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LanguageId { get; set; }

        public virtual Language Language { get; set; }
    }
}
