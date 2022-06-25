using GraphQLPlayground.Data;
using GraphQLPlayground.Models;

namespace GraphQLPlayground.GraphQL.Platforms;

public class PlatformType : ObjectType<Platform>
{
    protected override void Configure(IObjectTypeDescriptor<Platform> descriptor)
    {
        descriptor.Description("Represents any software or service that has a command line interface.");
        descriptor.Field(x => x.LicenseKey).Ignore();

        descriptor
            .Field(x => x.Commands)
            .ResolveWith<Resolvers>(x => x.GetCommands(default!, default!))
            .UseDbContext<AppDbContext>()
            .Description("List of the available commands for this platform");
    }

    private class Resolvers
    {
        public IQueryable<Command> GetCommands([Parent] Platform platform, [ScopedService] AppDbContext context) 
            => context.Commands.Where(x => x.PlatformId == platform.Id);
    }
}
