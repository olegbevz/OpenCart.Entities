namespace JustWatch.OpenCart
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_ocfilter_page")]
    public class oc_ocfilter_page
    {
        [Key]
        public int ocfilter_page_id { get; set; }

        public int category_id { get; set; }

        [Required]
        [StringLength(255)]
        public string ocfilter_params { get; set; }

        [Required]
        [StringLength(255)]
        public string meta_title { get; set; }

        [Required]
        [StringLength(255)]
        public string meta_keyword { get; set; }

        [Required]
        [StringLength(255)]
        public string meta_description { get; set; }

        [Column("description", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Description { get; set; }

        [Required]
        [StringLength(255)]
        public string title { get; set; }

        [Required]
        [StringLength(255)]
        public string keyword { get; set; }

        [Column("status")]
        public bool Status { get; set; }
    }
}
