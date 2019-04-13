using System;
using System.Linq;
using System.Text;

namespace jaytwo.FluentParsing
{
    public static class StringParserBinaryExtensions
    {
        public static byte[] Base64(this IParser<string> parser)
        {
            return Convert.FromBase64String(parser?.OriginalValue);
        }

        public static byte[] Base64(this INullableParser<string> parser)
        {
            var valueToParse = parser?.OriginalValue;

            if (valueToParse == null)
            {
                return null;
            }

            return Convert.FromBase64String(valueToParse);
        }

        public static byte[] Base64(this ITryParser<string> parser)
        {
            try
            {
                return Convert.FromBase64String(parser?.OriginalValue);
            }
            catch
            {
                return null;
            }
        }

        public static byte[] Hex(this IParser<string> parser)
        {
            return Hex(parser?.OriginalValue);
        }

        public static byte[] Hex(this INullableParser<string> parser)
        {
            var valueToParse = parser?.OriginalValue;

            if (valueToParse == null)
            {
                return null;
            }

            return Hex(valueToParse);
        }

        public static byte[] Hex(this ITryParser<string> parser)
        {
            try
            {
                return Hex(parser?.OriginalValue);
            }
            catch
            {
                return null;
            }
        }

        private static byte[] Hex(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            if (value.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
            {
                value = value.Substring(2);
            }

            return Enumerable.Range(0, value.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(value.Substring(x, 2), 16))
                .ToArray();
        }
    }
}
