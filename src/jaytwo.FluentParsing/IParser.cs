namespace jaytwo.FluentParsing
{
    public interface IParser<T>
    {
        T OriginalValue { get; }

        INullableParser<T> Nullable();

        ITryParser<T> Try();
    }
}
