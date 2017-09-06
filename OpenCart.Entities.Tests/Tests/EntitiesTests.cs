using NUnit.Framework;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using OpenCart.Entities.Tests.Extensions;

namespace OpenCart.Entities.Tests
{
    [TestFixture]
    public class EntitiesTests
    {
        #region Entities tests

        [Test]
        public void ShouldHaveEntities()
        {
            var entities = EntityUtilities.GetEntities();

            foreach (var entity in entities)
            {
                var tableAttribute = entity.GetAttribute<TableAttribute>();

                Assert.NotNull(tableAttribute, $"Type '{entity.Name}' should have TableAttribute");

                Assert.IsTrue(Notations.InPascal(entity.Name), $"Type  '{entity.Name}' should be in pascal convention");

                Assert.IsTrue(entity.IsPublic, $"Type {entity.Name} should be public");

                Assert.IsFalse(entity.IsAbstract, $"Type {entity.Name} should not be abstract");

                var tableName = tableAttribute.Name;
                var expectedEntityName = Notations.ToPascal(tableName);

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

        [Test]
        public void ShouldHaveDefaultConstructor()
        {
            foreach (var entity in EntityUtilities.GetEntities())
            {
                var constructors = entity.GetConstructors();
                var defaultConstructor = constructors.FirstOrDefault(x => x.IsPublic && x.GetParameters().Length == 0);
                Assert.IsNotNull(defaultConstructor, $"Entity {entity.Name} should public contain default constructor");
            }
        }

        [TestCase]
        public void ShouldHaveColumnProperties()
        {
            var entities = EntityUtilities.GetEntities();

            foreach (var entity in entities)
            {
                foreach (var property in entity.GetProperties().Where(EntityUtilities.IsColumnProperty))
                {
                    var columnAttribute = property.GetAttribute<ColumnAttribute>();

                    Assert.NotNull(
                        columnAttribute,
                        $"Property '{entity.Name}.{property.Name}' should be decorated with ColumnAttribute");

                    Assert.IsTrue(
                        Notations.InPascal(property.Name),
                        $"Property '{entity.Name}.{property.Name}' should be in pascal convention");
                    
                    //var expectedPropertyName = columnAttribute.Name.ToPascal();
                    //Assert.AreEqual(
                    //    property.Name, 
                    //    expectedPropertyName, 
                    //    $"Property {entity.Name}.{property.Name} should have '{expectedPropertyName}' name");

                    Assert.IsTrue(property.HasPublicGetter(), $"{entity.Name}.{property.Name} getter should be public");

                    Assert.IsTrue(property.HasPublicSetter(), $"{entity.Name}.{property.Name} setter should be public");
                }
            }
        }

        [TestCase]
        public void ShouldHavePrimaryKeyProperties()
        {
            var entities = EntityUtilities.GetEntities();

            foreach (var entity in entities)
            {
                var tableName = entity.GetAttribute<TableAttribute>().Name.Replace("oc_", string.Empty);

                foreach (var property in entity.GetProperties().Where(EntityUtilities.IsPrimaryKeyProperty))
                {
                    var columnAttribute = property.GetAttribute<ColumnAttribute>();

                    Assert.NotNull(columnAttribute, $"Property '{entity.Name}.{property.Name}' should be decorated with ColumnAttribute");

                    var expectedColumnName = $"{tableName}_id";

                    if (expectedColumnName == "extra_tabs_id")
                        expectedColumnName = "extra_tab_id";

                    if (expectedColumnName == "product_stickers_id")
                        expectedColumnName = "product_sticker_id";

                    Assert.AreEqual(expectedColumnName, columnAttribute.Name, $"Property '{entity.Name}.{property.Name}' should have ColumnAttribute with proper Name");
                    Assert.AreEqual("Id", property.Name, $"Property '{entity.Name}.{property.Name}' should be 'Id'");
                    Assert.IsTrue(property.HasPublicGetter(), $"{entity.Name}.{property.Name} getter should be made public");
                    Assert.IsFalse(property.HasPublicSetter(), $"{entity.Name}.{property.Name} setter should be made protected");

                    var keyAttribue = property.GetAttribute<KeyAttribute>();
                    Assert.NotNull(keyAttribue, $"Property '{entity.Name}.{property.Name}' should be decorated with KeyAttribute");
                }
            }
        }

        [TestCase]
        public void ShouldHaveForeignKeyProperties()
        {
            foreach (var entity in EntityUtilities.GetEntities())
            {
                foreach (var property in entity.GetProperties().Where(EntityUtilities.IsForeignKeyProperty))
                {
                    var getter = property.GetGetMethod(true);
                    Assert.IsTrue(getter.IsPublic, $"{entity.Name}.{property.Name} getter should be made public");

                    var setter = property.GetSetMethod(true);
                    Assert.IsTrue(setter.IsPublic, $"{entity.Name}.{property.Name} setter should be made public");
                }
            }
        }

        [TestCase]
        public void ShouldHaveNavigationProperties()
        {
            foreach (var entity in EntityUtilities.GetEntities())
            {
                var tableName = entity.GetAttribute<TableAttribute>().Name.Replace("oc_", string.Empty);

                var properties = entity.GetProperties();

                foreach (var property in properties.Where(EntityUtilities.IsForeignKeyProperty))
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

                    if (entity == typeof(ProductImageByOption) && navigationPropertyName == "ProductImage")
                        continue;

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

        [TestCase]
        public void ShouldHaveCollectionProperties()
        {
            var entities = EntityUtilities.GetEntities();

            foreach (var entity in entities)
            {
                foreach (var property in entity.GetProperties().Where(EntityUtilities.IsForeignKeyProperty))
                {
                    var foreignKeyName = property.GetAttribute<ColumnAttribute>().Name;

                    if (entity == typeof(CategoryPath) && foreignKeyName == "path_id")
                        continue;
                    
                    if (entity == typeof(Category) && foreignKeyName == "parent_id")
                        foreignKeyName = "category_id";
                    
                    if (entity == typeof(Order) && property.Name.EndsWith("CountryId"))
                        foreignKeyName = "country_id";

                    if (entity == typeof(Order) && property.Name.EndsWith("ZoneId"))
                        foreignKeyName = "zone_id";

                    if (foreignKeyName == "extra_tab_id")
                        foreignKeyName = "extra_tabs_id";                    

                    if (foreignKeyName == "product_sticker_id")
                        foreignKeyName = "product_stickers_id";

                    if (entity == typeof(ProductImageByOption) && foreignKeyName == "product_value_id")
                        foreignKeyName = "option_value_id";

                    var targetTableName = "oc_"  + foreignKeyName.Replace("_id", string.Empty);
                    var targetEntity = entities.FirstOrDefault(x => x.GetAttribute<TableAttribute>().Name == targetTableName);

                    if (targetEntity == null)
                        throw new Exception($"There is no entity {targetTableName} related to {entity.Name}.{property.Name}");

                    if (ShouldNotHaveCollectionProperty(entity, targetEntity))
                        continue;

                    var collectionProperty = targetEntity.GetProperties().SingleOrDefault(x => EntityUtilities.IsCollectionProperty(x, entity));
                    if (collectionProperty == null)
                        throw new Exception($"Entity {targetEntity.Name} should have property ICollection<{entity.Name}>.");

                    Assert.IsTrue(Notations.InPascal(collectionProperty.Name), $"Property '{entity.Name}.{collectionProperty.Name}' should be in pascal convention");

                    var getter = collectionProperty.GetGetMethod(true);
                    Assert.IsTrue(getter.IsPublic && getter.IsVirtual, $"{entity.Name}.{collectionProperty.Name} getter should be made public and virtual");

                    var setter = collectionProperty.GetSetMethod(true);
                    Assert.IsTrue(setter.IsPublic && setter.IsVirtual, $"{entity.Name}.{collectionProperty.Name} setter should be made public and virtual");

                    var targetEntityInstance = Activator.CreateInstance(targetEntity);
                    var collectionPropertyValue = collectionProperty.GetGetMethod().Invoke(targetEntityInstance, new object[0]);
                    Assert.IsNotNull(collectionPropertyValue, $"Property '{targetEntity.Name}.{collectionProperty.Name}' should be initialized in constructor");
                }
            }
        }

        [TestCase]
        public void ShouldNotContainsEntitiesWhichImplementsManyToManyRelationship()
        {
            var entities = EntityUtilities.GetEntities();

            foreach (var entity in entities)
            {
                var properties = entity.GetProperties();
                var keyAttributes = properties.Where(EntityUtilities.IsPrimaryKeyProperty).ToArray();
                var foreingKeys = properties.Where(EntityUtilities.IsForeignKeyProperty).ToArray();
                var navigationProperties = properties.Where(EntityUtilities.IsNavigationProperty).ToArray();

                if (properties.Length == 2)
                {
                    if (keyAttributes.Length == 2)
                        Assert.Fail($"Entity '{entity.Name}' should be replaced with many-to-many mapping.");
                }

                if (properties.Length == 3)
                {if (keyAttributes.Length == 1 && foreingKeys.Length == 2)
                        Assert.Fail($"Entity '{entity.Name}' should be replaced with many-to-many mapping.");
                }

                if (properties.Length == 4 && foreingKeys.Length == 2 && navigationProperties.Length == 2)
                {
                    if (foreingKeys.Length == 2)
                        Assert.Fail($"Entity '{entity.Name}' should be replaced with many-to-many mapping.");
                }

                if (properties.Length == 5)
                {
                    if (keyAttributes.Length == 1 && foreingKeys.Length == 2 && navigationProperties.Length == 2)
                        Assert.Fail($"Entity '{entity.Name}' should be replaced with many-to-many mapping.");
                }
            }
        }        

        #endregion

        #region Testing help methods

        private bool ShouldNotHaveCollectionProperty(Type entity, Type targetEntity)
        {
            if (entity == typeof(Address) && targetEntity == typeof(Customer))
                return true;

            if (entity == typeof(FilterDescription) && targetEntity == typeof(FilterGroup))
                return true;

            if (entity == typeof(OptionValueDescription) && targetEntity == typeof(Option))
                return true;

            if (entity == typeof(OptionValue) && targetEntity == typeof(Option))
                return true;

            if (entity == typeof(Cart))
                return true;

            if (IsDummyEntity(targetEntity) && !entity.Implements<Localizable>())
                return true;

            return false;
        }

        public bool IsDummyEntity(Type entity)
        {
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
                typeof(TaxRate),
                typeof(Attribute),
                typeof(ExtraTab),
                typeof(ProductImage)
            };

            if (dummyEntities.Contains(entity))
                return true;

            return false;
        }

        #endregion
    }
}
