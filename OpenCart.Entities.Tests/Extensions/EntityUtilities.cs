using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;

namespace OpenCart.Entities.Tests.Extensions
{
    public static class EntityUtilities
    {
        public static bool IsEntity(Type type)
        {
            return !type.IsInterface && type != typeof(OpenCartDomain) && !type.IsAbstract && type.IsPublic;
        }

        public static bool IsColumnProperty(PropertyInfo property)
        {
            return !IsForeignKeyProperty(property) &&
                !IsNavigationProperty(property) &&
                !IsCollectionProperty(property) &&
                !IsPrimaryKeyProperty(property);
        }

        public static bool IsForeignKeyProperty(PropertyInfo property)
        {
            return (property.PropertyType == typeof(int) || property.PropertyType == typeof(long)) &&
                   property.Name.EndsWith("Id") &&
                   !IsPrimaryKeyProperty(property);
        }

        public static bool IsPrimaryKeyProperty(PropertyInfo property)
        {
            return (property.PropertyType == typeof(int) || property.PropertyType == typeof(long)) &&
                   (property.Name == "Id");
        }

        public static bool IsNavigationProperty(PropertyInfo property)
        {
            return property.PropertyType.Assembly == typeof(OpenCartDomain).Assembly;
        }

        public static bool IsCollectionProperty(PropertyInfo property)
        {
            return property.PropertyType.IsGeneric(typeof(ICollection<>));
        }

        public static bool IsCollectionProperty(PropertyInfo property, Type type)
        {
            return property.PropertyType.IsGeneric(typeof(ICollection<>), type);
        }

        public static IEnumerable<Type> GetEntityChildren(Type entity)
        {
            foreach (var navigationProperty in entity.GetProperties().Where(IsNavigationProperty))
            {
                yield return navigationProperty.PropertyType;
            }

            foreach (var collectionProperty in entity.GetProperties().Where(IsCollectionProperty))
            {
                var underlyingType = collectionProperty.PropertyType.GetGenericArguments().FirstOrDefault();
                if (underlyingType == null)
                    throw new Exception($"Could not get entity type from property '{entity.Name}.{collectionProperty.Name}'");

                yield return underlyingType;
            }
        }

        public static IEnumerable<Type> GetEntities()
        {
            return typeof(OpenCartDomain).Assembly.GetTypes()
                .Where(IsEntity);
        }

        public static bool IsMapping(Type type)
        {
            return type.BaseType != null && type.BaseType.IsGeneric(typeof(EntityTypeConfiguration<>));
        }
    }
}
