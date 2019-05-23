using System;
using System.Globalization;
using SystemDateTime = System.DateTime;

namespace jaytwo.FluentParsing
{
    public static class StringParserDateTimeExtensions
    {
        public static SystemDateTime DateTime(this IParser<string> parser)
        {
            return SystemDateTime.Parse(parser?.OriginalValue);
        }

        public static SystemDateTime DateTime(this IParser<string> parser, IFormatProvider formatProvider, DateTimeStyles styles)
        {
            return SystemDateTime.Parse(parser?.OriginalValue, formatProvider, styles);
        }

        public static SystemDateTime? DateTime(this INullableParser<string> parser)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }

            return SystemDateTime.Parse(parser?.OriginalValue);
        }

        public static SystemDateTime? DateTime(this INullableParser<string> parser, IFormatProvider formatProvider, DateTimeStyles styles)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }

            return SystemDateTime.Parse(parser?.OriginalValue, formatProvider, styles);
        }

        public static SystemDateTime? DateTime(this ITryParser<string> parser)
        {
            return SystemDateTime.TryParse(parser?.OriginalValue, out SystemDateTime parsedValue)
                ? parsedValue
                : default(SystemDateTime?);
        }

        public static SystemDateTime? DateTime(this ITryParser<string> parser, IFormatProvider formatProvider, DateTimeStyles styles)
        {
            return SystemDateTime.TryParse(parser?.OriginalValue, formatProvider, styles, out SystemDateTime parsedValue)
                ? parsedValue
                : default(SystemDateTime?);
        }
    }
}
