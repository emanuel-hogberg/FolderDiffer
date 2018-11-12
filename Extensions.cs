using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> t, Func<IEnumerable<T>, IEnumerable<T>> filterFunction) { return filterFunction(t); }
    }

    public static class ObjectExtensions
    {
        public static T AssignForward<T>(this T t, out T assign)
        {
            assign = t;
            return t;
        }
    }
}
