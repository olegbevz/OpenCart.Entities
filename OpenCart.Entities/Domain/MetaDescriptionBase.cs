using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenCart.Entities
{
    public abstract class MetaDescriptionBase : Localizable, IEntityWithName
    {

        [Required, StringLength(255), Column("name")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = true), StringLength(65535), Column("description", TypeName = "text")]
        public string Description { get; set; }

        [Required, StringLength(255), Column("meta_title")]
        public string MetaTitle { get; set; }

        [Required, StringLength(255), Column("meta_h1")]
        public string MetaH1 { get; set; }

        [Required(AllowEmptyStrings = true), StringLength(255), Column("meta_description")]
        public string MetaDescription { get; set; }

        [Required, StringLength(255), Column("meta_keyword")]
        public string MetaKeyword { get; set; }
    }
}
