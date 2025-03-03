namespace Infoxi.Models;

public class Nationality
{
    public Person Person { get; set; }

    public Country Country { get; set; }

    public DateTime? Since { get; set; }

    public DateTime? Until { get; set; }

    public bool IsCurrent { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }
}