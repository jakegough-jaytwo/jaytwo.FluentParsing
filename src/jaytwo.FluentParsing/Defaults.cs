using System;
using System.ComponentModel;
using System.Globalization;

namespace jaytwo.FluentParsing
{
    internal static class Defaults
    {
        public static IFormatProvider GetDefaultFormatProvider(NumberStyles style)
        {
            var result = ((style & NumberStyles.AllowCurrencySymbol) > 0)
                ? new CultureInfo("en-US")
                : CultureInfo.InvariantCulture;

            return result;
        }
    }
}
