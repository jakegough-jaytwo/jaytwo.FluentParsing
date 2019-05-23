using System;
using SystemGuid = System.Guid;

namespace jaytwo.FluentParsing
{
    public static class StringParserGuidExtensions
    {
        public static SystemGuid Guid(this IParser<string> parser)
        {
            return SystemGuid.Parse(parser?.OriginalValue);
        }

        public static SystemGuid? Guid(this INullableParser<string> parser)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }

            return SystemGuid.Parse(parser?.OriginalValue);
        }

        public static SystemGuid? Guid(this ITryParser<string> parser)
        {
            return SystemGuid.TryParse(parser?.OriginalValue, out Guid parsedValue)
                ? parsedValue
                : default(Guid?);
        }
    }
}
