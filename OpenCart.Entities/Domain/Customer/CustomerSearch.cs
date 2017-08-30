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
        public int Id { get; set; }

        [Column("store_id")]
        public int StoreId { get; set; }

        [Column("language_id")] public int LanguageId { get; set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(255)]
        [Column("keyword")]
        public string Keyword { get; set; }

        [Column("category_id")]
        public int? CategoryId { get; set; }

        public bool sub_category { get; set; }

        public bool description { get; set; }

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
