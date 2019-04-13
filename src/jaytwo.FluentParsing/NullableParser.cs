namespace jaytwo.FluentParsing
{
    public class NullableParser<T> : INullableParser<T>
    {
        public T OriginalValue { get; }

        public NullableParser(T value)
        {
            OriginalValue = value;
        }
    }
}
