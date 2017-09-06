using System;
using System.Collections;
using System.Collections.Generic;
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

        public static bool IsGeneric(this Type type, Type genericType, Type typeParameter)
        {
            return IsGeneric(type, genericType) && type.GetGenericArguments().FirstOrDefault() == typeParameter;
        }

        public static bool IsGeneric(this Type type, Type genericType)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition() == genericType;
        }

        public static bool HasPublicSetter(this PropertyInfo property)
        {
            return property.GetSetMethod(true).IsPublic;
        }

        public static bool HasPublicGetter(this PropertyInfo property)
        {
            return property.GetGetMethod(true).IsPublic;
        }

        public static bool HasVirtualSetter(this PropertyInfo property)
        {
            return property.GetSetMethod(true).IsVirtual;
        }

        public static bool HasVirtualGetter(this PropertyInfo property)
        {
            return property.GetGetMethod(true).IsVirtual;
        }

        public static IEnumerable<PropertyInfo> GetOwnProperties(this Type type)
        {
            return type.GetProperties().Where(property => property.DeclaringType == type);
        }
    }
}
