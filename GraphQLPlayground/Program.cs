using GraphQL.Server.Ui.Voyager;
using GraphQLPlayground.Data;
using GraphQLPlayground.GraphQL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var configuration = builder.Configuration;
var connectionString = configuration.GetConnectionString("GraphQLPlaygroundConnectionString");

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddGraphQLServer().AddQueryType<Query>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapControllers();

app.UseRouting();

app.UseEndpoints(enpoints =>
{
    enpoints.MapGraphQL();
});

app.UseGraphQLVoyager(new VoyagerOptions
{
    GraphQLEndPoint = "/graphql"
}, "/graphql-voyager");

app.Run();
