using System;
using System.Globalization;
using SystemInt64 = System.Int64;

namespace jaytwo.FluentParsing
{
    public static class StringParserLongExtensions
    {
        public static SystemInt64 Long(this IParser<string> parser)
        {
            return SystemInt64.Parse(parser?.OriginalValue);
        }

        public static SystemInt64 Long(this IParser<string> parser, NumberStyles style)
        {
            var formatProvider = Defaults.GetDefaultFormatProvider(style);

            return SystemInt64.Parse(parser?.OriginalValue, style, formatProvider);
        }

        public static SystemInt64? Long(this INullableParser<string> parser)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }
            else
            {
                return SystemInt64.Parse(parser?.OriginalValue);
            }
        }

        public static SystemInt64? Long(this INullableParser<string> parser, NumberStyles style)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }
            else
            {
                return SystemInt64.Parse(parser?.OriginalValue, style);
            }
        }

        public static SystemInt64? Long(this ITryParser<string> parser)
        {
            return (SystemInt64.TryParse(parser?.OriginalValue, out SystemInt64 parsedValue))
                ? parsedValue
                : default(SystemInt64?);
        }

        public static SystemInt64? Long(this ITryParser<string> parser, NumberStyles style)
        {
            var formatProvider = Defaults.GetDefaultFormatProvider(style);

            return (SystemInt64.TryParse(parser?.OriginalValue, style, formatProvider, out SystemInt64 parsedValue))
                ? parsedValue
                : default(SystemInt64?);
        }
    }
}
