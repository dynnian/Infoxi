using System.ComponentModel.DataAnnotations;

namespace Infoxi.Models;

public class SocialProfile
{
    [Key]
    public Guid Id { get; set; }

    public required Person Person { get; set; }

    public required App SocialPlatform { get; set; }

    public required string Username { get; set; }

    [Url]
    public required string Url { get; set; }

    public DateTime? Since { get; set; }

    public DateTime? Until { get; set; }

    public bool IsPrimary { get; set; } = true;

    public bool IsActive { get; set; } = true;

    public bool WasRemoved { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }
}