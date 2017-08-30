namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    [Table("oc_product")]
    public class Product : IEntityWithStatus
    {
        public Product()
        {
            Categories = new HashSet<ProductToCategory>();
            Descriptions = new HashSet<ProductDescription>();
            Images = new HashSet<ProductImage>();
            Attributes = new HashSet<ProductAttribute>();
            Stores = new HashSet<Store>();
            Layouts = new HashSet<ProductToLayout>();
            RelatedProducts = new HashSet<Product>();
            ExtraTabs = new HashSet<ProductExtraTab>();
        }

        [Key, Column("product_id")]
        public int Id { get; protected set; }

        [Required, StringLength(64), Column("model")]
        public string Model { get; set; }

        [Required(AllowEmptyStrings = true), StringLength(64), Column("sku")]
        public string SKU { get; set; }

        [Required(AllowEmptyStrings = true), StringLength(12), Column("upc")]
        public string UPC { get; set; }

        [Required(AllowEmptyStrings = true), StringLength(14), Column("ean")]
        public string EAN { get; set; }

        [Required(AllowEmptyStrings = true), StringLength(13), Column("jan")]
        public string JAN { get; set; }

        [Required(AllowEmptyStrings = true), StringLength(17), Column("isbn")]
        public string ISBN { get; set; }

        [Required(AllowEmptyStrings = true), StringLength(64), Column("mpn")]
        public string MPN { get; set; }

        [Required(AllowEmptyStrings = true), StringLength(128), Column("location")]
        public string Location { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("stock_status_id")]
        public int StockStatusId { get; set; }

        [StringLength(255), Column("image")]
        public string Image { get; set; }

        [Column("manufacturer_id")]
        public int ManufacturerId { get; set; }

        [Column("shipping")]
        public bool Shipping { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("points")]
        public int Points { get; set; }

        [Column("tax_class_id")]
        public int TaxClassId { get; set; }

        [Column("date_available", TypeName = "date")]
        public DateTime DateAvailable { get; set; }

        [Column("weight")]
        public decimal Weight { get; set; }

        [Column("weight_class_id")]
        public int WeightUnitId { get; set; }

        [Column("length")]
        public decimal Length { get; set; }

        [Column("width")]
        public decimal Width { get; set; }

        [Column("height")]
        public decimal Height { get; set; }

        [Column("length_class_id")]
        public int LengthUnitId { get; set; }

        [Column("subtract")]
        public bool Subtract { get; set; }

        [Column("minimum")]
        public int Minimum { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        [Column("viewed")]
        public int Viewed { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }

        [Column("date_modified")]
        public DateTime DateModified { get; set; }

        [Required(AllowEmptyStrings = true), StringLength(65535), Column("product_stickers", TypeName = "text")]
        public string Stickers { get; set; }

        public virtual Manufacturer Manufacturer { get; protected set; }

        public virtual WeightClass WeightUnit { get; protected set; }

        public virtual LengthClass LengthUnit { get; protected set; }

        public virtual ICollection<ProductDescription> Descriptions { get; protected set; }

        public virtual ICollection<ProductImage> Images { get; protected set; }

        public virtual ICollection<ProductAttribute> Attributes { get; protected set; }

        public virtual ICollection<ProductToCategory> Categories { get; protected set; }

        public virtual ICollection<Store> Stores { get; protected set; }

        public virtual ICollection<ProductToLayout> Layouts { get; protected set; }

        public virtual ICollection<Product> RelatedProducts { get; protected set; }

        public virtual ICollection<ProductExtraTab> ExtraTabs { get; protected set; }

        public ProductDescription GetDescription(Language language)
        {
            return Descriptions.FirstOrDefault(x => x.LanguageId == language.Id);
        }

        public void SetDescription(Language language, ProductDescription description)
        {
            var existionDescription = Descriptions.FirstOrDefault(x => x.LanguageId == language.Id);
            if (existionDescription != null)
            {
                existionDescription.MetaTitle = description.MetaTitle;
                existionDescription.Name = description.Name;
                existionDescription.Tag = description.Tag;
                existionDescription.MetaH1 = description.MetaH1;
                existionDescription.MetaKeyword = description.MetaKeyword;
                existionDescription.MetaDescription = description.MetaDescription;
                existionDescription.Description = description.Description;
            }
            else
            {
                description.LanguageId = language.Id;
                Descriptions.Add(description);
            }
        }
    }
}
