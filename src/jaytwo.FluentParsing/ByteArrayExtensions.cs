namespace jaytwo.FluentParsing
{
    public static class ByteArrayExtensions
    {
        public static IParser<byte[]> Parse(this byte[] value)
        {
            return new Parser<byte[]>(value);
        }
    }
}
