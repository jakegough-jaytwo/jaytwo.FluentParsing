namespace jaytwo.FluentParsing
{
    public class Parser<T> : IParser<T>
    {
        public T OriginalValue { get; }

        public Parser(T value)
        {
            OriginalValue = value;
        }

        public INullableParser<T> Nullable()
        {
            return new NullableParser<T>(OriginalValue);
        }

        public ITryParser<T> Try()
        {
            return new TryParser<T>(OriginalValue);
        }
    }
}
