namespace OpenCart.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_attribute_group")]
    public class AttributeGroup
    {
        [Key, Column("attribute_group_id")]
        public int Id { get; protected set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }

        public virtual ICollection<Attribute> Attributes { get; protected set; }

        public virtual ICollection<AttributeGroupDescription> Descriptions { get; protected set; }
    }
}
