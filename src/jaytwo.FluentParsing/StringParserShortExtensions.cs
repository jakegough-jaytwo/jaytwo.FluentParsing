using System;
using System.Globalization;
using SystemInt16 = System.Int16;

namespace jaytwo.FluentParsing
{
    public static class StringParserShortExtensions
    {
        public static SystemInt16 Short(this IParser<string> parser)
        {
            return SystemInt16.Parse(parser?.OriginalValue);
        }

        public static SystemInt16 Short(this IParser<string> parser, NumberStyles style)
        {
            var formatProvider = Defaults.GetDefaultFormatProvider(style);

            return SystemInt16.Parse(parser?.OriginalValue, style, formatProvider);
        }

        public static SystemInt16? Short(this INullableParser<string> parser)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }
            else
            {
                return SystemInt16.Parse(parser?.OriginalValue);
            }
        }

        public static SystemInt16? Short(this INullableParser<string> parser, NumberStyles style)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }
            else
            {
                var formatProvider = Defaults.GetDefaultFormatProvider(style);

                return SystemInt16.Parse(parser?.OriginalValue, style, formatProvider);
            }
        }

        public static SystemInt16? Short(this ITryParser<string> parser)
        {
            return (SystemInt16.TryParse(parser?.OriginalValue, out SystemInt16 parsedValue))
                ? parsedValue
                : default(SystemInt16?);
        }

        public static SystemInt16? Short(this ITryParser<string> parser, NumberStyles style)
        {
            var formatProvider = Defaults.GetDefaultFormatProvider(style);

            return (SystemInt16.TryParse(parser?.OriginalValue, style, formatProvider, out SystemInt16 parsedValue))
                ? parsedValue
                : default(SystemInt16?);
        }
    }
}
