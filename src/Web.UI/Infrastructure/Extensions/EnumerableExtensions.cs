using System;
using System.Collections.Generic;

namespace Web.UI.Infrastructure.Extensions
{
    public static class EnumerableExtensions
    {
        public static void each<T>(this IEnumerable<T> items, Action<T> action)
        {
            foreach (var item in items)
                action(item);
        }
    }
}