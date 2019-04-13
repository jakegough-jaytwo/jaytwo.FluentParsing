using System;
using SystemUri = System.Uri;

namespace jaytwo.FluentParsing
{
    public static class StringParserUriExtensions
    {
        public static SystemUri Uri(this IParser<string> parser)
        {
            return new SystemUri(parser?.OriginalValue);
        }

        public static SystemUri Uri(this IParser<string> parser, UriKind uriKind)
        {
            return new SystemUri(parser?.OriginalValue, uriKind);
        }

        public static SystemUri Uri(this INullableParser<string> parser)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }

            return new SystemUri(parser?.OriginalValue);
        }

        public static SystemUri Uri(this INullableParser<string> parser, UriKind uriKind)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }

            return new SystemUri(parser?.OriginalValue, uriKind);
        }

        public static SystemUri Uri(this ITryParser<string> parser)
        {
            try
            {
                return new SystemUri(parser?.OriginalValue);
            }
            catch
            {
                return null;
            }
        }

        public static SystemUri Uri(this ITryParser<string> parser, UriKind uriKind)
        {
            try
            {
                return new SystemUri(parser?.OriginalValue, uriKind);
            }
            catch
            {
                return null;
            }
        }
    }
}
