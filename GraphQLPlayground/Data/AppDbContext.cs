using GraphQLPlayground.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLPlayground.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) 
        : base(options) { }

    public DbSet<Platform> Platforms { get; set; }
    public DbSet<Command> Commands { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Platform>()
            .HasMany(x => x.Commands)
            .WithOne(x => x.Platform)
            .HasForeignKey(x => x.PlatformId);
    }
}
