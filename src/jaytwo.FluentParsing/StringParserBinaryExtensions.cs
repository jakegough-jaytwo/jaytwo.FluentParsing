using System;
using System.Linq;
using System.Text;

namespace jaytwo.FluentParsing
{
    public static class StringParserBinaryExtensions
    {
        public static byte[] UTF8Bytes(this IParser<string> parser)
        {
            return Bytes(Encoding.UTF8, parser?.OriginalValue);
        }

        public static byte[] UTF8Bytes(this INullableParser<string> parser)
        {
            var valueToParse = parser?.OriginalValue;

            if (valueToParse == null)
            {
                return null;
            }

            return Bytes(Encoding.UTF8, valueToParse);
        }

        public static byte[] UTF8Bytes(this ITryParser<string> parser)
        {
            try
            {
                return Bytes(Encoding.UTF8, parser?.OriginalValue);
            }
            catch
            {
                return null;
            }
        }

        public static byte[] Bytes(this IParser<string> parser, Encoding encoding)
        {
            return Bytes(encoding, parser?.OriginalValue);
        }

        public static byte[] Bytes(this INullableParser<string> parser, Encoding encoding)
        {
            var valueToParse = parser?.OriginalValue;

            if (valueToParse == null)
            {
                return null;
            }

            return Bytes(encoding, valueToParse);
        }

        public static byte[] Bytes(this ITryParser<string> parser, Encoding encoding)
        {
            try
            {
                return Bytes(encoding, parser?.OriginalValue);
            }
            catch
            {
                return null;
            }
        }

        public static byte[] Base64Bytes(this IParser<string> parser)
        {
            return Convert.FromBase64String(parser?.OriginalValue);
        }

        public static byte[] Base64Bytes(this INullableParser<string> parser)
        {
            var valueToParse = parser?.OriginalValue;

            if (valueToParse == null)
            {
                return null;
            }

            return Convert.FromBase64String(valueToParse);
        }

        public static byte[] Base64Bytes(this ITryParser<string> parser)
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

        public static byte[] HexBytes(this IParser<string> parser)
        {
            return HexBytes(parser?.OriginalValue);
        }

        public static byte[] HexBytes(this INullableParser<string> parser)
        {
            var valueToParse = parser?.OriginalValue;

            if (valueToParse == null)
            {
                return null;
            }

            return HexBytes(valueToParse);
        }

        public static byte[] HexBytes(this ITryParser<string> parser)
        {
            try
            {
                return HexBytes(parser?.OriginalValue);
            }
            catch
            {
                return null;
            }
        }

        private static byte[] Bytes(Encoding encoding, string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            if (encoding == null)
            {
                throw new ArgumentNullException(nameof(encoding));
            }

            return encoding.GetBytes(value);
        }

        private static byte[] HexBytes(string value)
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
