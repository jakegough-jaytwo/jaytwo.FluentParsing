using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaytwo.FluentParsing
{
    public interface ITryParser<T>
    {
        T OriginalValue { get; }
    }
}
