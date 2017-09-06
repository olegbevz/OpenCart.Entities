namespace OpenCart.Entities
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_category")]
    public class Category : IEntityWithStatus
    {
        [Key, Column("category_id")]
        public int Id { get; protected set; }

        [StringLength(255), Column("image")]
        public string Image { get; set; }

        [Column("parent_id")]
        public int ParentCategoryId { get; set; }

        public virtual Category ParentCategory { get; set; }

        [Column("top")]
        public bool Top { get; set; }

        [Column("column")]
        public int Column { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }

        [Column("date_modified")]
        public DateTime DateModified { get; set; }

        public virtual ICollection<Category> Categories { get; set; } = new HashSet<Category>();

        public virtual ICollection<ProductToCategory> Products { get; set; } = new HashSet<ProductToCategory>();

        public virtual ICollection<CategoryDescription> Descriptions { get; set; } = new HashSet<CategoryDescription>();

        public virtual ICollection<Filter> Filters { get; set; } = new HashSet<Filter>();

        public virtual ICollection<Coupon> Coupons { get; set; } = new HashSet<Coupon>();

        public virtual ICollection<Store> Stores { get; set; } = new HashSet<Store>();

        public virtual ICollection<CustomerSearch> Searches { get; set; } = new HashSet<CustomerSearch>();

        public virtual ICollection<CategoryPath> Paths { get; set; } = new HashSet<CategoryPath>();

        public virtual ICollection<CategoryToLayout> Layouts { get; set; } = new HashSet<CategoryToLayout>();
    }
}
