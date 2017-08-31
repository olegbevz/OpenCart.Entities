namespace OpenCart.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_extra_tabs_description")]
    public class ExtraTabDescription : Localizable, IEntityWithTitle
    {
        public ExtraTabDescription(string title, Language language, ExtraTab extraTab)
        {
            ExtraTabId = extraTab.Id;
            ExtraTab = extraTab;

            LanguageId = language.Id;

            Title = title;
        }

        public ExtraTabDescription()
        {
        }

        [Key, Column("extra_tab_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ExtraTabId { get; protected set; }

        public virtual ExtraTab ExtraTab { get; set; }

        [Column("title", TypeName = "text"), Required, StringLength(65535)]
        public string Title { get; set; }
    }
}
