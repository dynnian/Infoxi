using System.ComponentModel.DataAnnotations;

namespace Infoxi.Models;

public class Employment
{
    [Key]
    public Guid Id { get; set; }

    public required Person Person { get; set; }

    public Company? Company { get; set; }

    public required WorkPosition Position { get; set; }

    public DateTime? Since { get; set; }

    public DateTime? Until { get; set; }

    public bool IsPrimary { get; set; } = true;

    public bool IsActive { get; set; } = true;

    public bool WasRemoved { get; set; } = true;

    public string? ReasonForLeaving { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }
}