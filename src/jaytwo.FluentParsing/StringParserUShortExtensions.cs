#pragma warning disable SA1121 // Use built-in type alias
using System;
using System.Globalization;
using SystemUInt16 = System.UInt16;

namespace jaytwo.FluentParsing
{
    public static class StringParserUShortExtensions
    {
        public static SystemUInt16 UShort(this IParser<string> parser)
        {
            return SystemUInt16.Parse(parser?.OriginalValue);
        }

        public static SystemUInt16 UShort(this IParser<string> parser, NumberStyles style)
        {
            var formatProvider = Defaults.GetDefaultFormatProvider(style);

            return SystemUInt16.Parse(parser?.OriginalValue, style, formatProvider);
        }

        public static SystemUInt16? UShort(this INullableParser<string> parser)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }
            else
            {
                return SystemUInt16.Parse(parser?.OriginalValue);
            }
        }

        public static SystemUInt16? UShort(this INullableParser<string> parser, NumberStyles style)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }
            else
            {
                var formatProvider = Defaults.GetDefaultFormatProvider(style);

                return SystemUInt16.Parse(parser?.OriginalValue, style, formatProvider);
            }
        }

        public static SystemUInt16? UShort(this ITryParser<string> parser)
        {
            return SystemUInt16.TryParse(parser?.OriginalValue, out SystemUInt16 parsedValue)
                ? parsedValue
                : default(SystemUInt16?);
        }

        public static SystemUInt16? UShort(this ITryParser<string> parser, NumberStyles style)
        {
            var formatProvider = Defaults.GetDefaultFormatProvider(style);

            return SystemUInt16.TryParse(parser?.OriginalValue, style, formatProvider, out SystemUInt16 parsedValue)
                ? parsedValue
                : default(SystemUInt16?);
        }
    }
}
#pragma warning restore SA1121 // Use built-in type alias
