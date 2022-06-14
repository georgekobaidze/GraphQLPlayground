using GraphQLPlayground.Data;
using GraphQLPlayground.Models;

namespace GraphQLPlayground.GraphQL;

public class Query
{
    public IQueryable<Platform> GetPlatform([Service] AppDbContext context) => context.Platforms;
}
