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
    }
}
