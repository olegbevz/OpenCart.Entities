namespace OpenCart.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_url_alias")]
    public class UrlAlias
    {
        public UrlAlias()
        {
        }

        public UrlAlias(string query, string keyword)
        {
            Query = query;
            Keyword = keyword;
        }

        [Key, Column("url_alias_id")]
        public int Id { get; protected set; }

        [Required, StringLength(255), Column("query")]
        public string Query { get; set; }

        [Required, StringLength(255), Column("keyword")]
        public string Keyword { get; set; }
    }
}
