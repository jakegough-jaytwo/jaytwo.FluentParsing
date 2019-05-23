namespace jaytwo.FluentParsing
{
    public class Parser<T> : IParser<T>
    {
        public Parser(T value)
        {
            OriginalValue = value;
        }

        public T OriginalValue { get; }

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
