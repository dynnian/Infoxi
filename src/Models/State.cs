using System.ComponentModel.DataAnnotations;

namespace Infoxi.Models;

public class State
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(64)]
    public required string Name { get; set; }

    [StringLength(2)]
    public required string Abbreviation { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }
}