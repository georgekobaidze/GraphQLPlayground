using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraphQLPlayground.Models;

[Table("command")]
public class Command
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("how-to")]
    [Required]
    public string HowTo { get; set; }

    [Column("command-line")]
    [Required]
    public string CommandLine { get; set; }

    [Column("platform-id")]
    [Required]
    public int PlatformId { get; set; }

    public Platform Platform { get; set; }
}
