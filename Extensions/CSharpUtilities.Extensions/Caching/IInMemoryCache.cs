using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpUtilities.Extensions.Caching
{
    public interface IInMemoryCache
    {
        bool TryGetValue<T>(string entryKey, out T cacheEntry);

        T Set<T>(string entryKey, T cacheEntry, InMemoryCacheOffset offset);

        void Remove(string entryKey);
    }
}
