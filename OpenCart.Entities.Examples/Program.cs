using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Reflection;
using OpenCart.Entities.Tests;

namespace OpenCart.Entities.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var openCartDomain = new OpenCartDomain())
                {
                    //var products = openCartDomain.Products.Include("Manufacturer")
                    //    .Where(product => product.Manufacturer.Name == "Casio")
                    //    .ToArray();

                    TryToAccessAllEntities(openCartDomain);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void TryToAccessAllEntities(OpenCartDomain openCartDomain)
        {
            var alreadyVisitedEntities = new List<Type>();

            foreach (var property in openCartDomain.GetType().GetProperties()
                .Where(property => property.PropertyType.IsGeneric(typeof(DbSet<>))))
            {
                var entityCollection = GetPropertyValue(property, openCartDomain) as IEnumerable;
                if (entityCollection == null)
                    throw new Exception($"Could not get IEnumerable domain from property {property.Name}");

                var enumerator = entityCollection.GetEnumerator();
                if (!enumerator.MoveNext())
                    continue;

                var entity = enumerator.Current;
                if (entity == null)
                    throw new Exception($"Could not get first entity from property {property.Name}");

                TryToAccessAllEntities(entity, alreadyVisitedEntities);
            }
        }

        private static void TryToAccessAllEntities(object entity, List<Type> alreadyVisitedEntities)
        {
            var entityType = entity.GetType();

            if (alreadyVisitedEntities.Contains(entityType))
                return;

            alreadyVisitedEntities.Add(entityType);

            foreach (var entityProperty in entityType.GetProperties())
            {
                if (entityProperty.PropertyType.Assembly == typeof(OpenCartDomain).Assembly)
                {
                    var propertyValue = GetPropertyValue(entityProperty, entity);
                    if (propertyValue == null)
                        continue;

                    TryToAccessAllEntities(propertyValue, alreadyVisitedEntities);
                }

                if (entityProperty.PropertyType.IsGeneric(typeof(ICollection<>)))
                {
                    var underlyingType = entityProperty.PropertyType.GetGenericArguments().FirstOrDefault();
                    if (underlyingType == null)
                        throw new Exception($"Could not get underlying type for {entityType.Name}.{entityProperty.Name}");

                    var entityCollection = GetPropertyValue(entityProperty, entity) as IEnumerable;
                    if (entityCollection == null)
                        throw new Exception($"Could not get collection from property {entityProperty.Name}");

                    var enumerator = entityCollection.GetEnumerator();
                    if (!enumerator.MoveNext())
                        continue;

                    var childEntity = enumerator.Current;
                    if (childEntity == null)
                        throw new Exception($"Could not get first entity from property {entityProperty.Name}");

                    TryToAccessAllEntities(childEntity, alreadyVisitedEntities);
                }
            }
        }

        public static object GetPropertyValue(PropertyInfo property, object obj)
        {
            try
            {
                return property.GetGetMethod().Invoke(obj, new object[0]);
            }
            catch (Exception ex)
            {
                throw new Exception($"Could not access property {property.DeclaringType.Name}.{property.Name}", ex);
            }
        }
    }
}
