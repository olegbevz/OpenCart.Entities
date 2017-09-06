namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_customer_group")]
    public class CustomerGroup
    {
        [Key]
        [Column("customer_group_id")]
        public int Id { get; protected set; }

        [Column("approval")]
        public int Approval { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }

        public virtual ICollection<Customer> Customers { get; set; } = new HashSet<Customer>();

        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();

        public virtual ICollection<ProductDiscount> Discounts { get; set; } = new HashSet<ProductDiscount>();

        public virtual ICollection<ProductReward> Rewards { get; set; } = new HashSet<ProductReward>();

        public virtual ICollection<ProductSpecial> Specials { get; set; } = new HashSet<ProductSpecial>();

        public virtual ICollection<CustomerGroupDescription> Descriptions { get; set; } = new HashSet<CustomerGroupDescription>();

        public virtual ICollection<CustomFieldCustomerGroup> CustomFields { get; set; } = new HashSet<CustomFieldCustomerGroup>();

        public virtual ICollection<ProductRecurring> ProductRecurrings { get; set; } = new HashSet<ProductRecurring>();
    }
}
