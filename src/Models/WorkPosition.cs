using System.ComponentModel.DataAnnotations;

namespace Infoxi.Models;

public class WorkPosition
{
    [Key]
    public Guid Id { get; set; }

    public string Name { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }
}