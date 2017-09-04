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

        public virtual ICollection<Product> Products { get; set; }

        public virtual ICollection<Customer> Customers { get;set; }

        public virtual ICollection<CustomerSearch> CustomerSearches { get; set; }

        public virtual ICollection<LayoutRoute> LayoutRoutes { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<Setting> Settings { get; set; }

        public virtual ICollection<Theme> Themes { get; set; }

        public virtual ICollection<Translation> Translations { get; set; }
    }
}
