namespace jaytwo.FluentParsing
{
    public class TryParser<T> : ITryParser<T>
    {
        public T OriginalValue { get; }

        public TryParser(T value)
        {
            OriginalValue = value;
        }
    }
}
