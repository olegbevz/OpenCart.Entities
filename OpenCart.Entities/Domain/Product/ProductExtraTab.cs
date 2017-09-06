namespace OpenCart.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_product_extra_tabs")]
    public class ProductExtraTab : ILocalizable
    {
        public ProductExtraTab()
        {
        }

        public ProductExtraTab(ExtraTab extraTab, Language language, string text)
        {
            ExtraTabId = extraTab.Id;
            ExtraTab = extraTab;
            LanguageId = language.Id;
            Text = text;
        }

        [Key, Column("product_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        [Key, Column("extra_tab_id", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ExtraTabId { get; set; }

        [Key]
        [Column("language_id", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LanguageId { get; set; }

        public virtual Language Language { get; set; }

        public virtual ExtraTab ExtraTab { get; set; }

        [Column("text", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Text { get; set; }
    }
}
