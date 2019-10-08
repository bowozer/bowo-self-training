using System;

namespace StringLibrary
{
    public static class StringUtil
    {
        public static bool StartsWithUpper(this string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return false;

            char firstChar = str[0];

            return char.IsUpper(firstChar);
        }
    }
}
