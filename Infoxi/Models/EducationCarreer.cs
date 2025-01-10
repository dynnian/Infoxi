using System.ComponentModel.DataAnnotations;

namespace Infoxi.Models;

public class EducationCarreer
{
    [Key]
    public int Id { get; set; }

    [StringLength(128)]
    public required string Name { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }
}