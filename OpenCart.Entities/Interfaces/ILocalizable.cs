namespace OpenCart.Entities
{
    public interface ILocalizable
    {
        Language Language { get; set; }

        int LanguageId { get; set; }
    }
}