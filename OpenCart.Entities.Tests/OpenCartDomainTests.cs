using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;

namespace OpenCart.Entities.Tests
{
    [TestFixture]
    public class OpenCartDomainTests
    {
        [TestCase]
        public void AllEntitiesShouldHaveNameInPascalConvention()
        {
            var entities = GetOpenCartEntities();

            foreach (var entity in entities)
            {
                Assert.IsTrue(
                    entity.Name.InPascal(), 
                    $"Type name '{entity.Name}' should be in pascal convention");
            }
        }

        [Test]
        public void AllEntitiesShouldHaveTheSameNameAsTable()
        {
            var entities = GetOpenCartEntities();

            foreach (var entity in entities)
            {
                var tableAttribute = entity.GetAttribute<TableAttribute>();

                if (tableAttribute != null)
                {
                    var tableName = tableAttribute.Name;
                    var expectedEntityName = GetEntityNameFromTableName(tableName);

                    if (expectedEntityName == "ExtraTabs")
                        expectedEntityName = "ExtraTab";

                    if (expectedEntityName == "ExtraTabsDescription")
                        expectedEntityName = "ExtraTabDescription";

                    if (expectedEntityName == "ProductExtraTabs")
                        expectedEntityName = "ProductExtraTab";

                    if (expectedEntityName == "ProductStickers")
                        expectedEntityName = "ProductSticker";

                    if (expectedEntityName == "ProductStickersDescription")
                        expectedEntityName = "ProductStickerDescription";

                    Assert.AreEqual(
                        expectedEntityName,
                        entity.Name,
                        $"Entity mapped to table '{tableName}' should have name '{expectedEntityName}'");
                }
            }
        }

        [TestCase]
        public void AllEntityPropertiesShouldHaveNameInPascalConvention()
        {
            var entities = GetOpenCartEntities();

            foreach (var entity in entities)
            {
                var properties = entity.GetProperties()
                    .Where(property => property.GetCustomAttributes(typeof(ColumnAttribute), false).Length > 0);

                foreach (var property in properties)
                {
                    Assert.IsTrue(
                        property.Name.InPascal(),
                        $"Property name '{property.Name}' of type '{entity.Name}' should be in pascal convention");
                }
            }
        }

        [TestCase]
        public void AllDomainPropertiesShouldHaveNameInPascalConvention()
        {
            var domainType = typeof(OpenCartDomain);

            var properties = domainType.GetProperties();

            foreach (var property in properties)
            {
                Assert.IsTrue(
                    property.Name.InPascal(),
                    $"Property name '{property.Name}' should be in pascal convention");
            }
        }

        [TestCase]
        public void AllEntitiesWithTitlePropertyShouldImplementEntityWithTitleInterface()
        {
            var entities = GetOpenCartEntities();

            foreach (var entity in entities)
            {
                if (entity.HasProperty("Title", typeof(string)))
                {
                    Assert.IsTrue(
                        entity.Implements<IEntityWithTitle>(),
                        $"Type '{entity.Name}' should implement IEntityWithTitle interface");
                }
            }
        }

        [TestCase]
        public void AllEntitiesWithNamePropertyShouldImplementEntityWithNameInterface()
        {
            var entities = GetOpenCartEntities();

            foreach (var entity in entities)
            {
                if (entity.HasProperty("Name", typeof(string)))
                {
                    Assert.IsTrue(
                        entity.Implements<IEntityWithName>(),
                        $"Type '{entity.Name}' should implement IEntityWithName interface");
                }
            }
        }

        [TestCase]
        public void AllEntitiesWithStatusPropertyShouldImplementEntityWithStatusInterface()
        {
            var entities = GetOpenCartEntities();

            foreach (var entity in entities)
            {
                if (entity.HasProperty("Status", typeof(bool)))
                {
                    Assert.IsTrue(
                        entity.Implements<IEntityWithStatus>(),
                        $"Type '{entity.Name}' should implement IEntityWithStatus interface");
                }
            }
        }

