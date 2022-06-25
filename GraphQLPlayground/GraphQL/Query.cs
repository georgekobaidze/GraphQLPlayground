using GraphQLPlayground.Data;
using GraphQLPlayground.Models;

namespace GraphQLPlayground.GraphQL;

public class Query
{
    [UseDbContext(typeof(AppDbContext))]
    [UseProjection]
    public IQueryable<Platform> GetPlatforms([ScopedService] AppDbContext context) => context.Platforms;

    [UseDbContext(typeof(AppDbContext))]
    [UseProjection]
    public IQueryable<Command> GetCommands([ScopedService] AppDbContext context) => context.Commands;
}
