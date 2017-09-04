using NUnit.Framework;
using System;
using System.Collections;
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
                var properties = entity.GetProperties();

                if (properties.Length == 2)
                {
                    var keyAttributes = properties
                        .Select(property => property.GetAttribute<KeyAttribute>())
                        .Where(attribute => attribute != null)
                        .ToArray();

                    if (keyAttributes.Length == 2)
                        Assert.Fail($"Entity '{entity.Name}' should be replaced with many-to-many mapping.");
                }
                    
                if (properties.Length == 3)
                {
                    var keyAttributes = properties.Where(property => property.GetAttribute<KeyAttribute>() != null)
                        .ToArray();

                    var foreingKeys = properties.Where(IsForeignKey)
                        .ToArray();

                    if (keyAttributes.Length == 1 && foreingKeys.Length == 2)
                        Assert.Fail($"Entity '{entity.Name}' should be replaced with many-to-many mapping.");
                }

                if (properties.Length == 4)
                {
                    var keyAttributes = properties
                        .Select(property => property.GetAttribute<KeyAttribute>())
                        .Where(attribute => attribute != null)
                        .ToArray();

                    var foreingKeys = properties.Where(IsForeignKey)
                        .ToArray();

                    if (keyAttributes.Length == 2 && foreingKeys.Length == 2)
                        Assert.Fail($"Entity '{entity.Name}' should be replaced with many-to-many mapping.");
                }

                if (properties.Length == 5)
                {
                    var keyAttributes = properties.Where(property => property.GetAttribute<KeyAttribute>() != null)
                        .ToArray();

                    var foreingKeys = properties.Where(IsForeignKey)
                        .ToArray();

                    var navigationProperties = properties.Where(IsNavigationProperty)
                        .ToArray();

                    if (keyAttributes.Length == 1 && foreingKeys.Length == 2 && navigationProperties.Length == 2)
                        Assert.Fail($"Entity '{entity.Name}' should be replaced with many-to-many mapping.");
                }
            }
        }

        [TestCase]
        public void ShouldHaveCollectionProperties()
        {
            var entities = GetOpenCartEntities().AsEnumerable();

            foreach (var entity in entities)
            {
                foreach (var property in entity.GetProperties().Where(IsForeignKey))
                {
                    var foreignKeyName = property.GetAttribute<ColumnAttribute>().Name;
                    if (entity == typeof(Category) && foreignKeyName == "parent_id")
                        foreignKeyName = "category_id";
                    
                    if (entity == typeof(Order) && property.Name.EndsWith("CountryId"))
                        foreignKeyName = "country_id";

                    if (entity == typeof(Order) && property.Name.EndsWith("ZoneId"))
                        foreignKeyName = "zone_id";

                    var targetTableName = "oc_"  + foreignKeyName.Replace("_id", string.Empty);
                    var targetEntity = entities.FirstOrDefault(x => x.GetAttribute<TableAttribute>().Name == targetTableName);

                    if (targetEntity == null)
                        throw new Exception($"There is no target entity related to {entity.Name}.{property.Name}");

                    var collectionProperty = targetEntity.GetProperties().SingleOrDefault(x => x.PropertyType.IsGenericType(typeof(ICollection<>), entity));

                    if (ShouldNotHaveCollectionProperty(entity, targetEntity))
                    {
                        if (collectionProperty != null)
                            throw new Exception($"Entity {targetEntity.Name} should not have property ICollection<{entity.Name}>.");

                        continue;
                    }
                    
                    if (collectionProperty == null)
                        throw new Exception($"Entity {targetEntity.Name} should have property ICollection<{entity.Name}>.");

                    Assert.IsTrue(collectionProperty.Name.InPascal(), $"Property '{entity.Name}.{collectionProperty.Name}' should be in pascal convention");

                    var getter = collectionProperty.GetGetMethod(true);
                    Assert.IsTrue(getter.IsPublic && getter.IsVirtual, $"{entity.Name}.{collectionProperty.Name} getter should be made public and virtual");

                    var setter = collectionProperty.GetSetMethod(true);
                    Assert.IsTrue(setter.IsPublic && setter.IsVirtual, $"{entity.Name}.{collectionProperty.Name} setter should be made public and virtual");
                }
            }
        }

        [TestCase]
        public void ShouldHaveForeignKeyProperties()
        {
            foreach (var entity in GetOpenCartEntities())
            {
                foreach (var property in entity.GetProperties().Where(IsForeignKey))
                {
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

                foreach (var property in properties.Where(IsForeignKey))
                {
                    var columnAttribute = property.GetAttribute<ColumnAttribute>();

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

        private bool ShouldNotHaveCollectionProperty(Type entity, Type targetEntity)
        {
            if (entity == typeof(Address) && targetEntity == typeof(Customer))
                return true;

            if (entity == typeof(OptionValueDescription) && targetEntity == typeof(Option))
                return true;

            if (entity == typeof(Cart))
                return true;

            var dummyEntities = new[]
            {
                typeof(Address),
                typeof(Country),
                typeof(Zone),
                typeof(GeoZone),
                typeof(Order),
                typeof(Language),
                typeof(OrderStatus),
                typeof(Currency),
                typeof(CustomField),
                typeof(CustomFieldValue),
                typeof(Recurring),
                typeof(Voucher),
                typeof(StockStatus),
                typeof(WeightClass),
                typeof(LengthClass),
                typeof(Option),
                typeof(OptionValue),
                typeof(ReturnReason),
                typeof(ReturnAction),
                typeof(ReturnStatus),
                typeof(TaxClass),
                typeof(TaxRate)
            };

            if (dummyEntities.Contains(targetEntity))
                return true;

            return false;
        }

        public bool IsForeignKey(PropertyInfo property)
        {
            var columnAttribute = property.GetAttribute<ColumnAttribute>();
            if (columnAttribute == null)
                return false;

            if (property.GetAttribute<KeyAttribute>() != null)
                return false;

            if (property.DeclaringType == typeof(ApiSession) && property.Name == "SessionId")
                return false;

            if (property.DeclaringType == typeof(Cart) && property.Name == "SessionId")
                return false;

            return columnAttribute.Name.EndsWith("_id");
        }

        public bool IsNavigationProperty(PropertyInfo property)
        {
            return property.PropertyType.Assembly == openCartAssembly;
        }
    }
}
