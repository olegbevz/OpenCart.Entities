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
        private static Assembly openCartAssembly = typeof(OpenCartDomain).Assembly;

        [Test]
        public void ShouldHaveTableAttributes()
        {
            var entities = GetOpenCartEntities();

            foreach (var entity in entities)
            {
                var tableAttribute = entity.GetAttribute<TableAttribute>();

                Assert.NotNull(
                    tableAttribute,
                    $"Entity '{entity.Name}' should have TableAttribute");

                Assert.IsTrue(
                    entity.Name.InPascal(),
                    $"Type name '{entity.Name}' should be in pascal convention");

                var tableName = tableAttribute.Name;
                var expectedEntityName = ToPascalConvention(tableName);

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

        [TestCase]
        public void ShouldHaveColumnAttributes()
        {
            var entities = GetOpenCartEntities();

            foreach (var entity in entities)
            {
                foreach (var property in entity.GetProperties())
                {
                    if (property.PropertyType.Assembly == openCartAssembly)
                        continue;

                    if (property.PropertyType.IsGenericType)
                        continue;

                    var columnAttribute = property.GetAttribute<ColumnAttribute>();

                    Assert.NotNull(
                        columnAttribute,
                        $"Property '{entity.Name}.{property.Name}' should be decorated with ColumnAttribute");

                    Assert.IsTrue(
                        property.Name.InPascal(),
                        $"Property '{entity.Name}.{property.Name}' should be in pascal convention");
                }
            }
        }

        [TestCase]
        public void EntitiesWithTitlePropertyShouldImplementEntityWithTitleInterface()
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
        public void EntitiesWithNamePropertyShouldImplementEntityWithNameInterface()
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
        public void EntitiesWithStatusPropertyShouldImplementEntityWithStatusInterface()
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
        public void ShouldHaveKeyAttributes()
        {
            var entities = GetOpenCartEntities();

            foreach (var entity in entities)
            {
                var tableName = entity.GetAttribute<TableAttribute>().Name.Replace("oc_", string.Empty);

                foreach (var property in entity.GetProperties())
                {
                    if (property.PropertyType.Assembly == openCartAssembly)
                        continue;

                    if (property.PropertyType.IsGenericType)
                        continue;

                    var columnAttribute = property.GetAttribute<ColumnAttribute>();
                    if (columnAttribute.Name != $"{tableName}_id")
                        continue;

                    var keyAttribue = property.GetAttribute<KeyAttribute>();
                    Assert.NotNull(keyAttribue, $"Property name '{entity.Name}.{property.Name}' should be decorated with KeyAttribute");

                    Assert.AreEqual("Id", property.Name, $"Property name '{entity.Name}.{property.Name}' should be 'Id'");

                    var getter = property.GetGetMethod(true);
                    Assert.IsTrue(getter.IsPublic, $"{entity.Name}.{property.Name} getter should be made public");

                    var setter = property.GetSetMethod(true);
                    Assert.IsFalse(setter.IsPublic, $"{entity.Name}.{property.Name} setter should be made protected");
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
        public void ShouldHaveCollectionProperties()
        {
            foreach (var entity in GetOpenCartEntities())
            {
                foreach (var property in entity.GetProperties())
                {
                    if (!property.PropertyType.IsGenericType)
                        continue;

                    if (property.PropertyType.GetGenericTypeDefinition() != typeof(ICollection<>))
                        continue;

                    Assert.IsTrue(property.Name.InPascal(), $"Property '{entity.Name}.{property.Name}' should be in pascal convention");

                    var getter = property.GetGetMethod(true);
                    Assert.IsTrue(getter.IsPublic && getter.IsVirtual, $"{entity.Name}.{property.Name} getter should be made public and virtual");

                    var setter = property.GetSetMethod(true);
                    Assert.IsTrue(setter.IsPublic && setter.IsVirtual, $"{entity.Name}.{property.Name} setter should be made public and virtual");
                }
            }
        }

        [TestCase]
        public void ShouldHaveForeignKeyProperties()
        {
            foreach (var entity in GetOpenCartEntities())
            {
                foreach (var property in entity.GetProperties())
                {
                    var columnAttribute = property.GetAttribute<ColumnAttribute>();
                    if (columnAttribute == null)
                        continue;

                    if (property.GetAttribute<KeyAttribute>() != null)
                        continue;

                    if (!columnAttribute.Name.EndsWith("_id"))
                        continue;

                    var getter = property.GetGetMethod(true);
                    Assert.IsTrue(getter.IsPublic && !getter.IsVirtual, $"{entity.Name}.{property.Name} getter should be made public");

                    var setter = property.GetSetMethod(true);
                    Assert.IsTrue(setter.IsPublic && !setter.IsVirtual, $"{entity.Name}.{property.Name} setter should be made public");
                }
            }
        }

        [TestCase]
        public void ShouldHaveNavigationProperties()
        {
            foreach (var entity in GetOpenCartEntities())
            {
                var tableName = entity.GetAttribute<TableAttribute>().Name.Replace("oc_", string.Empty);                

                var properties = entity.GetProperties();

                foreach (var property in properties)
                {
                    var columnAttribute = property.GetAttribute<ColumnAttribute>();
                    if (columnAttribute == null)
                        continue;

                    if (!columnAttribute.Name.EndsWith("_id"))
                        continue;

                    if (columnAttribute.Name == "session_id" ||
                        columnAttribute.Name == "path_id" ||
                        columnAttribute.Name == "extra_tab_id" ||
                        columnAttribute.Name == "product_sticker_id")
                        continue;

                    if (columnAttribute.Name == $"{tableName}_id")
                        continue;

                    var navigationPropertyName = property.Name.Replace("Id", string.Empty);

                    var navigationProperty = properties.FirstOrDefault(x => x.Name == navigationPropertyName);
                    
                    Assert.NotNull(
                        navigationProperty,
                        $"Type '{entity.Name}' should have navigation property '{navigationPropertyName}'.");

                    if (entity == typeof(Order) && navigationProperty.PropertyType == typeof(string))
                        continue;

                    var getter = navigationProperty.GetGetMethod(true);
                    Assert.IsTrue(getter.IsPublic && getter.IsVirtual, $"{entity.Name}.{property.Name} getter should be made public and virtual");

                    var setter = navigationProperty.GetSetMethod(true);
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

        private string ToPascalConvention(string tableName)
        {
            return string.Concat(tableName.Split('_')
                .Where(part => part.Length > 0 && part != "oc")
                .Select(x => string.Concat(x[0].ToString().ToUpper(), new string(x.Skip(1).ToArray()))));
        }
    }
}
