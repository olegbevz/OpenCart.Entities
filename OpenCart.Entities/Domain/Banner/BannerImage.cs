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
		[Column("banner_image_id")]
        public int banner_image_id { get; set; }

		[Column("banner_id")]
        public int banner_id { get; set; }

        [Column("language_id")]
        public int LanguageId { get; set; }

        [Required]
        [StringLength(64)]
		[Column("title")]
        public string title { get; set; }

        [Required]
        [StringLength(255)]
		[Column("link")]
        public string link { get; set; }

        [Required]
        [StringLength(255)]
		[Column("image")]
        public string image { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }
    }
}
