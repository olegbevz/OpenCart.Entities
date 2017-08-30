namespace OpenCart.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_store")]
    public class Store : IEntityWithName
    {
        [Key, Column("store_id")]
        public int Id { get; protected set; }

        [Required, StringLength(64), Column("name")]
        public string Name { get; set; }

        [Required, StringLength(255), Column("url")]
        public string Url { get; set; }

        [Required, StringLength(255), Column("ssl")]
        public string Ssl { get; set; }

        public virtual ICollection<Product> Products { get; protected set; }
    }
}
