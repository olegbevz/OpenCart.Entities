using NUnit.Framework;
using OpenCart.Entities.Tests.Extensions;
using System;
using System.Data.Entity;
using System.Linq;

namespace OpenCart.Entities.Tests.Tests
{
    [TestFixture]
    public class DomainTests
    {
        [TestCase]
        public void ShouldHaveCollectionProperties()
        {
            foreach (var property in typeof(OpenCartDomain).GetOwnProperties())
            {
                Assert.IsTrue(
                    property.PropertyType.IsGeneric(typeof(DbSet<>)),
                    $"Domain property {property.Name} should have ICollection<> type.");

                Assert.IsTrue(
                    Notations.InPascal(property.Name),
                    $"Domain property {property.Name} should be in pascal notation.");

                Assert.IsTrue(
                    property.HasPublicGetter() && property.HasVirtualGetter(),
                    $"Domain property {property.Name} should have public virtual getter.");

                Assert.IsTrue(
                    property.HasPublicSetter() && property.HasVirtualSetter(),
                    $"Domain property {property.Name} should have public virtual setter.");
            }
        }

        [TestCase]
        public void EachEntityShouldBeAccessibleFromDomain()
        {
            var entities = EntityExtensions.GetEntities().ToList();

            foreach (var domainProperty in typeof(OpenCartDomain).GetOwnProperties())
            {
                if (!domainProperty.PropertyType.IsGeneric(typeof(DbSet<>)))
                    continue;

                var entityType = domainProperty.PropertyType.GetGenericArguments().FirstOrDefault();
                if (entityType == null)
                    throw new Exception($"Could not get entity type from domain property '{domainProperty.Name}'");

                foreach (var childEntity in EntityExtensions.GetEntityChildren(entityType))
                {
                    entities.Remove(childEntity);

                    foreach (var grandChildEntity in EntityExtensions.GetEntityChildren(childEntity))
                    {
                        entities.Remove(grandChildEntity);
                    }
                }

                entities.Remove(entityType);
            }

            Assert.IsEmpty(entities, "All entities should be accessible from domain class");
        }
    }
}
