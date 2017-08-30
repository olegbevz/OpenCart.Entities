namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_blog_description")]
    public class BlogDescription : Localizable, IEntityWithTitle
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(64)]
        [Column("title")]
        public string Title { get; set; }

        [Column("description", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Description { get; set; }

        [Required]
        [StringLength(255)]
        [Column("meta_title")]
        public string MetaTitle { get; set; }

        [Required]
        [StringLength(255)]
        [Column("meta_description")]
        public string MetaDescription { get; set; }

        [Required]
        [StringLength(255)]
        [Column("meta_keyword")]
        public string MetaKeyword { get; set; }
    }
}
