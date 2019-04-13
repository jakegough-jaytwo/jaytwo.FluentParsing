namespace jaytwo.FluentParsing
{
    public static class StringExtensions
    {
        public static IParser<string> Parse(this string value)
        {
            return new Parser<string>(value);
        }
    }
}
