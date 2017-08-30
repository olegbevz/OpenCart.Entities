namespace OpenCart.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_user_group")]
    public class UserGroup : IEntityWithName
    {
        [Key, Column("user_group_id")]
        public int Id { get; protected set; }

        [Required, StringLength(64), Column("name")]
        public string Name { get; set; }

        [Required, StringLength(65535), Column("permission", TypeName = "text")]
        public string Permissions { get; set; }

        public virtual ICollection<User> Users { get; protected set; }
    }
}
