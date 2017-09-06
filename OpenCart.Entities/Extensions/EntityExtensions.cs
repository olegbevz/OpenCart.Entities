using System.Collections.Generic;
using System.Linq;

namespace OpenCart.Entities.Extensions
{
    public static class EntityExtensions
    {
        #region IEntityWithStatus

        public static void Enable(this IEntityWithStatus entityWithStatus)
        {
            entityWithStatus.Status = true;
        }

        public static void Disable(this IEntityWithStatus entityWithStatus)
        {
            entityWithStatus.Status = false;
        }

        #endregion

        #region IEntityWithName

        public static string GetName<T>(this IEnumerable<T> entities, Language language) where T : IEntityWithName, ILocalizable
        {
            return GetName(entities, language.Id);
        }

        public static string GetName<T>(this IEnumerable<T> entities, int languageId) where T : IEntityWithName, ILocalizable
        {
            return entities.FirstOrDefault(x => x.LanguageId == languageId)?.Name;
        }

        public static T FindByName<T>(this IEnumerable<T> entities, string name, Language language) where T : IEntityWithName, ILocalizable
        {
            return FindByName(entities, name, language.Id);
        }

        public static T FindByName<T>(this IEnumerable<T> entities, string name, int languageId) where T : IEntityWithName, ILocalizable
        {
            return entities.FirstOrDefault(x => x.Name == name && x.LanguageId == languageId);
        }

        public static T FindByName<T>(this IEnumerable<T> entities, string name) where T : IEntityWithName
        {
            return entities.FirstOrDefault(x => x.Name == name);
        }

        #endregion

        #region IEntityWithTitle

        public static string GetTitle<T>(this IEnumerable<T> entities, Language language) where T : IEntityWithTitle, ILocalizable
        {
            return GetTitle(entities, language.Id);
        }

        public static string GetTitle<T>(this IEnumerable<T> entities, int languageId) where T : IEntityWithTitle, ILocalizable
        {
            return entities.FirstOrDefault(x => x.LanguageId == languageId)?.Title;
        }

        public static T FindByTitle<T>(this IEnumerable<T> entities, string name, Language language) where T : IEntityWithTitle, ILocalizable
        {
            return FindByTitle(entities, name, language.Id);
        }

        public static T FindByTitle<T>(this IEnumerable<T> entities, string name, int languageId) where T : IEntityWithTitle, ILocalizable
        {
            return entities.FirstOrDefault(x => x.Title == name && x.LanguageId == languageId);
        }

        public static T FindByTitle<T>(this IEnumerable<T> entities, string name) where T : IEntityWithTitle
        {
            return entities.FirstOrDefault(x => x.Title == name);
        }

        #endregion
    }
}
