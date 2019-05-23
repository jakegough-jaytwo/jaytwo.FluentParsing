#pragma warning disable SA1121 // Use built-in type alias
using System;
using System.Globalization;
using SystemInt32 = System.Int32;

namespace jaytwo.FluentParsing
{
    public static class StringParserIntExtensions
    {
        public static SystemInt32 Int(this IParser<string> parser)
        {
            return SystemInt32.Parse(parser?.OriginalValue);
        }

        public static SystemInt32 Int(this IParser<string> parser, NumberStyles style)
        {
            var formatProvider = Defaults.GetDefaultFormatProvider(style);

            return SystemInt32.Parse(parser?.OriginalValue, style, formatProvider);
        }

        public static SystemInt32? Int(this INullableParser<string> parser)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }
            else
            {
                return SystemInt32.Parse(parser?.OriginalValue);
            }
        }

        public static SystemInt32? Int(this INullableParser<string> parser, NumberStyles style)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }
            else
            {
                var formatProvider = Defaults.GetDefaultFormatProvider(style);

                return SystemInt32.Parse(parser?.OriginalValue, style, formatProvider);
            }
        }

        public static SystemInt32? Int(this ITryParser<string> parser)
        {
            return SystemInt32.TryParse(parser?.OriginalValue, out SystemInt32 parsedValue)
                ? parsedValue
                : default(SystemInt32?);
        }

        public static SystemInt32? Int(this ITryParser<string> parser, NumberStyles style)
        {
            var formatProvider = Defaults.GetDefaultFormatProvider(style);

            return SystemInt32.TryParse(parser?.OriginalValue, style, formatProvider, out SystemInt32 parsedValue)
                ? parsedValue
                : default(SystemInt32?);
        }
    }
}
#pragma warning restore SA1121 // Use built-in type alias
