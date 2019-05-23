#pragma warning disable SA1121 // Use built-in type alias
using System;
using System.Globalization;
using SystemUInt64 = System.UInt64;

namespace jaytwo.FluentParsing
{
    public static class StringParserULongExtensions
    {
        public static SystemUInt64 ULong(this IParser<string> parser)
        {
            return SystemUInt64.Parse(parser?.OriginalValue);
        }

        public static SystemUInt64 ULong(this IParser<string> parser, NumberStyles style)
        {
            var formatProvider = Defaults.GetDefaultFormatProvider(style);

            return SystemUInt64.Parse(parser?.OriginalValue, style, formatProvider);
        }

        public static SystemUInt64? ULong(this INullableParser<string> parser)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }
            else
            {
                return SystemUInt64.Parse(parser?.OriginalValue);
            }
        }

        public static SystemUInt64? ULong(this INullableParser<string> parser, NumberStyles style)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }
            else
            {
                var formatProvider = Defaults.GetDefaultFormatProvider(style);

                return SystemUInt64.Parse(parser?.OriginalValue, style, formatProvider);
            }
        }

        public static SystemUInt64? ULong(this ITryParser<string> parser)
        {
            return SystemUInt64.TryParse(parser?.OriginalValue, out SystemUInt64 parsedValue)
                ? parsedValue
                : default(SystemUInt64?);
        }

        public static SystemUInt64? ULong(this ITryParser<string> parser, NumberStyles style)
        {
            var formatProvider = Defaults.GetDefaultFormatProvider(style);

            return SystemUInt64.TryParse(parser?.OriginalValue, style, formatProvider, out SystemUInt64 parsedValue)
                ? parsedValue
                : default(SystemUInt64?);
        }
    }
}
#pragma warning restore SA1121 // Use built-in type alias
