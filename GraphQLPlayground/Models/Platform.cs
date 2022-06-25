using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraphQLPlayground.Models;

[GraphQLDescription("Represents any software or service that has a command line interface.")]
[Table("platforms")]
public class Platform
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [Column("name")]
    public string Name { get; set; }

    [GraphQLDescription("Represents a purchased, valid license for the platform.")]
    [Column("license-key")]
    public string? LicenseKey { get; set; }

    public ICollection<Command> Commands { get; set; } = new List<Command>();
}
