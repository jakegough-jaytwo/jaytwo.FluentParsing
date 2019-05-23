#pragma warning disable SA1121 // Use built-in type alias
using System;
using System.Globalization;
using SystemSingle = System.Single;

namespace jaytwo.FluentParsing
{
    public static class StringParserFloatExtensions
    {
        public static SystemSingle Float(this IParser<string> parser)
        {
            return SystemSingle.Parse(parser?.OriginalValue);
        }

        public static SystemSingle Float(this IParser<string> parser, NumberStyles style)
        {
            var formatProvider = Defaults.GetDefaultFormatProvider(style);

            return SystemSingle.Parse(parser?.OriginalValue, style, formatProvider);
        }

        public static SystemSingle? Float(this INullableParser<string> parser)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }
            else
            {
                return SystemSingle.Parse(parser?.OriginalValue);
            }
        }

        public static SystemSingle? Float(this INullableParser<string> parser, NumberStyles style)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }
            else
            {
                var formatProvider = Defaults.GetDefaultFormatProvider(style);

                return SystemSingle.Parse(parser?.OriginalValue, style, formatProvider);
            }
        }

        public static SystemSingle? Float(this ITryParser<string> parser)
        {
            return SystemSingle.TryParse(parser?.OriginalValue, out SystemSingle parsedValue)
                ? parsedValue
                : default(SystemSingle?);
        }

        public static SystemSingle? Float(this ITryParser<string> parser, NumberStyles style)
        {
            var formatProvider = Defaults.GetDefaultFormatProvider(style);

            return SystemSingle.TryParse(parser?.OriginalValue, style, formatProvider, out SystemSingle parsedValue)
                ? parsedValue
                : default(SystemSingle?);
        }
    }
}
#pragma warning restore SA1121 // Use built-in type alias
