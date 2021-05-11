using System.Linq;
using HotChocolate;
using HotChocolate.Data;
using TodoListGQL.Data;
using TodoListGQL.Models;

namespace TodoListGQL.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(ApiDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<ItemList> GetList([ScopedService] ApiDbContext context)
        {
            return context.Lists;
        }

        [UseDbContext(typeof(ApiDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<ItemData> GetDatas([ScopedService] ApiDbContext context)
        {
            return context.Items;
        }
    }
}