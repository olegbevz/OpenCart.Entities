namespace OpenCart.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_product_image")]
    public class ProductImage
    {
        public ProductImage(string image, int sortOrder)
        {
            Image = image;
            SortOrder = sortOrder;
        }

        public ProductImage()
        {
        }

        [Key, Column("product_image_id")]
        public int Id { get; protected set; }

        [Column("product_id")]
        public int ProductId { get; protected set; }

        [StringLength(255), Column("image")]
        public string Image { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }

        public virtual Product Product { get; protected set; }
    }
}
