using System;
using System.Text;

namespace jaytwo.FluentParsing
{
    public static class ByteArrayParserExtensions
    {
        public static string Hex(this IParser<byte[]> value)
        {
            return Hex(value?.OriginalValue);
        }

        public static string Hex(this ITryParser<byte[]> value)
        {
            try
            {
                return Hex(value?.OriginalValue);
            }
            catch
            {
                return null;
            }
        }

        public static string Hex(this INullableParser<byte[]> value)
        {
            if (value?.OriginalValue == null)
            {
                return null;
            }

            return Hex(value?.OriginalValue);
        }

        public static string Base64(this IParser<byte[]> value)
        {
            return Base64(value?.OriginalValue);
        }

        public static string Base64(this ITryParser<byte[]> value)
        {
            try
            {
                return Base64(value?.OriginalValue);
            }
            catch
            {
                return null;
            }
        }

        public static string Base64(this INullableParser<byte[]> value)
        {
            if (value?.OriginalValue == null)
            {
                return null;
            }

            return Base64(value?.OriginalValue);
        }

        public static string UTF8String(this IParser<byte[]> value)
        {
            return GetString(value?.OriginalValue, Encoding.UTF8);
        }

        public static string UTF8String(this ITryParser<byte[]> value)
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

        public static string UTF8String(this INullableParser<byte[]> value)
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

        private static string Hex(byte[] bytes)
        {
            if (bytes == null)
            {
                throw new ArgumentNullException(nameof(bytes));
            }

            return BitConverter.ToString(bytes).Replace("-", string.Empty);
        }

        private static string Base64(byte[] bytes)
        {
            if (bytes == null)
            {
                throw new ArgumentNullException(nameof(bytes));
            }

            return Convert.ToBase64String(bytes);
        }
    }
}
