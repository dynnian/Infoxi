using System.ComponentModel.DataAnnotations;

namespace Infoxi.Models;

public class Hobbies
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(256)]
    public required string Name { get; set; }

    [StringLength(512)]
    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }
}