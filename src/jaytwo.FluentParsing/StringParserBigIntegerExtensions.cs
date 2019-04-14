using System;
using System.Globalization;
using System.Numerics;
using SystemNumericsBigInteger = System.Numerics.BigInteger;

namespace jaytwo.FluentParsing
{
    public static class StringParserBigIntegerExtensions
    {
        public static SystemNumericsBigInteger BigInteger(this IParser<string> parser)
        {
            return SystemNumericsBigInteger.Parse(parser?.OriginalValue);
        }

        public static SystemNumericsBigInteger BigInteger(this IParser<string> parser, NumberStyles style)
        {
            var formatProvider = Defaults.GetDefaultFormatProvider(style);

            return SystemNumericsBigInteger.Parse(parser?.OriginalValue, style, formatProvider);
        }

        public static SystemNumericsBigInteger? BigInteger(this INullableParser<string> parser)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }
            else
            {
                return SystemNumericsBigInteger.Parse(parser?.OriginalValue);
            }
        }

        public static SystemNumericsBigInteger? BigInteger(this INullableParser<string> parser, NumberStyles style)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }
            else
            {
                var formatProvider = Defaults.GetDefaultFormatProvider(style);

                return SystemNumericsBigInteger.Parse(parser?.OriginalValue, style, formatProvider);
            }
        }

        public static SystemNumericsBigInteger? BigInteger(this ITryParser<string> parser)
        {
            return (SystemNumericsBigInteger.TryParse(parser?.OriginalValue, out SystemNumericsBigInteger parsedValue))
                ? parsedValue
                : default(SystemNumericsBigInteger?);
        }

        public static SystemNumericsBigInteger? BigInteger(this ITryParser<string> parser, NumberStyles style)
        {
            var formatProvider = Defaults.GetDefaultFormatProvider(style);

            return (SystemNumericsBigInteger.TryParse(parser?.OriginalValue, style, formatProvider, out SystemNumericsBigInteger parsedValue))
                ? parsedValue
                : default(SystemNumericsBigInteger?);
        }
    }
}
