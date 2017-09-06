namespace OpenCart.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_store")]
    public class Store : IEntityWithName
    {
        [Key, Column("store_id")]
        public int Id { get; protected set; }

        [Required, StringLength(64), Column("name")]
        public string Name { get; set; }

        [Required, StringLength(255), Column("url")]
        public string Url { get; set; }

        [Required, StringLength(255), Column("ssl")]
        public string Ssl { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();

        public virtual ICollection<ProductToLayout> ProductLayouts { get; set; } = new HashSet<ProductToLayout>();

        public virtual ICollection<Customer> Customers { get;set; } = new HashSet<Customer>();

        public virtual ICollection<CustomerSearch> CustomerSearches { get; set; } = new HashSet<CustomerSearch>();

        public virtual ICollection<LayoutRoute> LayoutRoutes { get; set; } = new HashSet<LayoutRoute>();

        public virtual ICollection<Menu> Menus { get; set; } = new HashSet<Menu>();

        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();

        public virtual ICollection<Setting> Settings { get; set; } = new HashSet<Setting>();

        public virtual ICollection<Theme> Themes { get; set; } = new HashSet<Theme>();

        public virtual ICollection<Translation> Translations { get; set; } = new HashSet<Translation>();

        public virtual ICollection<BlogToLayout> Blogs { get; set; } = new HashSet<BlogToLayout>();

        public virtual ICollection<CategoryToLayout> Categories { get; set; } = new HashSet<CategoryToLayout>();

        public virtual ICollection<InformationToLayout> Informations { get; set; } = new HashSet<InformationToLayout>();
    }
}
