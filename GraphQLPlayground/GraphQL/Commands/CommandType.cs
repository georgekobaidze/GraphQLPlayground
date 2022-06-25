using GraphQLPlayground.Data;
using GraphQLPlayground.Models;

namespace GraphQLPlayground.GraphQL.Commands;

public class CommandType : ObjectType<Command>
{
    protected override void Configure(IObjectTypeDescriptor<Command> descriptor)
    {
        descriptor.Description("Directives for managing platforms");
        descriptor
            .Field(x => x.Platform)
            .ResolveWith<Resolvers>(x => x.GetPlatform(default!, default!))
            .UseDbContext<AppDbContext>()
            .Description("Platform that supports this command");
    }

    private class Resolvers
    {
        public Platform GetPlatform([Parent] Command command, [ScopedService] AppDbContext context) 
            => context.Platforms.FirstOrDefault(x => x.Id == command.PlatformId);
    }
}
