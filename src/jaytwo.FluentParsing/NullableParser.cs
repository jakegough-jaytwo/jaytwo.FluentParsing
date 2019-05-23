namespace jaytwo.FluentParsing
{
    public class NullableParser<T> : INullableParser<T>
    {
        public NullableParser(T value)
        {
            OriginalValue = value;
        }

        public T OriginalValue { get; }
    }
}
