using NUnit.Framework;
using OpenCart.Entities.Tests.Extensions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace OpenCart.Entities.Tests.Tests
{
    [TestFixture]
    class DomainTests
    {
        [TestCase]
        public void EachEntityShouldBeAccessibleFromDomain()
        {
            var entities = EntityExtensions.GetEntities().ToList();

            foreach (var domainProperty in typeof(OpenCartDomain).GetProperties())
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
