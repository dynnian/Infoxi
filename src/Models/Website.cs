using System.ComponentModel.DataAnnotations;

namespace Infoxi.Models;

public class Website
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(64)]
    public required string Name { get; set; }

    [Url]
    public required string Url { get; set; }

    public bool IsPrimary { get; set; } = false;

    public bool IsActive { get; set; } = false;

    [StringLength(512)]
    public string? Description { get; set; }
}