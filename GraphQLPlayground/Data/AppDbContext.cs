using GraphQLPlayground.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLPlayground.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) 
        : base(options) { }

    public DbSet<Platform> Platforms { get; set; }
}
