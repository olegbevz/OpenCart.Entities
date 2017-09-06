using NUnit.Framework;
using OpenCart.Entities.Tests.Extensions;
using System.Linq;

namespace OpenCart.Entities.Tests.Tests
{
    [TestFixture]
    public class MappingsTests
    {
        [TestCase]
        public void ShouldHaveMappings()
        {
            foreach (var mapping in typeof(OpenCartDomain).Assembly.GetTypes().Where(EntityUtilities.IsMapping))
            {
                Assert.IsTrue(!mapping.IsPublic, $"Mapping {mapping.Name} should be internal");
            }
        }
    }
}
