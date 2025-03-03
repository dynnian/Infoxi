using System.ComponentModel.DataAnnotations;

namespace Infoxi.Models;

public class Color
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(32)]
    public required string Name { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdateAt { get; set; }
}
