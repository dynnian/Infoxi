namespace Infoxi.Models;

public class CompanyAppUsage
{
    public required Company Company { get; set; }

    public required App App { get; set; }

    public string? Purpose { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }
}