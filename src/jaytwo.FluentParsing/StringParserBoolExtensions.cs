#pragma warning disable SA1121 // Use built-in type alias
using System;
using System.Globalization;
using System.Linq;
using SystemBoolean = System.Boolean;

namespace jaytwo.FluentParsing
{
    public static class StringParserBoolExtensions
    {
        public static SystemBoolean Bool(this IParser<string> parser) => Bool(parser?.OriginalValue);

        public static SystemBoolean? Bool(this INullableParser<string> parser)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }
            else
            {
                return Bool(parser?.OriginalValue);
            }
        }

        public static SystemBoolean? Bool(this ITryParser<string> parser)
        {
            try
            {
                return Bool(parser?.OriginalValue);
            }
            catch
            {
                return null;
            }
        }

        public static SystemBoolean YesNo(this IParser<string> parser) => YesNo(parser?.OriginalValue);

        public static SystemBoolean? YesNo(this INullableParser<string> parser)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }
            else
            {
                return YesNo(parser?.OriginalValue);
            }
        }

        public static SystemBoolean? YesNo(this ITryParser<string> parser)
        {
            try
            {
                return YesNo(parser?.OriginalValue);
            }
            catch
            {
                return null;
            }
        }

        public static SystemBoolean Bool(this IParser<string> parser, string trueValue, string falseValue) => Bool(parser, trueValue, falseValue, StringComparison.OrdinalIgnoreCase);

        public static SystemBoolean Bool(this IParser<string> parser, string trueValue, string falseValue, StringComparison stringComparison) => Bool(parser, new[] { trueValue }, new[] { falseValue }, stringComparison);

        public static SystemBoolean Bool(this IParser<string> parser, string[] trueValues, string[] falseValues) => Bool(parser?.OriginalValue, trueValues, falseValues, StringComparison.OrdinalIgnoreCase);

        public static SystemBoolean Bool(this IParser<string> parser, string[] trueValues, string[] falseValues, StringComparison stringComparison) => Bool(parser?.OriginalValue, trueValues, falseValues, stringComparison);

        public static SystemBoolean? Bool(this ITryParser<string> parser, string trueValue, string falseValue)
        {
            try
            {
                return Bool(parser?.OriginalValue, trueValue, falseValue);
            }
            catch
            {
                return null;
            }
        }

        public static SystemBoolean? Bool(this ITryParser<string> parser, string trueValue, string falseValue, StringComparison stringComparison)
        {
            try
            {
                return Bool(parser?.OriginalValue, trueValue, falseValue, stringComparison);
            }
            catch
            {
                return null;
            }
        }

        public static SystemBoolean? Bool(this ITryParser<string> parser, string[] trueValues, string[] falseValues)
        {
            try
            {
                return Bool(parser?.OriginalValue, trueValues, falseValues);
            }
            catch
            {
                return null;
            }
        }

        public static SystemBoolean? Bool(this ITryParser<string> parser, string[] trueValues, string[] falseValues, StringComparison stringComparison)
        {
            try
            {
                return Bool(parser?.OriginalValue, trueValues, falseValues, stringComparison);
            }
            catch
            {
                return null;
            }
        }

        public static SystemBoolean? Bool(this INullableParser<string> parser, string trueValue, string falseValue)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }

            return Bool(parser?.OriginalValue, trueValue, falseValue);
        }

        public static SystemBoolean? Bool(this INullableParser<string> parser, string trueValue, string falseValue, StringComparison stringComparison)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }

            return Bool(parser?.OriginalValue, trueValue, falseValue, stringComparison);
        }

        public static SystemBoolean? Bool(this INullableParser<string> parser, string[] trueValues, string[] falseValues)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }

            return Bool(parser?.OriginalValue, trueValues, falseValues);
        }

        public static SystemBoolean? Bool(this INullableParser<string> parser, string[] trueValues, string[] falseValues, StringComparison stringComparison)
        {
            if (string.IsNullOrEmpty(parser?.OriginalValue))
            {
                return null;
            }

            return Bool(parser?.OriginalValue, trueValues, falseValues, stringComparison);
        }

        private static SystemBoolean YesNo(string value) => YesNo(value, StringComparison.OrdinalIgnoreCase);

        private static SystemBoolean YesNo(string value, StringComparison stringComparison) => Bool(value, new[] { "yes", "y" }, new[] { "no", "n" }, stringComparison);

        private static SystemBoolean Bool(string value) => Bool(value, StringComparison.OrdinalIgnoreCase);

        private static SystemBoolean Bool(string value, StringComparison stringComparison) => Bool(value, SystemBoolean.TrueString, SystemBoolean.FalseString, stringComparison);

        private static SystemBoolean Bool(string value, string trueValue, string falseValue) => Bool(value, trueValue, falseValue, StringComparison.OrdinalIgnoreCase);

        private static SystemBoolean Bool(string value, string trueValue, string falseValue, StringComparison stringComparison) => Bool(value, new[] { trueValue }, new[] { falseValue }, stringComparison);

        private static SystemBoolean Bool(string value, string[] trueValues, string[] falseValues) => Bool(value, trueValues, falseValues, StringComparison.OrdinalIgnoreCase);

        private static SystemBoolean Bool(string value, string[] trueValues, string[] falseValues, StringComparison stringComparison)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            else if (trueValues.Any(x => string.Equals(x, value, StringComparison.OrdinalIgnoreCase)))
            {
                return true;
            }
            else if (falseValues.Any(x => string.Equals(x, value, StringComparison.OrdinalIgnoreCase)))
            {
                return false;
            }
            else
            {
                throw new FormatException($"Cannot parse boolean; Unknown value: '{value}'");
            }
        }
    }
}
#pragma warning restore SA1121 // Use built-in type alias
