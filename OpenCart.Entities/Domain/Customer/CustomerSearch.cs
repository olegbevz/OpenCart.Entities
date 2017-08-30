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
        public int customer_search_id { get; set; }

		[Column("store_id")]
        public int store_id { get; set; }

        [Column("language_id")] public int LanguageId { get; set; }

		[Column("customer_id")]
        public int customer_id { get; set; }

        [Required]
        [StringLength(255)]
		[Column("keyword")]
        public string keyword { get; set; }

		[Column("category_id")]
        public int? category_id { get; set; }

        public bool sub_category { get; set; }

        public bool description { get; set; }

		[Column("products")]
        public int products { get; set; }

        [Required]
        [StringLength(40)]
		[Column("ip")]
        public string ip { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
