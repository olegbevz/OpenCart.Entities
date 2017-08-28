namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_banner_image")]
    public class BannerImage
    {
        [Key]
        public int banner_image_id { get; set; }

        public int banner_id { get; set; }

        [Column("language_id")]
        public int LanguageId { get; set; }

        [Required]
        [StringLength(64)]
        public string title { get; set; }

        [Required]
        [StringLength(255)]
        public string link { get; set; }

        [Required]
        [StringLength(255)]
        public string image { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }
    }
}
