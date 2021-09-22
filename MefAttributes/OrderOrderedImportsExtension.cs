using System;
using System.Collections.Generic;
using System.Linq;

namespace MEFAttributes
{
    public static class OrderOrderedImportsExtension
    {
        public static IEnumerable<T> Order<T>(this IEnumerable<Lazy<T, IOrderMetadata>> imports)
        {    
            return imports.OrderBy(i => i.Metadata.Order).Select(i => i.Value);
        }
    }
}
