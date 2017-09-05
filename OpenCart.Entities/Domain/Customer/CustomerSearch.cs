namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_customer_search")]
    public class CustomerSearch
    {
        [Key]
        [Column("customer_search_id")]
        public int Id { get; protected set; }

        [Column("store_id")]
        public int StoreId { get; set; }

        public virtual Store Store { get; set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        [Column("language_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LanguageId { get; set; }

        public virtual Language Language { get; set; }

        [Required]
        [StringLength(255)]
        [Column("keyword")]
        public string Keyword { get; set; }

        [Column("category_id")]
        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }

        [Column("sub_category")]
        public bool SubCategory { get; set; }

        [Column("description")]
        public bool Description { get; set; }

        [Column("products")]
        public int Products { get; set; }

        [Required]
        [StringLength(40)]
        [Column("ip")]
        public string Ip { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