        [TestCase]
        public void AllKeyPropertiesShouldHaveIdNameAndProtectedSetter()
        {
            var entities = GetOpenCartEntities();

            foreach (var entity in entities)
            {
                var tableName = entity.GetAttribute<TableAttribute>().Name.Replace("oc_", string.Empty);

                foreach (var property in entity.GetProperties())
                {
                    var keyAttribue = property.GetAttribute<KeyAttribute>();
                    var columnAttribute = property.GetAttribute<ColumnAttribute>();

                    if (keyAttribue != null && columnAttribute.Name == $"{tableName}_id")
                    {
                        Assert.AreEqual(
                            "Id",
                            property.Name,
                            $"Property name '{property.Name}' of type '{entity.Name}' should be renamed to 'Id'");

                        var getter = property.GetGetMethod(true);
                        Assert.IsTrue(getter.IsPublic, $"{entity.Name}.{property.Name} getter should be made public");

                        var setter = property.GetSetMethod(true);
                        Assert.IsFalse(setter.IsPublic, $"{entity.Name}.{property.Name} setter should be made protected");
                    }
                }
            }
        }

        [TestCase]
        public void ShouldNotContainsEntitiesWhichImplementsManyToManyRelationship()
        {
            var entities = GetOpenCartEntities();

            foreach (var entity in entities)
            {
                var tableName = entity.GetAttribute<TableAttribute>().Name.Replace("oc_", string.Empty);
                var properties = entity.GetProperties();

                if (properties.Length != 2)
                    continue;

                var keyAttributes = properties
                    .Select(property => property.GetAttribute<KeyAttribute>())
                    .Where(attribute => attribute != null)
                    .ToArray();

                if (keyAttributes.Length != 2)
                    continue;

                Assert.Fail($"Entity '{entity.Name}' should be replaced with many-to-many mapping.");
            }
        }

        [TestCase]
        public void AllCollectionPropertiesShouldBeVirtualAndPublic()
        {
            foreach (var entity in GetOpenCartEntities())
            {
                foreach (var property in entity.GetProperties())
                {
                    if (!property.PropertyType.IsGenericType)
                        continue;

                    if (property.PropertyType.GetGenericTypeDefinition() != typeof(ICollection<>))
                        continue;

                    var getter = property.GetGetMethod(true);
                    Assert.IsTrue(getter.IsPublic && getter.IsVirtual, $"{entity.Name}.{property.Name} getter should be made public and virtual");

                    var setter = property.GetSetMethod(true);
                    Assert.IsTrue(setter.IsPublic && setter.IsVirtual, $"{entity.Name}.{property.Name} setter should be made public and virtual");
                }
            }
        }

        [TestCase]
        public void AllNavigationPropertiesShouldBeVirtualAndPublic()
        {
            var openCartAssembly = typeof(OpenCartDomain).Assembly;

            foreach (var entity in GetOpenCartEntities())
            {
                foreach (var property in entity.GetProperties())
                {
                    if (property.PropertyType.Assembly != openCartAssembly)
                        continue;

                    var getter = property.GetGetMethod(true);
                    Assert.IsTrue(getter.IsPublic && getter.IsVirtual, $"{entity.Name}.{property.Name} getter should be made public and virtual");

                    var setter = property.GetSetMethod(true);
                    Assert.IsTrue(setter.IsPublic && setter.IsVirtual, $"{entity.Name}.{property.Name} setter should be made public and virtual");
                }
            }
        }

        private Assembly GetOpenCartDomainAssembly()
        {
            return typeof(OpenCartDomain).Assembly;
        }

        private IEnumerable<Type> GetOpenCartEntities()
        {
            var assembly = GetOpenCartDomainAssembly();

            return assembly.GetTypes()
                .Where(type => !type.IsInterface && 
                    !type.IsSealed && 
                    !type.IsAbstract && 
                    type.GetCustomAttributes(typeof(TableAttribute), false).Length > 0);
        }

        private string GetEntityNameFromTableName(string tableName)
        {
            return string.Concat(tableName.Split('_')
                .Where(part => part.Length > 0 && part != "oc")
                .Select(x => string.Concat(x[0].ToString().ToUpper(), new string(x.Skip(1).ToArray()))));
        }
    }
}
