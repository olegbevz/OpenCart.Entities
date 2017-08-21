namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_customer_search")]
    public class oc_customer_search
    {
        [Key]
        public int customer_search_id { get; set; }

        public int store_id { get; set; }

        [Column("language_id")]public int LanguageId { get; set; }

        public int customer_id { get; set; }

        [Required]
        [StringLength(255)]
        public string keyword { get; set; }

        public int? category_id { get; set; }

        public bool sub_category { get; set; }

        public bool description { get; set; }

        public int products { get; set; }

        [Required]
        [StringLength(40)]
        public string ip { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
