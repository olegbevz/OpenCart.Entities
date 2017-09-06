using NUnit.Framework;
using OpenCart.Entities.Tests.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace OpenCart.Entities.Tests.Tests
{
    [TestFixture]
    public class InterfacesTests
    {
        [TestCase]
        public void EntitiesWithTitlePropertyShouldImplementEntityWithTitleInterface()
        {
            var entities = EntityExtensions.GetEntities();

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
            var entities = EntityExtensions.GetEntities();

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
            var entities = EntityExtensions.GetEntities();

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
    }
}
