namespace Infoxi.Models;

public class PersonAppUsage
{
    public required Person Person { get; set; }

    public required App App { get; set; }

    public Device? Device { get; set; }

    public string? Purpose { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }
}