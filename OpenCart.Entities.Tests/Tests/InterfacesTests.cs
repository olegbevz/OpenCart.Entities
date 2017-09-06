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
            foreach (var entity in EntityExtensions.GetEntities())
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
            foreach (var entity in EntityExtensions.GetEntities())
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
            foreach (var entity in EntityExtensions.GetEntities())
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
        public void EntitiesWithLanguagePropertiesShouldImplementLocalizableInterface()
        {
            foreach (var entity in EntityExtensions.GetEntities())
            {
                if (entity.HasProperty("LanguageId", typeof(int)) &&
                    entity.HasProperty("Language", typeof(Language)))
                {
                    Assert.IsTrue(
                        entity.Implements<ILocalizable>(),
                        $"Type '{entity.Name}' should implement ILocalizable interface");
                }
            }
        }
    }
}
