using System;
using System.Text;

namespace jaytwo.FluentParsing
{
    public static class ByteArrayParserExtensions
    {
        public static string UTF8(this IParser<byte[]> value)
        {
            return GetString(value?.OriginalValue, Encoding.UTF8);
        }

        public static string UTF8(this ITryParser<byte[]> value)
        {
            try
            {
                return GetString(value?.OriginalValue, Encoding.UTF8);
            }
            catch
            {
                return null;
            }   
        }

        public static string UTF8(this INullableParser<byte[]> value)
        {
            if (value?.OriginalValue == null)
            {
                return null;
            }

            return GetString(value?.OriginalValue, Encoding.UTF8);
        }

        public static string String(this IParser<byte[]> value, Encoding encoding)
        {
            return GetString(value?.OriginalValue, encoding);
        }

        public static string String(this ITryParser<byte[]> value, Encoding encoding)
        {
            try
            {
                return GetString(value?.OriginalValue, encoding);
            }
            catch
            {
                return null;
            }
        }

        public static string String(this INullableParser<byte[]> value, Encoding encoding)
        {
            if (value?.OriginalValue == null)
            {
                return null;
            }

            return GetString(value?.OriginalValue, encoding);
        }

        private static string GetString(byte[] bytes, Encoding encoding)
        {
            if (bytes == null)
            {
                throw new ArgumentNullException(nameof(bytes));
            }

            if (encoding == null)
            {
                throw new ArgumentNullException(nameof(encoding));
            }

            return encoding.GetString(bytes, 0, bytes.Length);
        }
    }
}
