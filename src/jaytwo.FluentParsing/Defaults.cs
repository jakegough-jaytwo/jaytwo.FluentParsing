using System;
using System.ComponentModel;
using System.Globalization;

namespace jaytwo.FluentParsing
{
    internal static class Defaults
    {
        public static IFormatProvider GetDefaultFormatProvider(NumberStyles style)
        {
            return ((style & NumberStyles.AllowCurrencySymbol) > 0)
                ? new CultureInfo("en-US")
                : CultureInfo.InvariantCulture;
        }

#if NETSTANDARD2_0 || NET45
        public static T Parse<T>(this string value)
        {
            var converter = TypeDescriptor.GetConverter(typeof(T));

            if (converter == null)
            {
                throw new InvalidOperationException($"Cannot get type converter for '{typeof(T)}'.");
            }

            var result = (T)converter.ConvertFromString(value);

            return result;
        }
#endif
    }
}
