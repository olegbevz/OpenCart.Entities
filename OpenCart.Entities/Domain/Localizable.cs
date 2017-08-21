using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JustWatch.OpenCart
{
    public abstract class Localizable
    {
        [Key]
        [Column("language_id", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LanguageId { get; set; }
    }
}
