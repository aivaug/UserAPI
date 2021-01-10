using System.Linq;
using UserAPI.Models;

namespace UserAPI.Helpers
{
    public static class LinqExtensions
    {
        public static IQueryable<T> WhereExists<T>(this IQueryable<T> items)
        {
            return items.Where(i => !(i as BaseModel).IsDeleted);
        }
    }
}
