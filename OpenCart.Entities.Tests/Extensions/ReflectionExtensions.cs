using System;
using System.Linq;
using System.Reflection;

namespace OpenCart.Entities.Tests
{
    public static class ReflectionExtensions
    {
        public static TAttribute GetAttribute<TAttribute>(this MemberInfo type) where TAttribute : System.Attribute
        {
            return type.GetCustomAttributes(typeof(TAttribute), false)
                    .FirstOrDefault() as TAttribute;
        }

        public static bool HasProperty(this Type type, string name, Type propertyType)
        {
            return type.GetProperties()
                .Any(property => property.Name == name
                    && property.PropertyType == propertyType);
        }

        public static bool Implements<TInterface>(this Type type)
        {
            return type.GetInterfaces().Any(x => x == typeof(TInterface));
        }
    }
}
