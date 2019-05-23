#pragma warning disable SA1121 // Use built-in type alias
using System;
using System.Globalization;
using SystemDecimal = System.Decimal;

namespace jaytwo.FluentParsing
{
    public static class StringParserDecimalExtensions
    {
        public static SystemDecimal Decimal(this IParser<string> parser)
        {
            return SystemDecimal.Parse(parser?.OriginalValue);
        }

        public static SystemDecimal Decimal(this IParser<string> parser, NumberStyles style)
        {
            var formatProvider = Defaults.GetDefaultFormatProvider(style);

            return SystemDecimal.Parse(parser?.OriginalValue, style, formatProvider);
        }

        public static SystemDecimal? Decimal(this INullableParser<string> parser)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }
            else
            {
                return SystemDecimal.Parse(parser?.OriginalValue);
            }
        }

        public static SystemDecimal? Decimal(this INullableParser<string> parser, NumberStyles style)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }
            else
            {
                var formatProvider = Defaults.GetDefaultFormatProvider(style);

                return SystemDecimal.Parse(parser?.OriginalValue, style, formatProvider);
            }
        }

        public static SystemDecimal? Decimal(this ITryParser<string> parser)
        {
            return SystemDecimal.TryParse(parser?.OriginalValue, out SystemDecimal parsedValue)
                ? parsedValue
                : default(SystemDecimal?);
        }

        public static SystemDecimal? Decimal(this ITryParser<string> parser, NumberStyles style)
        {
            var formatProvider = Defaults.GetDefaultFormatProvider(style);

            return SystemDecimal.TryParse(parser?.OriginalValue, style, formatProvider, out SystemDecimal parsedValue)
                ? parsedValue
                : default(SystemDecimal?);
        }
    }
}
#pragma warning restore SA1121 // Use built-in type alias
