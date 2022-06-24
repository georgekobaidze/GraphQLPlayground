using GraphQLPlayground.Data;
using GraphQLPlayground.Models;

namespace GraphQLPlayground.GraphQL;

public class Query
{
    [UseDbContext(typeof(AppDbContext))]
    [UseProjection]
    public IQueryable<Platform> GetPlatform([ScopedService] AppDbContext context) => context.Platforms;
}
