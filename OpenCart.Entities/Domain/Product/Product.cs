namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_product")]
    public class Product : IEntityWithStatus
    {
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

        public virtual Manufacturer Manufacturer { get; set; }

        public virtual WeightClass WeightUnit { get; set; }

        public virtual LengthClass LengthUnit { get; set; }

        public virtual StockStatus StockStatus { get; set; }

        public virtual TaxClass TaxClass { get; set; }

        public virtual ICollection<ProductDescription> Descriptions { get; set; } = new HashSet<ProductDescription>();

        public virtual ICollection<ProductImage> Images { get; set; } = new HashSet<ProductImage>();

        public virtual ICollection<ProductAttribute> Attributes { get; set; } = new HashSet<ProductAttribute>();

        public virtual ICollection<ProductToCategory> Categories { get; set; } = new HashSet<ProductToCategory>();

        public virtual ICollection<Store> Stores { get; set; } = new HashSet<Store>();

        public virtual ICollection<ProductToLayout> Layouts { get; set; } = new HashSet<ProductToLayout>();

        public virtual ICollection<Product> RelatedProducts { get; set; } = new HashSet<Product>();

        public virtual ICollection<ProductExtraTab> ExtraTabs { get; set; } = new HashSet<ProductExtraTab>();

        public virtual ICollection<Filter> Filters { get; set; } = new HashSet<Filter>();

        public virtual ICollection<Download> Downloads { get; set; } = new HashSet<Download>();

        public virtual ICollection<Coupon> Coupons { get; set; } = new HashSet<Coupon>();

        public virtual ICollection<OrderProduct> Orders { get; set; } = new HashSet<OrderProduct>();

        public virtual ICollection<OrderRecurring> OrderRecurrings { get; set; } = new HashSet<OrderRecurring>();

        public virtual ICollection<ProductDiscount> Discounts { get; set; } = new HashSet<ProductDiscount>();

        public virtual ICollection<ProductOption> Options { get; set; } = new HashSet<ProductOption>();

        public virtual ICollection<ProductOptionValue> OptionValues { get; set; } = new HashSet<ProductOptionValue>();

        public virtual ICollection<ProductReward> Rewards { get; set; } = new HashSet<ProductReward>();

        public virtual ICollection<ProductSpecial> Specials { get; set; } = new HashSet<ProductSpecial>();

        public virtual ICollection<Return> Returns { get; set; } = new HashSet<Return>();

        public virtual ICollection<Review> Reviews { get; set; } = new HashSet<Review>();

        public virtual ICollection<CustomerWishlist> CustomerWishlists { get; set; } = new HashSet<CustomerWishlist>();

        public virtual ICollection<ProductImageByOption> ImagesByOption { get; set; } = new HashSet<ProductImageByOption>();

        public virtual ICollection<ProductRecurring> ProductRecurrings { get; set; } = new HashSet<ProductRecurring>();
    }
}
