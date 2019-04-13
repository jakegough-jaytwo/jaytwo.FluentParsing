using System;
using System.Globalization;
using SystemDouble = System.Double;

namespace jaytwo.FluentParsing
{
    public static class StringParserDoubleExtensions
    {
        public static SystemDouble Double(this IParser<string> parser)
        {
            return SystemDouble.Parse(parser?.OriginalValue);
        }

        public static SystemDouble Double(this IParser<string> parser, NumberStyles style)
        {
            var formatProvider = Defaults.GetDefaultFormatProvider(style);

            return SystemDouble.Parse(parser?.OriginalValue, style, formatProvider);
        }

        public static SystemDouble? Double(this INullableParser<string> parser)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }
            else
            {
                return SystemDouble.Parse(parser?.OriginalValue);
            }
        }

        public static SystemDouble? Double(this INullableParser<string> parser, NumberStyles style)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }
            else
            {
                var formatProvider = Defaults.GetDefaultFormatProvider(style);

                return SystemDouble.Parse(parser?.OriginalValue, style, formatProvider);
            }
        }

        public static SystemDouble? Double(this ITryParser<string> parser)
        {
            return (SystemDouble.TryParse(parser?.OriginalValue, out SystemDouble parsedValue))
                ? parsedValue
                : default(SystemDouble?);
        }

        public static SystemDouble? Double(this ITryParser<string> parser, NumberStyles style)
        {
            var formatProvider = Defaults.GetDefaultFormatProvider(style);

            return (SystemDouble.TryParse(parser?.OriginalValue, style, formatProvider, out SystemDouble parsedValue))
                ? parsedValue
                : default(SystemDouble?);
        }
    }
}
