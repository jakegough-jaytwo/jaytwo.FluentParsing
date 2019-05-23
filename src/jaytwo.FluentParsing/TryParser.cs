namespace jaytwo.FluentParsing
{
    public class TryParser<T> : ITryParser<T>
    {
        public TryParser(T value)
        {
            OriginalValue = value;
        }

        public T OriginalValue { get; }
    }
}
