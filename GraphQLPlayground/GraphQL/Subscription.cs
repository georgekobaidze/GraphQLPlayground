using GraphQLPlayground.Models;

namespace GraphQLPlayground.GraphQL;

public class Subscription
{
    [Subscribe]
    [Topic]
    public Platform OnPlatformAdded([EventMessage] Platform platform) => platform;
}
