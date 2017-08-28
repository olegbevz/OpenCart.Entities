using System;

namespace OpenCart.Entities.Tests
{
    static class StringExtensions
    {
        public static bool InPascal(this string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException(nameof(value));

            char? previousChar = null;

            foreach (var @char in value)
            {
                if (char.IsLower(@char) && previousChar == null)
                    return false;

                if (char.IsUpper(@char) && previousChar != null && char.IsUpper(previousChar.Value))
                    return false;

                previousChar = @char;
            }

            return true;
        }
    }
}
