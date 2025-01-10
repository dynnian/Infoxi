using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infoxi.Models;

public class App
{
    [Key]
    public int Id { get; set; }

    [StringLength(64)]
    public required string Name { get; set; }

    [StringLength(512)]
    public string? Description { get; set; }

    public AppType AppType { get; set; }

    [Url]
    public required string WebSiteUrl { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }
}