namespace OpenCart.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_product_to_layout")]
    public class ProductToLayout
    {
        public ProductToLayout()
        {
        }

        public ProductToLayout(Store store, Layout layout)
        {
            StoreId = store.Id;
            LayoutId = layout.Id;
        }

        [Key, Column("product_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; protected set; }

        public virtual Product Product { get; set; }

        [Key, Column("store_id", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreId { get; protected set; }

        public virtual Store Store { get; set; }

        [Column("layout_id")]
        public int LayoutId { get; protected set; }

        public virtual Layout Layout { get; set; }
    }
}
