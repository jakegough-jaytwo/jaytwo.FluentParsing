using System;
using System.Globalization;
using SystemUInt32 = System.UInt32;

namespace jaytwo.FluentParsing
{
    public static class StringParserUIntExtensions
    {
        public static SystemUInt32 UInt(this IParser<string> parser)
        {
            return SystemUInt32.Parse(parser?.OriginalValue);
        }

        public static SystemUInt32 UInt(this IParser<string> parser, NumberStyles style)
        {
            var formatProvider = Defaults.GetDefaultFormatProvider(style);

            return SystemUInt32.Parse(parser?.OriginalValue, style, formatProvider);
        }

        public static SystemUInt32? UInt(this INullableParser<string> parser)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }
            else
            {
                return SystemUInt32.Parse(parser?.OriginalValue);
            }
        }

        public static SystemUInt32? UInt(this INullableParser<string> parser, NumberStyles style)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }
            else
            {
                var formatProvider = Defaults.GetDefaultFormatProvider(style);

                return SystemUInt32.Parse(parser?.OriginalValue, style, formatProvider);
            }
        }

        public static SystemUInt32? UInt(this ITryParser<string> parser)
        {
            return (SystemUInt32.TryParse(parser?.OriginalValue, out SystemUInt32 parsedValue))
                ? parsedValue
                : default(SystemUInt32?);
        }

        public static SystemUInt32? UInt(this ITryParser<string> parser, NumberStyles style)
        {
            var formatProvider = Defaults.GetDefaultFormatProvider(style);

            return (SystemUInt32.TryParse(parser?.OriginalValue, style, formatProvider, out SystemUInt32 parsedValue))
                ? parsedValue
                : default(SystemUInt32?);
        }
    }
}
