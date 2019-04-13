using System;
using System.Reflection;
using SystemEnum = System.Enum;

namespace jaytwo.FluentParsing
{
    public static class StringParserEnumExtensions
    {
        public static T Enum<T>(this IParser<string> parser, bool ignoreCase = true) where T : struct
        {
            ValidateIsEnum<T>();
            return ParseAndCast<T>(parser?.OriginalValue, ignoreCase);
        }

        public static T Enum<T>(this IParser<string> parser) where T : struct => Enum<T>(parser, true);

        public static T? Enum<T>(this INullableParser<string> parser, bool ignoreCase = true) where T : struct
        {
            ValidateIsEnum<T>();

            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }

            return ParseAndCast<T>(parser?.OriginalValue, ignoreCase);
        }

        public static T? Enum<T>(this INullableParser<string> parser) where T : struct => Enum<T>(parser, true);

        public static T? Enum<T>(this ITryParser<string> parser, bool ignoreCase = true) where T : struct
        {
            ValidateIsEnum<T>();

            try
            {
                return ParseAndCast<T>(parser?.OriginalValue, ignoreCase);
            }
            catch
            {
                return null;
            }
        }

        public static T? Enum<T>(this ITryParser<string> parser) where T : struct => Enum<T>(parser, true);

        private static void ValidateIsEnum<T>()
        {
            if (!typeof(T).GetTypeInfo().IsEnum)
            {
                throw new NotSupportedException($"{nameof(T)} must be an {nameof(Enum)}.");
            }
        }

        private static T ParseAndCast<T>(string value, bool ignoreCase) => (T)SystemEnum.Parse(typeof(T), value, ignoreCase);
    }
}
