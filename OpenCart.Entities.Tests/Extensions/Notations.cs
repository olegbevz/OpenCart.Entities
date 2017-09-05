using System;
using System.Linq;

namespace OpenCart.Entities.Tests
{
    static class Notations
    {
        public static bool InPascal(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException(nameof(value));

            char? previousChar = null;

            foreach (var @char in value)
            {
                if (char.IsLower(@char) && previousChar == null)
                    return false;

                //if (char.IsUpper(@char) && previousChar != null && char.IsUpper(previousChar.Value))
                //    return false;

                previousChar = @char;
            }

            return true;
        }

        public static string ToPascal(string value)
        {
            return string.Concat(value.Split('_')
                .Where(part => part.Length > 0 && part != "oc")
                .Select(x => string.Concat(x[0].ToString().ToUpper(), new string(x.Skip(1).ToArray()))));
        }
    }
}
